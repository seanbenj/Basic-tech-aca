using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WarChallenge
{
    public partial class GameForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // deck cards 52 total.
        // 2 players needed.
        // Split deck Randomly in half, distribute one half to each player. 
        // Score tally for each player = Total cards.
        // round = Pull one random card from each player, subtract from each player.
        // check if carPulled value of player1 is =, <, >, player2.
        // If cards are = value then intiate WAR!
        // WAR = pull 2 random cards and don't display in battle, but do display in loot; then
        // pull 2 more for battle and check if carPulled value of player1 is =, <, >, player2.
        // WAR Loot = Round(2 cards) + War(4 cards) + ifmuliwar(+ 4 more card for each)


        protected void playButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("player 1", "player 2");
            resultLabel.Text = game.Play();
        }
    }
}