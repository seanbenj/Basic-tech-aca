using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        
        //declaring some string variables for method use.
        private string name = "Sean McCrea";
        private string starName = "";
        private string names = "Luke,Leia,Han,Chewbacca";
        private string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

        private string puzzleSorter(string PZL)
        {
            string sorted = PZL.Replace("Z", "T").Remove(10, 9).ToLower().Remove(0, 1).Insert(0, "N");
            return sorted;
        }

        //reversing the order of my awesome name.
        public static string ReverseString(string n)
        {
            char[] Sean = n.ToCharArray();
            Array.Reverse(Sean);
            return new string(Sean);
        }

        //Reversing the order of where words are placed.
        private string ReverseWordOrder(string SN, string NM)
        {
            string[] star = NM.Split(',');
            for (int i = star.Length - 1; i >= 0; i--)
            {
                SN += star[i] + ",";
            }
            return SN;
        }

        //Adding Char Symbol art to the star wars names and splitting into a vertical list.
        private string nameWithStars(string N)
        {
            string[] starredNames = N.Split(',');
            string result = "";
            for (int i = 0; i < starredNames.Length; i++)
            {
                result += starredNames[i].PadLeft(10, '*').PadRight(15, '*')
                    + "<br/ >";
            }
            return result;
        }

        //Adjusting the symbol art. 
        private string nameWithStarsShift(string NWS)
        {
          string sorted =  NWS.Remove(73, 2).Insert(63, "*").Remove(48, 1).Insert(52, "*") + "<br/>";
            return sorted;
        }

        // displaying the results of string manipulations on screen to a label.
        private void displayResult(string PZ)
        {
        resultLabel.Text =
        nameWithStarsShift(nameWithStars(names)) + "<br/>"
        + ReverseString(name) + "<br/>"
        + ReverseWordOrder(starName, names).Remove(23, 1) + "<br/>"
        + puzzleSorter(puzzle);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            displayResult(puzzle);
            // 1.  Reverse your name


            // In my case, the result would be:
            // robaT boB



            // 2.  Reverse this sequence:
            
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke




            // 3. Use the sequence to create ascii art:



            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***





            // 4. Solve this puzzle.

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

        }
        
            
            
        
    }
}