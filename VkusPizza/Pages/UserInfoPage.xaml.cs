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

namespace VkusPizza.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserInfoPage.xaml
    /// </summary>
    public partial class UserInfoPage : Page
    {
        public UserInfoPage()
        {
            InitializeComponent();
            txtBlockFirstName.Text += Manager.userName;
            txtBlockSurname.Text += Manager.userSurname;
            txtBlockRole.Text += Manager.userRole;
            if (Manager.userRole.Equals("Администратор"))
            {
                roleImage.Source = new BitmapImage(new Uri($"pack://application:,,,/Resources/admin1.png"));
            }
            else if (Manager.userRole.Equals("Кассир-менеджер"))
            {
                roleImage.Source = new BitmapImage(new Uri($"pack://application:,,,/Resources/cashier.png"));

            }
        }
    }
}
