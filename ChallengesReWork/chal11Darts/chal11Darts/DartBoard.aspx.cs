using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chal11Darts
{
    public partial class DartBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playDartsButton_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            player1.Name = Player1TextBox.Text;
            Player player2 = new Player();
            player2.Name = Player2TextBox.Text;
            Dart dart = new Dart();
            Game game = new Game();
            string result = game.PlayDarts(player1, player2, dart);
            result += game.DisplayWinner(player1, player2);
            resultLabel.Text = result;
        }
    }
}