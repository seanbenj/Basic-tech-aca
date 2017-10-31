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
        public int MostBattles (string[] Names, int[] Numbers)
        {
            int battleNumber = 0;
            int mostBattles = 0;
            int count = 0;
            for (int i = 0; i < Names.Length; i++)
            {
                if (Numbers[i] > battleNumber) mostBattles = i;
                else mostBattles = count;
                count = mostBattles;
                battleNumber = Numbers[mostBattles];
                
            }
            return mostBattles;
        }

        public int LeastBattles(string[] Names, int[] Numbers)
        {
            int battleNumber = 0;
            int leastBattles = 0;
            int count = 0;
            for (int i = 0; i < Names.Length; i++)
            {

                if (Numbers[i] < battleNumber) leastBattles = i;
                else leastBattles = count;
                count = leastBattles; 
                battleNumber = Numbers[leastBattles];

                
            }
            return leastBattles;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            result = string.Format("The winner of Xmen championships: {0} With the highest battles won totaling: {1}<br>"
            + "The loser in last place: {2} With a very low score of: {3}",
            names[MostBattles(names, numbers)],
            numbers[MostBattles(names, numbers)],
            names[LeastBattles(names, numbers)],
            numbers[LeastBattles(names, numbers)]);

            resultLabel.Text = result;
        }
    }
}