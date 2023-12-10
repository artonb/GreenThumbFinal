using GreenThumbFinal.Database;
using GreenThumbFinal.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbFinal
{
    public partial class PlantDetailsWindow : Window
    {
        public PlantDetailsWindow(Plants selectedPlant)
        {
            InitializeComponent();

            //Display details on the selected item
            using (GreenThumbDbContext context = new())
            {
                //Give the textbox the name of the selected item
                txtName.Text = selectedPlant.Name;

                //Create repostitories for plants and instructions
                Repository<Plants> plantRepository = new(context);
                Repository<Instructions> instructionRepository = new(context);

                //Get all instructions from repository
                var allInstructions = instructionRepository.GetAll();

                //Filter instructions after PlantsId
                var selectedInstructions = allInstructions.Where(p => p.PlantsId == selectedPlant.PlantsId);

                //Display selected plants instructions in the ListView
                foreach (var instruction in selectedInstructions)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = instruction;
                    item.Content = instruction.Info;
                    lstInstructions.Items.Add(item);
                }
            }
        }

        //Navigate to mainWindow
        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }
    }
}
