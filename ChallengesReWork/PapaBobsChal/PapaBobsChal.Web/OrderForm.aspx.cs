using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PapaBobsChal.DTO.Enums;

namespace PapaBobsChal.Web
{
    public partial class OrderForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var order = BuildOrder();
                if (Domain.OrderManager.textEmptyError(order).Trim().Length > 0)
                {
                    errorLabel.Text = Domain.OrderManager.textEmptyError(order);
                    errorLabel.Visible = true;
                    return;
                } 
                else
                    Domain.OrderManager.CreateOrder(order);
                    Response.Redirect("Success.aspx");
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.Visible = true;
            }
        }

        public DTO.OrderDTO BuildOrder()
        {
            var orderDTO = new DTO.OrderDTO();
            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.Size = determineSize();
            orderDTO.Crust = determineCrust();
            orderDTO.Pepperoni = pepperoniCheckBox.Checked;
            orderDTO.GreenPeppers = greenPeppersCheckBox.Checked;
            orderDTO.Onions = onionsCheckBox.Checked;
            orderDTO.Sausage = sausageCheckBox.Checked;
            orderDTO.Name = nameTextBox.Text;
            orderDTO.Address = addressTextBox.Text;
            orderDTO.Zip = zipTextBox.Text;
            orderDTO.Phone = phoneTextBox.Text;
            orderDTO.TotalCost = Domain.PizzaPriceManager.CalculatePizzaPrice(orderDTO);
            orderDTO.Completed = false;
            return orderDTO;
        }

        protected void recalculateTotalCost(object sender, EventArgs e)
        {
            if (crustDropDownList.SelectedValue.Trim().Length == 0) return;
            if (sizeDropDownList.SelectedValue.Trim().Length == 0) return;

            var order = orderPricingItems();
            string result = Domain.PizzaPriceManager.CalculatePizzaPrice(order).ToString();
            totalLabel.Text = result;
        }

        private CrustTypes determineCrust()
        {
            DTO.Enums.CrustTypes crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Could not determine the crust selected.");
            }
            else
                return crust;
        }

        private SizeTypes determineSize()
        {
            DTO.Enums.SizeTypes size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Could not determine the size selected.");
            }
            else
                return size;
        }

        private DTO.OrderDTO orderPricingItems()
        {
            var orderDTO = new DTO.OrderDTO();
            orderDTO.Size = determineSize();
            orderDTO.Crust = determineCrust();
            orderDTO.Pepperoni = pepperoniCheckBox.Checked;
            orderDTO.GreenPeppers = greenPeppersCheckBox.Checked;
            orderDTO.Onions = onionsCheckBox.Checked;
            orderDTO.Sausage = sausageCheckBox.Checked;
            return orderDTO;
        }
    }
}