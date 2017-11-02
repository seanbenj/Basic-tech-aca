using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chal11Darts
{
    public class Game
    {

        private void PlayRound(Player player1, Player player2, Dart dart)
        {               
                player2.Score += Score.CalculateScore(dart.Throw());
                player2.Score += Score.CalculateScore(dart.Throw());
                player2.Score += Score.CalculateScore(dart.Throw());
                player1.Score += Score.CalculateScore(dart.Throw());
                player1.Score += Score.CalculateScore(dart.Throw());
                player1.Score += Score.CalculateScore(dart.Throw());
        }

        public string PlayDarts(Player player1, Player player2, Dart dart)
        {
            string result = "";
            int count = 0;
            while (player1.Score < 300 && player2.Score < 300)
            {
                PlayRound(player1, player2, dart);
                count++;
                result += "Round" + count + "<hr/>";
                result += player1.Name + "'s Score After (3)Throws: " + player1.Score + "<br>";
                result += player2.Name + "'s Score After (3)Throws: " + player2.Score + "<br>";
            } 
            return result;
        }

        public string DisplayWinner(Player player1, Player player2)
        {
            string winner = "";
            string winner1 = String.Format("{0} wins the game of darts by a total of: {1} points!",
            player1.Name, player1.Score - player2.Score);
            string winner2 = String.Format("{0} wins the game of darts by a total of: {1} points!",
            player2.Name, player2.Score - player1.Score);
            if (player1.Score > player2.Score) winner = winner1;
            else if (player1.Score < player2.Score) winner = winner2;
            return winner;
        }
    }
}