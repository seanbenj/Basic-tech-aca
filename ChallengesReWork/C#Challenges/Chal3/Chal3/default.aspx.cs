using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chal3
{
    public partial class _default : System.Web.UI.Page
    {

        public string SelectedNoteTaker(string noteOption)
        {
            string notechoice = String.Format("You have selected a {0}", noteOption);
            return notechoice;
        }

        public string imgChoice()
        {
            string noteTakerImage = "";
            if (PenRadioButton.Checked == true) noteTakerImage = "pen.png";
            else if (PencilRadioButton.Checked == true) noteTakerImage = "pencil.png";
            else if (PhoneRadioButton.Checked == true) noteTakerImage = "phone.png";
            else if (TabletRadioButton.Checked == true) noteTakerImage = "tablet.png";
            else noteTakerImage = "";
            return noteTakerImage;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            string pen = SelectedNoteTaker("Pen");
            string pencil = SelectedNoteTaker("Pencil");
            string phone = SelectedNoteTaker("Phone");
            string tablet = SelectedNoteTaker("tablet");
            if (PenRadioButton.Checked == true) resultLabel.Text = pen;
            else if (PencilRadioButton.Checked == true) resultLabel.Text = pencil;
            else if (PhoneRadioButton.Checked == true) resultLabel.Text = phone;
            else if (TabletRadioButton.Checked == true) resultLabel.Text = tablet;
            else resultLabel.Text = "Please selected your desired note taking method";
            NoteTakerImage.ImageUrl = imgChoice();
        }
    }
}