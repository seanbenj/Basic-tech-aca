using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LS2Challenge
{
    public partial class simpleCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
          double Number1 = double.Parse(num1TextBox.Text);
          double Number2 = double.Parse(num2TextBox.Text);

            Double calcResults = (double)Number1 + (double)Number2;

            Total.Text = calcResults.ToString();
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            double Number1 = double.Parse(num1TextBox.Text);
            double Number2 = double.Parse(num2TextBox.Text);

            Double calcResults = (double)Number1 - (double)Number2;

            Total.Text = calcResults.ToString();
        }

        protected void multiButton_Click(object sender, EventArgs e)
        {
            double Number1 = double.Parse(num1TextBox.Text);
            double Number2 = double.Parse(num2TextBox.Text);

            Double calcResults = (double)Number1 * (double)Number2;

            Total.Text = calcResults.ToString();
        }

        protected void diviButton_Click(object sender, EventArgs e)
        {
            double Number1 = double.Parse(num1TextBox.Text);
            double Number2 = double.Parse(num2TextBox.Text);

            Double calcResults = (double)Number1 / (double)Number2;

            Total.Text = calcResults.ToString();
        }
    }
}