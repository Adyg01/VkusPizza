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
using VkusPizza.Pages;
using VkusPizza.Classes;

namespace VkusPizza
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new AuthorizationPage());
            Manager.mainFrame = mainFrame;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.GoBack();
        }

        private void mainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (mainFrame.CanGoBack)
            {
                txtCurrentUser.Text = "Пользователь: " + Manager.userName + " " + Manager.userSurname + "(" + Manager.userRole + ")";
                if (Manager.userRole.Equals("Администратор"))
                {
                    btnHistory.Visibility = Visibility.Visible;
                    btnUser.Visibility = Visibility.Visible;
                    imgUser.Visibility = Visibility.Visible;
                    imgUser.Source = new BitmapImage(new Uri($"pack://application:,,,/Resources/admin1.png"));
                }
                if (Manager.userRole.Equals("Кассир-менеджер"))
                {
                    btnOrder.Visibility = Visibility.Visible;
                    btnOrderHistory.Visibility = Visibility.Visible;
                    imgUser.Visibility = Visibility.Visible;
                    imgUser.Source = new BitmapImage(new Uri($"pack://application:,,,/Resources/cashier.png"));
                }
                btnBack.Visibility = Visibility.Visible;
                this.ResizeMode = ResizeMode.CanResize;
            }
            else
            {
                imgUser.Visibility = Visibility.Collapsed;
                this.ResizeMode = ResizeMode.NoResize;
                btnBack.Visibility = Visibility.Collapsed;
                txtCurrentUser.Text = "";
                btnOrder.Visibility = Visibility.Collapsed;
                btnUser.Visibility = Visibility.Collapsed;
                btnHistory.Visibility = Visibility.Collapsed;
                btnOrderHistory.Visibility = Visibility.Collapsed;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HistoryPage());
        }

        private void btnOrderHistory_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HistoryOrdersPage());
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new OrdersPage());
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new UsersPage());
        }
    }
}
