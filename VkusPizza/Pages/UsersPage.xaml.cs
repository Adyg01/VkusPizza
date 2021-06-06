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
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            comboFilter.Items.Add("Все");
            comboFilter.Items.Add("Администратор");
            comboFilter.Items.Add("Кассир");
            comboFilter.SelectedIndex = 0;
            Update();
        }

        private void btnRePassUser_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new EditUserPage((sender as Button).DataContext as User));
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new EditUserPage(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                DBVkusPizaaEntities.getContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dGridUser.ItemsSource = DBVkusPizaaEntities.getContext().User.ToList();
                Update();
            }
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            var userForRemoving = dGridUser.SelectedItems.Cast<User>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {userForRemoving.Count()} элементов?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    DBVkusPizaaEntities.getContext().User.RemoveRange(userForRemoving);
                    DBVkusPizaaEntities.getContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    dGridUser.ItemsSource = DBVkusPizaaEntities.getContext().User.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void Update()
        {
            List<User> currentUser = DBVkusPizaaEntities.getContext().User.ToList();
            currentUser = currentUser.Where(p => p.FirstName.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.Surname.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.Login.ToLower().Contains(txtBoxSearch.Text.ToLower()) || p.Role.Name.ToLower().Contains(txtBoxSearch.Text.ToLower())).ToList();


            if (comboFilter.SelectedIndex == 0)
                dGridUser.ItemsSource = currentUser.OrderBy(p => p.Id).ToList();
            if (comboFilter.SelectedIndex == 1)
                dGridUser.ItemsSource = currentUser.OrderBy(p => p.Role.Name == "Кассир-менеджер");
            if (comboFilter.SelectedIndex == 2)
                dGridUser.ItemsSource = currentUser.OrderBy(p => p.Role.Name == "Администратор");

            if (dGridUser.Items.Count == 0)
            {
                labelSearchBad.Visibility = Visibility.Visible;
                dGridUser.Visibility = Visibility.Collapsed;
            }
            else
            {
                dGridUser.Visibility = Visibility.Visible;
                labelSearchBad.Visibility = Visibility.Collapsed;
            }

        }

        private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void comboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}
