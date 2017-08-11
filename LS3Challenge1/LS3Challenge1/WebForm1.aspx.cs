using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LS3Challenge1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilButton.Checked)
            {
                resultLabel.Text = "You are so old school, join the digital age!";
                selectImage.ImageUrl = "./assets/pencil.png";
            }
            else if (penButton.Checked)
            {
                resultLabel.Text = "You won't be able to erase any mistakes!";
                selectImage.ImageUrl = "./assets/pen.png";
            }
            else if (phoneButton.Checked)
            {
                resultLabel.Text = "You're one of those car texters aren't you?!";
                selectImage.ImageUrl = "./assets/phone.png";
            }
            else if (tabletButton.Checked)
            {
                resultLabel.Text = "You're totally digital!";
                selectImage.ImageUrl = "./assets/tablet.png";
            }
            else
            {
                resultLabel.Text = "Make a selection I don't have all day!!";
            }
        }
    }
}