﻿using System;
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
    /// Interaction logic for AddRent.xaml
    /// </summary>
    public partial class AddRent : Window
    {
        public AddRent()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[5];
            int nbrinput = 0;

            strinput[0] = txtRentCustID.Text;
            strinput[1] = txtRentItemID.Text;
            strinput[2] = txtRentDayStrt.Text;
            strinput[3] = txtRentDayEnd.Text;
            strinput[4] = txtRentPrice.Text;

            nbrinput = 5;

            retval = appcomp.showData(strinput, nbrinput, "rent");
        }
    }
}
