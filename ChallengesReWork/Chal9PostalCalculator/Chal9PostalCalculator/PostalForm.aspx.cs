using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chal9PostalCalculator
{
    public partial class PostalForm : System.Web.UI.Page
    {
        private int width;
        private int height;
        private int length;
        private int volume;

        public bool IsPackInputEmpty(out int volume)
        {
            volume = 0;
            if (!int.TryParse(WidthTextBox.Text, out width)) return false;
            if (!int.TryParse(HeightTextBox.Text, out height)) return false;
            if (!int.TryParse(LengthTextBox.Text, out length)) length = 1;
            volume = width * height * length;
            return true;
        }

        public double ShippingMultiplier(int volume)
        {
            double shippingtotal;
            double multiplier = 0;
            if (GroundRadioButton.Checked) multiplier = .15;
            if (AirRadioButton.Checked) multiplier = .25;
            else if (NextDayRadioButton.Checked) multiplier = .45;
            shippingtotal = volume * multiplier;
            return shippingtotal; 
        }

        public void DisplayPackageCost (double packageTotal)
        {
            string result = "";
            result = string.Format("The total cost for your package is: {0:C}", packageTotal);
            resultLabel.Text = result;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string error = "Please pick minimally your package height and width";
            if (!IsPackInputEmpty(out volume)) resultLabel.Text = error;
            else DisplayPackageCost(ShippingMultiplier(volume));
        }
    }
}