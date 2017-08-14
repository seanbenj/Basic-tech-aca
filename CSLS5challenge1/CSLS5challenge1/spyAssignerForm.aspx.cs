using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSLS5challenge1
{
    public partial class spyAssignerForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var prevAssign = endPrevCalendar.SelectedDate;
            var starAssign = starNewCalendar.SelectedDate;
            var endAssign = endNewCalendar.SelectedDate;
            string spyName = nameTextBox.Text;
            string spyLocation = locationTextBox.Text; 
            string error = "Error must allow at least two weeks between previous assignment and new assignment.";
            TimeSpan totalDaysAssigned = endAssign.Subtract(starAssign);
            double totalAssignment = totalDaysAssigned.TotalDays;
            double payAmount = totalAssignment * 500;
            double Bonus = (payAmount + 1000);

            if (starAssign < prevAssign.AddDays(14))
            {
                assignDetail.Text = error;
            }

            else if (totalAssignment < 21)
            {
                assignDetail.Text = String.Format("Assignment of: {0}" +
                    " to assignment Project: {1}" +
                    " is authorized. Budget total: {2:C}",
                    spyName,
                    spyLocation,
                    payAmount);
            }
            else if (totalAssignment >= 21)
            {
                assignDetail.Text = String.Format("Assignment of: {0}" +
                    " to assignment Project: {1}" +
                    " is authorized. Budget total: {2:C}",
                    spyName,
                    spyLocation,
                    Bonus);                    
            }
        }
    }
}