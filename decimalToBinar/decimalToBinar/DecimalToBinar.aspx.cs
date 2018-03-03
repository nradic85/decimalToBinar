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
            int value = Int32.Parse(decimalNumber.Text);
            string binary = Convert.ToString(value, 2);
            binarNumber.Text = "Binarna vrijednost broja "+value+" je: "+binary;
        }
    }
}