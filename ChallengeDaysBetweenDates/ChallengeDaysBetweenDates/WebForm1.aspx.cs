using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = Calendar1.SelectedDate;
            Double date2 = Calendar2.SelectedDate.Subtract(date1).TotalDays;
            betweenLabel.Text = date2.ToString();   
        }
    }
}