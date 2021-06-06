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
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
        }

        private void btnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new EditOrdersPage(null));
        }

        private void btnReEditOrder_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new EditOrdersPage((sender as Button).DataContext as Order));
        }

        private void btnDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            var orderForRemoving = dGridOrder.SelectedItems.Cast<Order>().ToList();
            if (MessageBox.Show($"Вы точно хотите отменить следующие {orderForRemoving.Count()} заказов?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                foreach (Order orders in orderForRemoving)
                {
                    orders.IdStatus = 2;
                    try
                    {
                        string stat = "Отменён";
                        HistoryOrders historyOrder = new HistoryOrders();
                        historyOrder.UserName = Manager.userSurname;
                        historyOrder.IdOrder = orders.Id;
                        historyOrder.Price = orders.Cost;
                        historyOrder.Status = stat;
                        DBVkusPizaaEntities.getContext().HistoryOrders.Add(historyOrder);
                        DBVkusPizaaEntities.getContext().SaveChanges();
                        DBVkusPizaaEntities.getContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                        dGridOrder.ItemsSource = DBVkusPizaaEntities.getContext().Order.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                MessageBox.Show("Заказ-(ы) отменены!");
            }

            
        }

        private void btnCompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            var orderForRemoving = dGridOrder.SelectedItems.Cast<Order>().ToList();
            if (MessageBox.Show($"Вы точно хотите завершить следующие {orderForRemoving.Count()} заказов?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                foreach (Order orders in orderForRemoving)
                {
                    orders.IdStatus = 3;
                    try
                    {
                        string stat = "Завершен";
                        HistoryOrders historyOrder = new HistoryOrders();
                        historyOrder.UserName = Manager.userSurname;
                        historyOrder.IdOrder = orders.Id;
                        historyOrder.Price = orders.Cost;
                        historyOrder.Status = stat;
                        DBVkusPizaaEntities.getContext().HistoryOrders.Add(historyOrder);
                        DBVkusPizaaEntities.getContext().SaveChanges();
                        
                        DBVkusPizaaEntities.getContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                        dGridOrder.ItemsSource = DBVkusPizaaEntities.getContext().Order.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                MessageBox.Show("Заказ-(ы) завершены!");
            }

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                DBVkusPizaaEntities.getContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dGridOrder.ItemsSource = DBVkusPizaaEntities.getContext().Order.ToList();
            }
        }

        private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void Update()
        {
            dGridOrder.ItemsSource = DBVkusPizaaEntities.getContext().Order.ToList().Where(p => p.CustomerName.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.DeliveryStreet.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.Id.ToString().ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.DeliveryHome.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.PaymentMethod.Payments.ToLower().Contains(txtBoxSearch.Text.ToLower())).ToList();
            if(dGridOrder.Items.Count == 0)
            {
                labelSearchBad.Visibility = Visibility.Visible;
                dGridOrder.Visibility = Visibility.Collapsed;
            }
            else
            {
                dGridOrder.Visibility = Visibility.Visible;
                labelSearchBad.Visibility = Visibility.Collapsed;
            }
        }

        private void comboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}
