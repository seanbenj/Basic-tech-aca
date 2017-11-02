using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chal11Darts
{
    public static class Score
    {
        public static int CalculateScore(string playerThrow)
        {
            int score = 0;
            if (playerThrow == "InnerBullseye") score = 50;
            else if (playerThrow == "OuterBullseye") score = 25;
            else score = int.Parse(playerThrow);
            return score;
        }
    }
}