using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace decimalToBinar
{
    public partial class DecimalToBinar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void convert(object sender, EventArgs e)
        {
            //int value = Int32.Parse(decimalNumber.Text);
            //string binary = Convert.ToString(value, 2);
            //binarNumber.Text = "Binarna vrijednost broja "+value+" je: "+binary;
            int i = 0;
            string[] brojevi = { "0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G"};
            int j = 0;
            int bs = 16; //brojevni sustav
            int dn = 0;
            try
            {
                dn = Int32.Parse(decimalNumber.Text);
                int temp_dn = dn;
                if (temp_dn != 0)
                {
                    while (temp_dn > 0)
                    {
                        temp_dn = temp_dn / bs;
                        j++;
                    }
                }
                else
                {
                    j = 1;
                }
                string[] tempList = new string[j]; //deklariranje liste
                while (dn > 0)
                {
                    i = dn % bs;
                    tempList[j - 1] = brojevi[i];
                    dn = dn - i;
                    dn = dn / bs;
                    j--;
                }
                binarNumber.Text = string.Join("", tempList);
            }
            catch
            {
                binarNumber.Text = "Unesena vrijednost nije iz dekatskog sustava brojeva!!!!!";
            }
        }
    }
}