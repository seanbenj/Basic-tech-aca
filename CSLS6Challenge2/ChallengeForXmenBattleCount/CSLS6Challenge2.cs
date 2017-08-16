using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Bob Tabor", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            int largestNumber = 0;
            int smallestNumber = 0;

            string result = "";


            // Your Code Here!
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[largestNumber])
                {
                    largestNumber = i;
                }
                if (numbers[i] < numbers[smallestNumber])
                {
                    smallestNumber = i;
                }

            }

            result = string.Format("Most Battles Belong To: {0} (Value: {1})" +
            "Least Battles Belong To: {2} (Value: {3}) HAHAHA, you lose Bob Tabor!",
            names[largestNumber],
            numbers[largestNumber],
            names[smallestNumber],
            numbers[smallestNumber]);

            resultLabel.Text = result;
        }
    }
}