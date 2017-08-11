using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LS3Challenge2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double size1 = (babyButton.Checked) ? 10 : 0;

            double size2 = (papaButton.Checked) ? 13 : 0;
           
            double size3 = (mamaButton.Checked) ? 16 : 0;

            double crust = (deepButton.Checked) ? 2 : 0;
            
            double Pepperoni = (pepperoniCheckBox.Checked) ? 1.50 : 0;
            double Onions = (onionsCheckBox.Checked) ? .75 : 0;
            double greenPeppers = (greenPepCheckBox.Checked) ? .50 : 0;
            double redPeppers = (redPepCheckBox.Checked) ? .75 : 0;
            double Anchovies = (anchoviesCheckBox.Checked) ? 2 : 0;

            double discount = 
                (pepperoniCheckBox.Checked && greenPepCheckBox.Checked && anchoviesCheckBox.Checked ||
                pepperoniCheckBox.Checked && redPepCheckBox.Checked && onionsCheckBox.Checked) ? -2 : 0;
            double pizzaCalc = (size1 + size2 + size3 + crust + Pepperoni + Onions + greenPeppers + redPeppers + Anchovies + discount);
            purchaseLabel.Text = "total:$" + pizzaCalc + ".00";
        }
    }
}