using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chal1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text1 = TextBox1.Text;
            string text2 = TextBox2.Text;

            string result = string.Format("At {0} years old I would have expected you to have more than {1} in your pocket",
            text1, text2);

            resultLabel.Text = result;

        }
    }
}