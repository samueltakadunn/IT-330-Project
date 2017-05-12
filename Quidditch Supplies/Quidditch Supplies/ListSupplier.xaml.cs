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
using System.Windows.Shapes;

namespace Quidditch_Supplies
{
    /// <summary>
    /// Interaction logic for ListSupplier.xaml
    /// </summary>
    public partial class ListSupplier : Window
    {
        public ListSupplier()
        {
            InitializeComponent();
        }

        private void btn_list_supplier_Click(object sender, RoutedEventArgs e)
        {
            QuidditchSuppliesDataSet dataset = new QuidditchSuppliesDataSet();
            // use a table adapter to populate the supplier table
            QuidditchSuppliesDataSetTableAdapters.SupplierTableAdapter adapter = new QuidditchSuppliesDataSetTableAdapters.SupplierTableAdapter();
            adapter.Fill(dataset.Supplier);
            // use the supplier table as the DataContext for this Window
            Supplier_Datagrid.ItemsSource = dataset.Supplier.DefaultView;
        }

        private void Supplier_Datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}