using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSLS6Challenge1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                nameTextBox.Text = "";
                double[] elections = new double[0];
                ViewState.Add("Elections", elections);
                double[] subterfuge = new double[0];
                ViewState.Add("Subterfuge", subterfuge);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double[] elections = (double[])ViewState["Elections"];
            Array.Resize(ref elections, elections.Length + 1);
            int newINS = elections.GetUpperBound(0);
            elections[newINS] = double.Parse(electionTextBox.Text);
            ViewState["Elections"] = elections;

            Double[] subterfuge = (double[])ViewState["Subterfuge"];
            Array.Resize(ref subterfuge, subterfuge.Length + 1);
            int anNewINS = subterfuge.GetUpperBound(0);
            subterfuge[anNewINS] = double.Parse(subterfugeTextBox.Text);
            ViewState["Subterfuge"] = subterfuge;

            string name = nameTextBox.Text;

            resultLabel.Text = String.Format
                ("Total Elections Rigged: {0} <br />" +
                "Average Act of Subterfuge Per Asset: {1:N2} <br />" +
                "Last Asset Added: {2} <br />",
                elections.Sum(),
                subterfuge.Average(),
                name);




        }
    }
}