using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PappaBobs.DTO.Enums;

namespace PappaBobs.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            isTextBoxEmpty(nameTextBox, "Please enter a name.");
            isTextBoxEmpty(addressTextBox, "Please enter an address.");
            isTextBoxEmpty(zipCodeTextBox, "Please enter a zipcode.");
            isTextBoxEmpty(phoneTextBox, "Please enter a Phone Number.");
            if (validationLabel.Visible == true) return;

            try
            {
                var order = buildOrder();
                Domain.OrderManager.CreateOrder(order);
                Response.Redirect("Success.aspx");
            }
            catch (Exception ex)
            {
                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
            }

        }

        private void isTextBoxEmpty(TextBox textbox, string s)
        {
            if (textbox.Text.Trim().Length == 0)
            {
                validationLabel.Text = s;
                validationLabel.Visible = true;
                
            }
            return;
        }

        private PaymentType determinePaymentType()
        {
            DTO.Enums.PaymentType paymentType;

            if (cashRadioButton.Checked)
            {
                paymentType = DTO.Enums.PaymentType.Cash;
            }
            else
            {
                paymentType = DTO.Enums.PaymentType.Credit;
            }
            return paymentType;
        }

        private DTO.Enums.SizeType determineSize()
        {
            DTO.Enums.SizeType size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Could not determine the pizza size!");
            }
            return size; 
        }

        private DTO.Enums.CrustType determineCrust()
        {
            DTO.Enums.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Could not determine the pizza crust!");
            }
            return crust;
        }

        protected void recalculateTotalCost(object sender, EventArgs e)
        {
            if (sizeDropDownList.SelectedValue == String.Empty) return;
            if (crustDropDownList.SelectedValue == String.Empty) return;

            var order = buildOrder();
            try
            {
                totalLabel.Text = Domain.PizzaPriceManager.CalculatePizzaCost(order).ToString("C");
            }
            catch 
            {

            }
            
        }

        private DTO.OrderDTO buildOrder()
        {
            var order = new DTO.OrderDTO();
            order.Size = determineSize();
            order.Crust = determineCrust();
            order.PaymentType = determinePaymentType();
            order.GreenPeppers = greenpeppersCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Sausage = sausageCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.ZipCode = zipCodeTextBox.Text;
            order.Phone = phoneTextBox.Text;
            order.PaymentType = determinePaymentType();

            return order;
        }
    }
}