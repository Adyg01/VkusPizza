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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
            txtPassword.Visibility = Visibility.Collapsed;
        }
        
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (autorize(txtLogin.Text, passboxPassword.Password))
            {
                MessageBox.Show("Вы успешно авторизованы", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                if (Manager.userRole.Equals("Администратор"))
                    Manager.mainFrame.Navigate(new UserInfoPage());
                if (Manager.userRole.Equals("Кассир-менеджер"))
                    Manager.mainFrame.Navigate(new UserInfoPage());
            }
        }
        private bool autorize(string login, string password)
        {
            int errors = 0;
            int userId = 0;
            try
            {
                foreach (var user in DBVkusPizaaEntities.getContext().User.ToList())
                {
                    if (login == user.Login && password == user.Password)
                    {
                        Manager.userName = user.FirstName;
                        Manager.userSurname = user.Surname;
                        Manager.userRole = user.Role.Name;
                        errors = 0;
                        userId = user.Id;
                        Manager.userId = userId;
                        break;
                    }
                    if (login == user.Login)
                    {
                        userId = user.Id;
                    }
                    else
                        errors++;
                }
                if (errors == 0)
                {
                    addEntryHistory(userId, true);
                    return true;
                }
                else
                {
                    if (userId!=0)
                    {
                        addEntryHistory(userId, false);
                    }
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return false;
        }
        private void addEntryHistory(int id, bool access)
        {
            try
            {
                    HistoryEnter historyEnter = new HistoryEnter();
                    historyEnter.LoginId = id;
                    historyEnter.EnterDateTime = DateTime.Now;
                    historyEnter.Status = access;
                    DBVkusPizaaEntities.getContext().HistoryEnter.Add(historyEnter);
                    DBVkusPizaaEntities.getContext().SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }

        private void chekboxShowPass_Checked(object sender, RoutedEventArgs e)
        {
            passboxPassword.Visibility = Visibility.Hidden;
            txtPassword.Visibility = Visibility.Visible;
            txtPassword.Text = passboxPassword.Password;
        }

        private void chekboxShowPass_Unchecked(object sender, RoutedEventArgs e)
        {
            passboxPassword.Visibility = Visibility.Visible;
            txtPassword.Visibility = Visibility.Hidden;
            passboxPassword.Password = txtPassword.Text;
        }
    }
}
