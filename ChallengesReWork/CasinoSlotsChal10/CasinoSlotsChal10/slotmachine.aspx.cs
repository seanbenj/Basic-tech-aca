using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasinoSlotsChal10
{
    public partial class slotmachine : System.Web.UI.Page
    {
        // set images in array for tranversing through
        // set up random image to generate in each img control
        // set up a method for cherry winners
        // set up a method for jackpot
        // set up a method for bar
        // set up a player money method involving viewstate (adjusting on win/lose) and intializing at $100
        // set up a display method to the resultlabel
        Random random = new Random();
        private string spinReel()
        {
            string[] slotImages = new string[]
        { "Bar.png", "Bell.png", "Cherry.png", "Clover.png", "Diamond.png", "Horseshoe.png",
         "Plum.png", "Lemon.png", "Orange.png", "Seven.png", "Strawberry.png", "Watermelon.png"};
         return slotImages[random.Next(11)];
        }

        private void spinReels()
        {
            //Slot1Image.ImageUrl = spinReel();
            //Slot2Image.ImageUrl = spinReel();
            //Slot3Image.ImageUrl = spinReel();
            Slot1Image.ImageUrl = "Bar.png";
            Slot2Image.ImageUrl = "Cherry.png";
            Slot3Image.ImageUrl = "Cherry.png";
        }

        private bool isJackpot()
        {
            if (Slot1Image.ImageUrl == "Seven.png" &&
                Slot2Image.ImageUrl == "Seven.png" &&
                Slot3Image.ImageUrl == "Seven.png") return true;
            else return false;
        }

        private bool isBar()
        {
            if (Slot1Image.ImageUrl == "Bar.png" ||
                Slot2Image.ImageUrl == "Bar.png" ||
                Slot3Image.ImageUrl == "Bar.png") return true;
            else return false;
        }

        private bool isOneCherry()
        {
            if (Slot1Image.ImageUrl == "Cherry.png" ||
            Slot2Image.ImageUrl == "Cherry.png" ||
            Slot3Image.ImageUrl == "Cherry.png") return true;
            else return false;
        }

        private bool isTwoCherries()
        {
            if (Slot1Image.ImageUrl == "Cherry.png" &&
            Slot2Image.ImageUrl == "Cherry.png"
            ||
            Slot3Image.ImageUrl == "Cherry.png" &&
            Slot2Image.ImageUrl == "Cherry.png") return true;
            else return false;
        }
        private bool isThreeCherries()
        {
            if (Slot1Image.ImageUrl == "Cherry.png" &&
            Slot2Image.ImageUrl == "Cherry.png" &&
            Slot3Image.ImageUrl == "Cherry.png") return true;
            else return false;
        }
        private int getCherries()
        {
            int cherry;
            if (isThreeCherries()) cherry = 4;
            else if (isTwoCherries()) cherry = 3;
            else if (isOneCherry()) cherry = 2;
            else cherry = 0;
            return cherry;
        }

        private int Multiplier;

        private bool isWinner(out int multiplier)
        {
            multiplier = Multiplier;
            if (getCherries() > 0 && !isBar()) multiplier = getCherries();
            else if (isJackpot() && !isBar()) multiplier = 100;
            else multiplier = 0;
            if (getCherries() > 0 && !isBar() || isJackpot() && !isBar()) return true;
            else return false; 
        }

        private int adjustPlayerMoney(int playMoney, int bet, int winnings)
        {
            playMoney = (int)ViewState["PlayerMoney"];
            playMoney -= bet;
            playMoney += winnings;
            return playMoney;
        }

        private int playMoney;
        private void playSlots(int bet)
        {   
            int winnings = getWinnings(bet);
            string winner = string.Format("Great job you bet {0} and won {1:C}", bet, winnings);
            string loser = string.Format("Better luck next time, you lost {0:C}", bet);
            if (isWinner(out Multiplier)) resultLabel.Text = winner;
            else resultLabel.Text = loser;
            ViewState["PlayerMoney"] = adjustPlayerMoney(playMoney, bet, winnings);
            PlayerMoneyLabel.Text = string.Format("Players money: {0}", ViewState["PlayerMoney"].ToString());

        }
        private int getWinnings(int bet)
        {
            spinReels();
            int winnings;
            isWinner(out Multiplier);
            winnings = Multiplier * bet;
            return winnings;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                spinReels();
                int playerMoney = 100;
                PlayerMoneyLabel.Text = String.Format("Players money: {0}", playerMoney);
                ViewState.Add("PlayerMoney", playerMoney);
            }


        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            int bet;
            string error = "Please place a valid bet in dollars.";
            if(!int.TryParse(BetTextBox.Text, out bet)) resultLabel.Text = error;
            else playSlots(bet);         
        }
    }
}