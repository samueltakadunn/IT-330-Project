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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[5];
            int nbrinput = 0;

            strinput[0] = txtEmpID.Text;
            strinput[1] = txtEmpFirName.Text;
            strinput[2] = txtEmpLastName.Text;
            strinput[3] = txtEmpPhone.Text;
            strinput[4] = txtEmpEmail.Text;


            nbrinput = 5;

            retval = appcomp.showData(strinput, nbrinput, "Employees");
        }
    }
}
