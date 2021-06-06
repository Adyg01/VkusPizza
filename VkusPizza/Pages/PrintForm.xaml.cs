using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace VkusPizza.Pages
{
    /// <summary>
    /// Логика взаимодействия для PrintForm.xaml
    /// </summary>
    public partial class PrintForm : Page
    {
        public PrintForm()
        {
            InitializeComponent();
            dGridHistoryOrders.ItemsSource = DBVkusPizaaEntities.getContext().HistoryOrders.ToList();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog printDialog = new System.Windows.Controls.PrintDialog();
            printDialog.PageRangeSelection = System.Windows.Controls.PageRangeSelection.AllPages;
            printDialog.UserPageRangeEnabled = true;
            Nullable<Boolean> print = printDialog.ShowDialog();

            if (print == true)
            {
                PrintCapabilities capabilities = printDialog.PrintQueue.GetPrintCapabilities(printDialog.PrintTicket);
                docHistoryOrdersPrint.PageWidth = printDialog.PrintableAreaWidth;
                docHistoryOrdersPrint.ColumnGap = 0;
                docHistoryOrdersPrint.ColumnWidth = printDialog.PrintableAreaWidth;
                IDocumentPaginatorSource idp = docHistoryOrdersPrint as IDocumentPaginatorSource; printDialog.PrintDocument(idp.DocumentPaginator, "Report");
            }
        }
    }
}
