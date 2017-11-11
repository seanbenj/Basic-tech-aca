using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobsChal.Web
{
    public partial class OrderManagment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridSourceRefresh();
        }

        public void gridSourceRefresh()
        {
            GridView1.DataSource = Domain.OrderManager.GetOrders();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];
            var id = row.Cells[1].Text;
            var guid = Guid.Parse(id);
            Domain.OrderManager.CompleteOrder(guid);
            gridSourceRefresh();
            completedLabel.Visible = true;       
        }
    }
}