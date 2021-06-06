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
using Xceed.Wpf.Toolkit;

namespace VkusPizza.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditOrdersPage.xaml
    /// </summary>
    public partial class EditOrdersPage : Page
    {
        private Order currentOrder = new Order();
        public EditOrdersPage(Order selectedOrder)
        {
            InitializeComponent(); 
            if (selectedOrder != null)
            {
                currentOrder = selectedOrder;
            }
            DataContext = currentOrder;
            comboBoxOrderPaymenth.ItemsSource = DBVkusPizaaEntities.getContext().PaymentMethod.ToList();
           
        }

        private void btnUserSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentOrder.CustomerName))
                errors.AppendLine("Укажите имя заказчика");
            if (string.IsNullOrWhiteSpace(currentOrder.CustomerPhone))
                errors.AppendLine("Укажите номер телефона заказчика");
            if (string.IsNullOrWhiteSpace(currentOrder.DeliveryStreet))
                errors.AppendLine("Укажите адрес(улицу) доставки");
            if (string.IsNullOrWhiteSpace(currentOrder.DeliveryHome))
                errors.AppendLine("Укажите адрес(дом) доставки");
            if (txtBoxOrderDateTime.Text == "")
                errors.AppendLine("Укажите дату и время заказа");
            if (comboBoxOrderPaymenth.SelectedItem == null)
                errors.AppendLine("Выберите вариант оплаты");
            if (string.IsNullOrWhiteSpace(txtBoxOrderProduct.Text))
                errors.AppendLine("Выберите продукты");
            if (errors.Length > 0)
            {
                System.Windows.MessageBox.Show(errors.ToString());
                return;
            }
            if (currentOrder.Id == 0)
            {
                if(Classes.Data.productsOrder != null)
                {
                    DBVkusPizaaEntities.getContext().Database.ExecuteSqlCommand("DELETE FROM ProductSale WHERE IdOrder = " + currentOrder.Id);
                    foreach (Product product in Classes.Data.productsOrder)
                    {
                        ProductSale productSale = new ProductSale();
                        productSale.IdProduct = product.Id;
                        productSale.IdOrder = currentOrder.Id;
                        currentOrder.ProductSale.Add(productSale);
                    }
                }
                currentOrder.IdStatus = 1;
                DBVkusPizaaEntities.getContext().Order.Add(currentOrder);

            }

            try
            {
                if (Classes.Data.productsOrder != null)
                {
                    DBVkusPizaaEntities.getContext().Database.ExecuteSqlCommand("DELETE FROM ProductSale WHERE IdOrder = " + currentOrder.Id);
                    foreach (Product product in Classes.Data.productsOrder)
                    {
                        ProductSale productSale = new ProductSale();
                        productSale.IdProduct = product.Id;
                        productSale.IdOrder = currentOrder.Id;
                        currentOrder.ProductSale.Add(productSale);
                    }
                }
                DBVkusPizaaEntities.getContext().SaveChanges();
                System.Windows.MessageBox.Show("Информация сохранена");
                Manager.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new SelectProductPage());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            txtBoxOrderProduct.Text = "";
            if (Classes.Data.productsOrder != null)
                foreach (Product product in Classes.Data.productsOrder)
                {
                    txtBoxOrderProduct.Text += product.Title + "; ";
                }
            else
            {
                foreach (ProductSale product in DBVkusPizaaEntities.getContext().ProductSale.Where(p=>p.IdOrder == currentOrder.Id))
                {
                    txtBoxOrderProduct.Text += product.Product.Title + "; ";
                }
            }
        }
    }
}
