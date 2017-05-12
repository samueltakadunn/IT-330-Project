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
using System.Configuration;
using System.IO;

namespace Quidditch_Supplies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddService addService = new AddService();
            addService.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            AddRent addRent = new AddRent();
            addRent.Show();
        }

        private void btn_test_file_Click(object sender, RoutedEventArgs e)
        {
            string filename = System.Configuration.ConfigurationManager.AppSettings["datafile"];
            string line = "";

            StreamReader sr = new StreamReader(filename);
            while ((line = sr.ReadLine()) != null)
            {
                MessageBox.Show(line);
            }
            sr.Close();


            
        }

        private void btn_supplierlist_Click(object sender, RoutedEventArgs e)
        {
            ListSupplier lstsupp = new ListSupplier();
            lstsupp.Show();
        }

        private void btn_List_Service_Click(object sender, RoutedEventArgs e)
        {
            ListService lstserv = new ListService();
            lstserv.Show();
        }
    }
}
