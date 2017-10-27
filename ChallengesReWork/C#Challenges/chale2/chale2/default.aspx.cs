using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chale2
{
    public partial class _default : System.Web.UI.Page
    {
        public double num1;
        public double num2;
        public double Plus(double number1, double number2)
        {         
            double total = number1 + number2;
            return total;          
        }

        public double Minus(double numone, double numtwo)
        {
            double total = numone - numtwo;
            return total;
        }

        public double Divide(double numb1, double numb2)
        {
            double total = numb1 / numb2;
            return total; 
        }

        public double Multiply(double numbone, double numbtwo)
        {
            double total = numbone * numbtwo;
            return total;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void PlusButton_Click(object sender, EventArgs e)
        {
            if (Num1TextBox.Text.Length == 0 || Num2TextBox.Text.Length == 0) return;
            num1 = double.Parse(Num1TextBox.Text);
            num2 = double.Parse(Num2TextBox.Text);
            resultLabel.Text = string.Format("{0} + {1} = {2}", num1, num2, Plus(num1, num2));
        }

        protected void MinusButton_Click(object sender, EventArgs e)
        {
            if (Num1TextBox.Text.Length == 0 || Num2TextBox.Text.Length == 0) return;
            num1 = double.Parse(Num1TextBox.Text);
            num2 = double.Parse(Num2TextBox.Text);
            resultLabel.Text = string.Format("{0} - {1} = {2}", num1, num2, Minus(num1, num2));
        }

        protected void MultiButton_Click(object sender, EventArgs e)
        {
            if (Num1TextBox.Text.Length == 0 || Num2TextBox.Text.Length == 0) return;
            num1 = double.Parse(Num1TextBox.Text);
            num2 = double.Parse(Num2TextBox.Text);
            resultLabel.Text = string.Format("{0} * {1} = {2}", num1, num2, Multiply(num1, num2));
        }

        protected void DivideButton_Click(object sender, EventArgs e)
        {
            if (Num1TextBox.Text.Length == 0 || Num2TextBox.Text.Length == 0) return;
            num1 = double.Parse(Num1TextBox.Text);
            num2 = double.Parse(Num2TextBox.Text);
            resultLabel.Text = string.Format("{0} / {1} = {2}", num1, num2, Divide(num1, num2));
        }
    }
}