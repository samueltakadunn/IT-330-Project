using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Quidditch_Supplies
{
    class AppCompute
    {
        public int showData(string[] strargs, int intargs, string datatype)
        {
            string msgtxt = " ";
            for (int i = 0; i <= strargs.GetUpperBound(0); i++)
                { msgtxt = msgtxt + " " + strargs[i].ToString() + "\n"; };

                MessageBox.Show(msgtxt);


            

            if (datatype == "service")
            {
                string servfile = System.Configuration.ConfigurationManager.AppSettings["servicefile"];
                StreamWriter sr = new StreamWriter(servfile, true);
                sr.WriteLine(msgtxt);
                sr.Close();
            }
            else
            {
                string supfile = System.Configuration.ConfigurationManager.AppSettings["supplierfile"];
                StreamWriter sr = new StreamWriter(supfile, true);
                sr.WriteLine(msgtxt);
                sr.Close();

            }
            

            return 0;


        }



    }
}
