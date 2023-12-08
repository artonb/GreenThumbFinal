using GreenThumbFinal.Database;
using GreenThumbFinal.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbFinal
{
    /// <summary>
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window
    {
        public PlantDetailsWindow(Plants selectedPlant)
        {
            InitializeComponent();
            //GetDetails();
            using (GreenThumbDbContext context = new())
            {
                txtName.Text = selectedPlant.Name;
                Repository<Plants> plantRepository = new(context);
                Repository<Instructions> instructionRepository = new(context);

                var allInstructions = instructionRepository.GetAll();

                var selectedInstructions = allInstructions.Where(p => p.PlantsId == selectedPlant.PlantsId);

                foreach (var instruction in selectedInstructions)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = instruction;
                    item.Content = instruction.Info;
                    lstInstructions.Items.Add(item);
                }
            }
        }

        //public void GetDetails(Plants selectedPlant)
        //{
        //    using (GreenThumbDbContext context = new())
        //    {
        //        txtName.Text = selectedPlant.Name;
        //        Repository<Plants> plantRepository = new(context);
        //        Repository<Instructions> instructionRepository = new(context);

        //        var allInstructions = instructionRepository.GetAll();

        //        var selectedInstructions = allInstructions.Where(p => p.PlantsId == selectedPlant.PlantsId);

        //        foreach (var instruction in selectedInstructions)
        //        {
        //            ListViewItem item = new ListViewItem();
        //            item.Tag = instruction;
        //            item.Content = instruction.Info;
        //            lstInstructions.Items.Add(item);
        //        }
        //    }
        //}

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }


        //public void GetDetails(Plants selectedPlant)
        //{
        //    using (GreenThumbDbContext context = new())
        //    {
        //        txtName.Text = selectedPlant.Name;

        //        Repository<Plants> plantRepository = new(context);
        //        Repository<Instructions> instructionRepository = new(context);

        //        var allInstructions = instructionRepository.GetAll();

        //        var selectedInstructions = allInstructions.Where(p => p.PlantsId == selectedPlant.PlantsId);

        //        foreach (var instruction in selectedInstructions)
        //        {
        //            ListViewItem item = new ListViewItem();
        //            item.Tag = instruction;
        //            item.Content = instruction.Info;
        //            lstInstructions.Items.Add(item);
        //        }
        //    }
        //}
    }
}
