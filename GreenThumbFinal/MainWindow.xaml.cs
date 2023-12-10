using GreenThumbFinal.Database;
using GreenThumbFinal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbFinal
{
    public partial class MainWindow : Window
    {
        //Holds all data from database and filteredPlants based on search
        private List<Plants> allPlants;
        private List<Plants> filteredPlants;
        public MainWindow()
        {
            InitializeComponent();

            using (GreenThumbDbContext context = new())
            {
                var repository = new Repository<Plants>(context);

                //Get all plants from repository
                var allPlants = repository.GetAll();
                var filteredPlants = allPlants;

                //Display all gotten plants in a ListView
                foreach (var plant in filteredPlants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name;
                    lstView.Items.Add(item);
                }
            }
        }

        //Filter plants based on the text input in searchbar
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (GreenThumbDbContext context = new())
            {
                var repository = new Repository<Plants>(context);

                //Get all plants from repository
                var allPlants = repository.GetAll();
                string searchPlant = txtSearch.Text.ToLower();

                //Filter plants based on text input in searchbar
                var filteredPlants = allPlants.Where(p => p.Name.ToLower().Contains(searchPlant));
                lstView.Items.Clear();

                //Display filtered plants in the ListView
                foreach (var plant in filteredPlants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name;
                    lstView.Items.Add(item);
                }
            }
        }

        //Display details in another window about the selected plant
        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstView.SelectedItem;
            if (selectedItem != null)
            {
                Plants selectedPlant = (Plants)selectedItem.Tag;
                PlantDetailsWindow travelDetailWindow = new(selectedPlant);
                travelDetailWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("You need to select the item you want more details on!", "Item not selected!");
            }
        }

        //Opens the AddPlantWindow
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPlantWindow addPlantWindow = new();
            addPlantWindow.Show();
            Close();
        }

        //Removes selected item from the ListView and database
        private async void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstView.SelectedItem;
            Plants plantsToRemove = (Plants)selectedItem.Tag;
            if (selectedItem != null)
            {
                //Ask for comfirmation
                var results = MessageBox.Show("Are you sure you want to delete this?", "Warning!", MessageBoxButton.YesNo);
                if (results == MessageBoxResult.Yes)
                {
                    //Remove from ListView
                    lstView.Items.Remove(lstView.SelectedItem);

                    //Remove from database
                    using (GreenThumbDbContext context = new())
                    {
                        var repository = new Repository<Plants>(context);
                        repository.Delete(plantsToRemove);
                    }
                }
                else
                {
                    //If not selected, messagebox.
                    MessageBox.Show("You need to select the item you want to delete!", "Item not selected!");
                }
            }
        }
    }
}
