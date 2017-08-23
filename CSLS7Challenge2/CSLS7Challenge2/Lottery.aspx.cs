using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSLS7Challenge2
{
    public partial class Lottery : System.Web.UI.Page
    {
        // intialize startup images and player money onscreen
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Display the Reel Values
                string[] reels = new string[] { imageShift(), imageShift(), imageShift() };
                imagePop(reels);
                ViewState.Add("PlayersMoney", 100);
                displayPlayersMoney();
            }
        }

       

        //intitializing the Bet Calculations On Click
        protected void leverButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet)) return;

            int winnings = pullLever(bet);
            displayResult(bet, winnings);
            adjustPlayersMoney(bet, winnings);
            displayPlayersMoney();

        }
        //change player money to new value
        private void adjustPlayersMoney(int bet, int winnings)
        {
            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += winnings;
            ViewState["PlayersMoney"] = playersMoney;
        }

        private int pullLever(int bet)
        {
            // randomly select image to appear in each image.
            string[] reels = new string[] { imageShift(), imageShift(), imageShift() };
            imagePop(reels);

            int multiplier = checkWinLose(reels);
            return bet * multiplier;
        }
        // finding and returning bet multiplier.
        private int checkWinLose(string[] reels)
        {
            // if there is even one bar return 0
            if (isBar(reels)) return 0;
            // if there are 3 7's return 100
            if (isJackpot(reels)) return 100;
            // if there are 1,2,3 cherries, return 2,3,4
            int Multiplier = 0;
            if (isCherryWin(reels, out Multiplier)) return Multiplier;
            return 0;  
                
        }

        //see if cherry = >0
        private bool isCherryWin(string[] reels, out int multiplier)
        {
            multiplier = determineMultiplier(reels);
            if (multiplier > 0) return true;
            return false;
            
        }

        private int determineMultiplier(string[] reels)
        {
            int cherryCount = determineCherryCount(reels);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;
            return 0;
        }
        private int determineCherryCount(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry.png") cherryCount++;
            if (reels[1] == "Cherry.png") cherryCount++;
            if (reels[2] == "Cherry.png") cherryCount++;
            return cherryCount;
        }

        // see if there are bars
        private bool isBar(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
                return true;
            else
                return false;

        }
        // see if 3 7's exist
        private bool isJackpot(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            else
                return false;
        }

        
        
        // select image URL from reels array.
        private void imagePop(string[] reels)
        {
            ranImage1.ImageUrl = reels[0];
            ranImage2.ImageUrl = reels[1];
            ranImage3.ImageUrl = reels[2];
        }

        // init random string name.
        Random ranImg = new Random();

        private string imageShift()
        {
            string[] images = new string[] {"Strawberry.png", "Bar.png", "Lemon.png", "Bell.png", "Clover.png",
            "Cherry.png", "Diamond.png", "Orange.png", "Seven.png", "HorseShoe.png", "Plum.png"};
            return images[ranImg.Next(12)];
        }

        // Show player money onscreen.
        private void displayPlayersMoney()
        {
            moneyLabel.Text = string.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        }

        private void displayResult(int bet, int winnings)
        {
            if (winnings > 0)
            {
                resultLabel.Text = String.Format("You Bet {0:C} and won {1:C}!", bet, winnings);
            }
            else
            {
                resultLabel.Text = String.Format("You Lost {0:C} better luck next time.", bet);
            }
        }
        //THINGS NEEDED:
        // random images populations to each image.
        // init players starting money value as $100.
        // set winning/losing image combinations.
        // see if bet value = true(return), if false do nothing.
        // find out winning multiplier = true(return), if false no bet lost.
        // bet x image multipliers.
        // update players money (moneyLabel) along with return text indicating loss or won.
        // If players money = 0 then return game over and don't allow a bet while players money = 0.
    }
}