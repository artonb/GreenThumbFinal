using GreenThumbFinal.Database;
using GreenThumbFinal.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbFinal
{
    /// <summary>
    /// Interaction logic for AddPlantWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        public AddPlantWindow()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            //Navigate to mainwindow if you press return
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }

        private void btnAddInstruction_Click(object sender, RoutedEventArgs e)
        {
            //Check for empty boxes
            if (string.IsNullOrWhiteSpace(txtInstruction.Text))
            {
                MessageBox.Show("Please enter a instruction!");
            }
            else
            {
                using (var context = new GreenThumbDbContext())
                {
                    //Create a variable with instruction input
                    string instruction = txtInstruction.Text;

                    //Create a object with the instructions
                    Instructions newInstructions = new Instructions()
                    {
                        Info = instruction
                    };

                    //Add the instructions to the ListView
                    ListViewItem item = new();
                    item.Tag = newInstructions;
                    item.Content = instruction;
                    txtInstruction.Clear();
                    lstView.Items.Add(item);
                }
            }
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Check for empty inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a plantname!");
            }
            else
            {
                using (var context = new GreenThumbDbContext())
                {
                    //Look through existingPlants and see if there is a plant with the same name
                    var existingPlant = await context.Plants.FirstOrDefaultAsync(p => p.Name.Equals(txtName.Text));

                    if (existingPlant != null)
                    {
                        MessageBox.Show("That plant is already in your list");
                    }
                    else
                    {
                        //Create a variable with name input
                        string plantName = txtName.Text;

                        //Create a object with the plantname
                        Plants newPlant = new Plants()
                        {
                            Name = plantName
                        };

                        //Create repositories for plants and instructions 
                        Repository<Plants> plantsRepository = new(context);
                        Repository<Instructions> instructionsRepository = new(context);

                        //Add and save the newPlant
                        await plantsRepository.AddAsync(newPlant);
                        await plantsRepository.SaveChangesAsync();

                        //Go through the instructions and add them as a newInstruction
                        foreach (ListViewItem instruction in lstView.Items)
                        {
                            Instructions newInstruction = (Instructions)instruction.Tag;
                            newInstruction.PlantsId = newPlant.PlantsId;
                            await instructionsRepository.AddAsync(newInstruction);
                            await instructionsRepository.SaveChangesAsync();
                        }
                        //Inform the user that the plant is added and navigate to mainWindow
                        MessageBox.Show("Plant added!");
                        MainWindow mainWindow = new();
                        mainWindow.Show();
                        Close();
                    }
                }
            }
        }
    }
}



