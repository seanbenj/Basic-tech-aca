using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOWarChal13
{
    public class Game
    {
        Deck _deck = new Deck();

        public string DealHands
        (List<Card> _deck,Player player1,Player player2)
        {
            player1.PlayerDeck = new List<Card>();
            player2.PlayerDeck = new List<Card>();
            // display for behind the scenes dealing.
            string result = "<br>Dealing Player Cards...<br><br>";
            // looping through deck.
            for (int i = 0; i < 26; i++)
            {
                // adding card to each player deck, remove from deck.
                player1.PlayerDeck.Add(_deck.First());
                _deck.Remove(_deck.First());
                player2.PlayerDeck.Add(_deck.Last());
                _deck.Remove(_deck.Last());
                
            }
            return result;
        }

        Battle battle = new Battle();

        // display war game until one player has no cards.
        public string GameOWar(Deck deck, Player _player1, Player _player2)
        {
            string result = "";
            result += deck.CreateDeck(deck);
            result += DealHands(deck.deck, _player1, _player2);
            while (_player1.PlayerDeck.Count > 0 && _player2.PlayerDeck.Count > 0)
            {
                // add each battle to diplay for user.
                result += displayBattleRound(_player1, _player2, battle.DealBattleCard(_player1),
                battle.DealBattleCard(_player2));
            }
            // find who won.
            if (_player1.PlayerDeck.Count > _player2.PlayerDeck.Count) result += displayGameWinner(_player1, _player2);
            else result += displayGameWinner(_player2, _player1);
            return result;
        }

        // display a battle to user.
        public string displayBattleRound(Player player1, Player player2, Card batCard1, Card batCard2)
        {
            string result = string.Format
            ("<br><br>Player {0} Card: {1} of {2}'s -- VS -- Player {3} Card: {4} of {5}'s <br><hr/> {6}",
            player1.Name, batCard1.Kind, batCard1.Suit, 
            player2.Name, batCard2.Kind, batCard2.Suit,
            battle.CompareCards(batCard1, batCard2, player1, player2));
            return result;
        }

        // show winner.
        public string displayGameWinner(Player playerWinner, Player playerLoser)
        {
            string gameWinner = 
            string.Format("<br><hr/><hr/>{0} wins the game, with all {1} cards!" 
            + "<br>{2} loses, better luck next time.",
                playerWinner.Name, playerWinner.PlayerDeck.Count, playerLoser.Name, playerLoser.PlayerDeck.Count);
            return gameWinner;
        }

    }
}