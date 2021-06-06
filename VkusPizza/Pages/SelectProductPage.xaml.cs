using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VkusPizza.Classes;
using VkusPizza.Data;

namespace VkusPizza.Pages
{
    /// <summary>
    /// Логика взаимодействия для SelectProductPage.xaml
    /// </summary>
    public partial class SelectProductPage : Page
    {
        public SelectProductPage()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            listViewProduct.ItemsSource = DBVkusPizaaEntities.getContext().Product.ToList().Where(p => p.Title.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.Cost.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.Description.ToLower().Contains(txtBoxSearch.Text.ToLower())).ToList();

            if (listViewProduct.Items.Count == 0)
            {
                labelSearchBad.Visibility = Visibility.Visible;
                listViewProduct.Visibility = Visibility.Collapsed;
            }
            else
            {
                listViewProduct.Visibility = Visibility.Visible;
                labelSearchBad.Visibility = Visibility.Collapsed;
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                DBVkusPizaaEntities.getContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                listViewProduct.ItemsSource = DBVkusPizaaEntities.getContext().Product.ToList();
                Update();
            }
        }

        private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void btnAddOrderProduct_Click(object sender, RoutedEventArgs e)
        {
            List<Product> temp = new List<Product>();
            for(int i = 0; i < listViewProduct.SelectedItems.Count; i++)
            {
                temp.Add((Product) listViewProduct.SelectedItems[i]);
            }
            Classes.Data.productsOrder = temp;
            Manager.mainFrame.GoBack();
        }
    }
}
