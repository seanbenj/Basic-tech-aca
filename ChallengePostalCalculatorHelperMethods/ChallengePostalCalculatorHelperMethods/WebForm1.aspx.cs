using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // see if the values are there.
        private bool valuesExist()
        {
            if (!airRadioButton.Checked
                && !groundRadioButton.Checked
                && !nextDayRadioButton.Checked)
                return false;
            if (widthTextBox.Text.Trim().Length == 0
                || heightTextBox.Text.Trim().Length == 0)
                return false;

            return true;
        }

        // get and calculate volume.
        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(LengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;
        }

        // get shipping type multiplier.
        private double getPostageMultiplier()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextDayRadioButton.Checked) return .45;
            else return 0;
        }

        // calculate total shipping and return to display.
        private void performChanged()
        {
            if (!valuesExist()) return;
            int volume = 0;
            if (!tryGetVolume(out volume)) return;
            double postageMultiplier = getPostageMultiplier();
            double cost = volume * postageMultiplier;
            totalShippingLabel.Text = String.Format("Your parcel will cost {0:C} to ship", cost);
        }

        protected void handleChange(object sender, EventArgs e)
        {
            performChanged();
        }
       
    
    }
}