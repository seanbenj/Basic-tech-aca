using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chal4
{
    public partial class _default : System.Web.UI.Page
    {
        public double getSizePrice()
        {
            double sizePrice = 0;
            if (SizeBabyRadioButton.Checked == true) sizePrice = 10;
            if (SizeMamaRadioButton.Checked == true) sizePrice = 13;
            if (SizePapaRadioButton.Checked == true) sizePrice = 16;
            return sizePrice;
        }

        public double getCrustPrice()
        {
            double crustPrice = 0;
            if (CrustThinRadioButton.Checked == true) crustPrice = 0;
            else if (CrustDeepRadioButton.Checked == true) crustPrice = 2;
            return crustPrice;
        }

        public double getToppingsPrice()
        {
            double toppingsPrice = 0;
            if (PepperoniCheckBox.Checked == true) toppingsPrice += 1.50;
            if (OnionsCheckBox.Checked == true) toppingsPrice += 0.75;
            if (GreenPeppersCheckBox.Checked == true) toppingsPrice += 0.50;
            if (RedPeppersCheckBox.Checked == true) toppingsPrice += 0.75;
            if (AnchoviesCheckBox.Checked == true) toppingsPrice += 2;
            return toppingsPrice;
        }

        public double isSpecialDeal()
        {
            double special = 0;
            if (PepperoniCheckBox.Checked == true &&
                GreenPeppersCheckBox.Checked == true &&
                AnchoviesCheckBox.Checked == true ||
                RedPeppersCheckBox.Checked == true &&
                PepperoniCheckBox.Checked == true &&
                OnionsCheckBox.Checked == true)
                special = -2;
            return special;
        }

        public double calcTotal()
        {
           double total = getSizePrice() + getToppingsPrice() + isSpecialDeal();
            return total;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            string total = string.Format("Your pizzas total cost: ${0}", calcTotal());
            resultLabel.Text = total;
        }
    }
}