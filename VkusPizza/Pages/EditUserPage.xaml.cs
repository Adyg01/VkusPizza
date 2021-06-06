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
    /// Логика взаимодействия для EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        private User currentUser = new User();
        public EditUserPage(User selctedUser)
        {
            InitializeComponent();
            comboBoxUserType.ItemsSource = DBVkusPizaaEntities.getContext().Role.ToList();
            if (selctedUser != null)
            {
                currentUser = selctedUser;
            }
            DataContext = currentUser;
        }

        private void btnUserSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentUser.FirstName))
                errors.AppendLine("Укажите имя пользователя");
            if (string.IsNullOrWhiteSpace(currentUser.Surname))
                errors.AppendLine("Укажите фамилию пользователя");
            if (string.IsNullOrWhiteSpace(currentUser.Login))
                errors.AppendLine("Укажите логин пользователя");
            if (string.IsNullOrWhiteSpace(currentUser.Password))
                errors.AppendLine("Укажите пароль пользователя");
            if (currentUser.Role == null)
                errors.AppendLine("Выберите роль пользователя");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (currentUser.Id == 0)
                DBVkusPizaaEntities.getContext().User.Add(currentUser);
            try
            {
                DBVkusPizaaEntities.getContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
