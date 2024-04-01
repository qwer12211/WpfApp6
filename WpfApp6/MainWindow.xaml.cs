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
using WpfApp6.DataSet1TableAdapters;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrdersTableAdapter orders = new OrdersTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            OrdersDataGrid.ItemsSource = orders.Get();
        }

        private void Window_loaded(object sender, RoutedEventArgs e)
        {
            OrdersDataGrid.Columns[0].Visibility = Visibility.Collapsed;
            OrdersDataGrid.Columns[1].Visibility = Visibility.Collapsed;
            OrdersDataGrid.Columns[2].Visibility = Visibility.Collapsed;
            OrdersDataGrid.Columns[3].Visibility = Visibility.Collapsed;
            OrdersDataGrid.Columns[9].Visibility = Visibility.Collapsed;
        }


    }
}
