using System.Windows;
using System.Windows.Controls;

namespace GreenThumbFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private List<Plants> allPlants;
        public MainWindow()
        {
            InitializeComponent();

            //Load plants
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //PerformSearch(txtSearch.Text);
        }

        //        private void PerformSearch(string text)
        //        {
        //            if (string.IsNullOrWhiteSpace(searchText))
        //            {
        //                // If the search text is empty, show all original items
        //                lstView.ItemsSource = (Ändra till att visa alla dina hårdkodade);
        //            }
        //            else
        //            {
        //                // Filter items based on search text
        //                var filteredItems = originalItems
        //                    .Where(item => item.Contains(searchText, StringComparison.OrdinalIgnoreCase)) // Case-insensitive search
        //                    .ToList();

        //                lstView.ItemsSource = filteredItems;
        //            }
    }
};
