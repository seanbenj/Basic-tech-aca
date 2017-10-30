using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chal6
{
    public partial class Default : System.Web.UI.Page
    {

        public double NewAssignment ()
        {
            DateTime endDate = endNewCalendar.SelectedDate;
            DateTime startDate = startNewCalendar.SelectedDate;
            TimeSpan assignmentCost = endDate.Subtract(startDate);
            double assignCost = assignmentCost.TotalDays;
            return assignCost;
        }

        public string AssignmentError(DateTime dateOne, DateTime dateTwo)
        {
            startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
            string Error = "!Error! You Must select atleast 14 days between each assignment," +
            "these spies need a break!";
            if (dateOne.Subtract(dateTwo).TotalDays < 14) return Error;
            else return "";

        }

        public double NewAssignmentCost(double newAssignment)
        {
            int bonus = 1000;
            double daysOfAssignment = newAssignment;
            double Totalcost = daysOfAssignment * 500;
            if (daysOfAssignment > 21) Totalcost += bonus;
            return Totalcost;
        }

        public string DisplayAssignmentDetails(double newAssignmentCost)
        {
            string assignment = assignmentTextBox.Text;
            string name = nameTextBox.Text;
            string displayDetails = 
            string.Format("Assignment of {0} to Project: {1} is authorized. Budget total: {2:C}",
            name, assignment, newAssignmentCost);
            return displayDetails;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (!Page.IsPostBack)
            {
                endPrevCalendar.SelectedDate = DateTime.Now.Date;
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                startNewCalendar.VisibleDate = DateTime.Now.Date.AddDays(14);
                endNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
                endNewCalendar.VisibleDate = DateTime.Now.Date.AddDays(21);
            }
         
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            DateTime date2 = endPrevCalendar.SelectedDate;
            DateTime date1 = startNewCalendar.SelectedDate;
            string spyAssignment = DisplayAssignmentDetails(NewAssignmentCost(NewAssignment()));
            if (AssignmentError(date1, date2) == "") resultLabel.Text = spyAssignment;
            else resultLabel.Text = (AssignmentError(date1, date2));
        }

    }
}