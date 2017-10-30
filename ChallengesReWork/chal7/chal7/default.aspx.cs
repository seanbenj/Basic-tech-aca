using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chal7
{
    public partial class _default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] acts = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Acts", acts);
            }
            
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] acts = (int[])ViewState["Acts"];

            Array.Resize(ref assets, assets.Length + 1);
            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref acts, acts.Length + 1);

            int newAssetsIndex = assets.GetUpperBound(0);
            int newElectionsIndex = elections.GetUpperBound(0);
            int newActsIndex = acts.GetUpperBound(0);

            assets[newAssetsIndex] = nameTextBox.Text;
            elections[newElectionsIndex] = int.Parse(electionsTextBox.Text);
            acts[newActsIndex] = int.Parse(subterfugeTextBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            string result = String.Format("Total Elections Rigged: {0}<br>" +
            "Average Acts Of Subterfuge Per Spy: {1}<br>" +
            "(Last Asset added: {2})",
            elections.Sum(), acts.Average(), assets[newAssetsIndex]);

            resultLabel.Text = result;
        }
    }
}