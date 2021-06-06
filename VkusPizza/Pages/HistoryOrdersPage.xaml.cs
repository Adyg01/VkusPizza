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
using VkusPizza.Data;
using VkusPizza.Classes;

namespace VkusPizza.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoryOrdersPage.xaml
    /// </summary>
    public partial class HistoryOrdersPage : Page
    {
        private Order currentUser = new Order();
        public HistoryOrdersPage()
        {
            InitializeComponent();
            dGridHistoryOrders.ItemsSource = DBVkusPizaaEntities.getContext().HistoryOrders.ToList();
        }

        private void btnPrintHistoryOrder_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new PrintForm());
        }
    }
}
