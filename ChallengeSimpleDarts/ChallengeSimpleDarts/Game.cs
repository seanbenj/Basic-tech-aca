using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player _Player1;
        private Player _Player2;
        private Random _random;
             
        public Game(string player1Name, string player2Name)
        {
            _Player1 = new Player();
            _Player1.Name = player1Name;

            _Player2 = new Player();
            _Player2.Name = player2Name;

            _random = new Random();

        }

        public string Play()
        {
            while (_Player1.Score < 300 && _Player2.Score < 300)
            {
                playRound(_Player1);
                playRound(_Player2);
            }
            return displayResults();
        }

        private string displayResults()
        {
            string result = string.Format("{0}: {1}<br />{2}: {3}",
                _Player1.Name,
                _Player1.Score,
                _Player2.Name,
                _Player2.Score);

            return result += "<br/>" + "Winner: " + (_Player1.Score > _Player2.Score ? _Player1.Name : _Player2.Name);
        }

        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }
    }
}