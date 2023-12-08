using GreenThumbFinal.Database;
using GreenThumbFinal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Plants> allPlants;
        private List<Plants> filteredPlants;
        public MainWindow()
        {
            InitializeComponent();

            using (GreenThumbDbContext context = new())
            {
                var repository = new Repository<Plants>(context);

                var allPlants = repository.GetAll();
                var filteredPlants = allPlants;

                foreach (var plant in filteredPlants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name;
                    lstView.Items.Add(item);
                }
            }
        }


        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (GreenThumbDbContext context = new())
            {
                var repository = new Repository<Plants>(context);

                var allPlants = repository.GetAll();
                string searchPlant = txtSearch.Text.ToLower();

                //var filtererdPlants = allPlants;
                var filteredPlants = allPlants.Where(p => p.Name.ToLower().Contains(searchPlant));
                lstView.Items.Clear();

                foreach (var plant in filteredPlants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name;
                    lstView.Items.Add(item);
                }
            }
        }



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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPlantWindow addPlantWindow = new();
            addPlantWindow.Show();
            Close();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstView.SelectedItem;
            if (selectedItem != null)
            {
                Plants plantsToRemove = (Plants)selectedItem.Tag;
                if (selectedItem != null)
                {
                    var results = MessageBox.Show("Are you sure you want to delete this?", "Warning!", MessageBoxButton.YesNo);
                    if (results == MessageBoxResult.Yes)
                    {
                        lstView.Items.Remove(lstView.SelectedItem);

                        using (GreenThumbDbContext context = new())
                        {
                            var repository = new Repository<Plants>(context);
                            repository.Delete(plantsToRemove);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You need to select the item you want to delete!", "Item not selected!");
                    }


                }
            }
        }
    }
}
