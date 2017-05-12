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
    /// Interaction logic for AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = txtServiceID.Text;
            strinput[1] = txtServiceName.Text;
            strinput[2] = txtServiceDescription.Text;
            strinput[3] = txtServiceCost.Text;
     

            nbrinput = 4;

            retval = appcomp.showData(strinput, nbrinput, "service");
        }
    }
}
