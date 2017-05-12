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
    /// Interaction logic for ListService.xaml
    /// </summary>
    public partial class ListService : Window
    {
        public ListService()
        {
            InitializeComponent();
        }

        private void Datagrid_Loaded(object sender, RoutedEventArgs e)
        {
            QuidditchSuppliesDataSet dataset = new QuidditchSuppliesDataSet();
            //use a table adapter to populate the supplier table
            QuidditchSuppliesDataSetTableAdapters.ServiceTableAdapter adapter = new QuidditchSuppliesDataSetTableAdapters.ServiceTableAdapter();
            adapter.Fill(dataset.Service);
            // use the supplier table as the DataContext for this Window
            Datagrid.ItemsSource = dataset.Service.DefaultView;
        }
    }
}
