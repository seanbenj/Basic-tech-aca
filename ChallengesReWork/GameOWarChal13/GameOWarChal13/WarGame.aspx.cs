using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameOWarChal13
{
    public partial class WarGame : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            string result = "";
            Deck deck_ = new Deck();
            Game game = new Game();
            Player player1 = new Player() { Name = player1TextBox.Text };
            Player player2 = new Player() { Name = player2TextBox.Text };
            result += game.GameOWar(deck_, player1, player2);
            resultLabel.Text = result;
        }
    }
}