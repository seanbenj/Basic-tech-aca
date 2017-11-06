using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOWarChal13
{
    public class Battle
    {
        // takes a card from player and turns it into a card.
        public Card DealBattleCard(Player player)
        {
            Card battleCard = player.PlayerDeck.ElementAt(0);
            player.PlayerDeck.Remove(battleCard);
            return battleCard;
        }

        // checks to see who wins the round.
        public string CompareCards(Card player1Card, Card player2Card, Player player1, Player player2)
        {
            string battleWinner = "";
            if (player1Card.Value > player2Card.Value)
                // loots the cards to the winner, and shows to user.
                battleWinner = LootBattleCards(player1Card, player2Card, player1);
            else if (player2Card.Value > player1Card.Value)
                battleWinner = LootBattleCards(player1Card, player2Card, player2);
                // makes sure war doesn't happen if players have 1 card only to avoid errors ,
                // if this occurs the player in the lead takes the last cards ending the game.
            else if (player1Card.Value == player2Card.Value && player1.PlayerDeck.Count == 1 ||
            player1Card.Value == player2Card.Value && player2.PlayerDeck.Count == 1)
            {
                battleWinner +=
                "<br>Neither player had enough cards left for war, so the draw goes to leader<br>";
                if (checkWinner(player1, player2, player1Card, player2Card) == "player1")
                    battleWinner += LootBattleCards(player1Card, player2Card, player1);
                else battleWinner += LootBattleCards(player1Card, player2Card, player2);             
            }
            // If cards are equal then War battle.
            else battleWinner = War(player1Card, player2Card, player1, player2);
            return battleWinner;
        }

        // Find winner when war can't occur.
        private string checkWinner(Player _player1, Player _player2, Card card1, Card card2)
        {
            string winner;
            if (_player1.PlayerDeck.Count > _player2.PlayerDeck.Count) winner = "player1";
            else winner = "player2";
            return winner;
        }

        // Take cards from battle, put in winners deck and display text.
        private string LootBattleCards(Card loot1Card, Card loot2Card, Player player)
        {
            player.PlayerDeck.Add(loot1Card);
            player.PlayerDeck.Add(loot2Card);
            string lootWinner = string.Format
            ("{0} wins the round, and gets:<br><hr/>{1} of {2}'s<br>{3} of {4}'s",
            player.Name, loot1Card.Kind, loot1Card.Suit, loot2Card.Kind, loot2Card.Suit);
            return lootWinner;
        }

        
        private string War(Card lootCard1_,Card lootCard2_, Player _player1, Player _player2)
        {
            List<Card> lootCards = new List<Card>();
            // Add cards to new list.
            lootCards.Add(lootCard1_);
            lootCards.Add(lootCard2_);
            // Deal and add 4 more to list. 
            lootCards.Add(DealBattleCard(_player1));
            lootCards.Add(DealBattleCard(_player2));
            // Assign new battle cards.
            Card warCard1 = DealBattleCard(_player1);
            Card warCard2 = DealBattleCard(_player2);
            // Battling, finding a winner.
            string winner =
            compareWarCards(lootCards, warCard1, warCard2, _player1, _player2);
            // Giving cards to winner, and displaying.
            string result = lootWarCards(lootCards, _player1, _player2, winner, warCard1, warCard2);
            return result; 
        }

        // Check for winning player card.
        private string compareWarCards
        (List<Card> _lootCards, Card _warCard1, Card _warCard2, Player player1_, Player player2_)
        {
            string winner = "";
            if (_warCard1.Value > _warCard2.Value)
            {
                // Adding battle cards to list.
                _lootCards.Add(_warCard1);
                _lootCards.Add(_warCard2);
                winner += "player1";
            }
            else if (_warCard1.Value < _warCard2.Value) 
            {
                _lootCards.Add(_warCard1);
                _lootCards.Add(_warCard2);
                winner = "player2";
            }
            // if cards are the same WAR again.
            else winner += continuedWar(_lootCards, _warCard1, _warCard2, player1_, player2_);
            return winner;
        }

        private string continuedWar
        (List<Card> lootCards, Card _warCard1, Card _warCard2, Player player1_, Player player2_)
        {
            // adding cards to list.
            lootCards.Add(_warCard1);
            lootCards.Add(_warCard2);
            // dealing 4 cards assigning 2 new battle cards.
            lootCards.Add(DealBattleCard(player1_));
            lootCards.Add(DealBattleCard(player2_));
            Card warCard1 = DealBattleCard(player1_);
            Card warCard2 = DealBattleCard(player2_);
            // text display for user.
            string winner = string.Format
            ("Player {0} Card: {1} of {2}'s -- VS -- Player {3} Card: {4} of {5}'s <br><hr/>" +
            "<br><hr/>**!War!**<hr/><br> Dealing (2) war battle cards & (2) loot cards...<br><br>" +
            "Player {6} Battle Card: {7} of {8}'s -- VS -- Player {9} Battle Card: {10} of {11}'s <br><hr/>",
            player1_.Name, _warCard1.Kind, _warCard1.Suit,
            player2_.Name, _warCard2.Kind, _warCard2.Suit,
            player1_.Name, warCard1.Kind, warCard1.Suit,
            player2_.Name, warCard2.Kind, warCard2.Suit);
            // Battling, finding a winner.
            winner += compareWarCards(lootCards, warCard1, warCard2, player1_, player2_);
            return winner;
        }

        // giving the cards of the war/wars to the winners deck.
        private string lootWarCards
        (List<Card> lootCards_, Player _player1, Player _player2, string _winner, Card card1, Card card2)
        {
            // displaying war.
            string result ="<br><hr/>**!War!**<hr/><br>";
            if (_winner.Contains("player1"))
            {
                // displaying the winner.
                result +=
                string.Format("Dealing (2) war battle cards & (2) loot cards...<br><br>{0}{1}" +
                "<br>{2} wins the war round/rounds and gains the spoils!:<br><hr/>"
                ,showWarCards(_player1, _player2, card1, card2), _winner.Remove(_winner.Length - 7, 7), _player1.Name);
                // adding cards to players deck.
                _player1.PlayerDeck.AddRange(lootCards_);
                // displaying cards added to players deck.
                foreach (var card in lootCards_)
                {
                    result += card.Kind + " of " + card.Suit + "s" + "<br>";
                }
            }
            else if (_winner.Contains("player2"))
            {
                result += 
                string.Format("Dealing (2) war battle cards & (2) loot cards...<br><br>{0}{1}" +
                "<br>{2} wins the war round/rounds and gains the spoils!:<br><hr/>" 
                ,showWarCards(_player1,_player2,card1,card2), _winner.Remove(_winner.Length - 7, 7), _player2.Name);
                _player1.PlayerDeck.AddRange(lootCards_); 
                foreach (var card in lootCards_)
                {
                    result += card.Kind + " of " + card.Suit + "s" + "<br>";
                }
            }
            
            return result;
        }

        // displaying cards at battle in war.
        private string showWarCards(Player player1, Player player2, Card card1_, Card card2_)
        {
            string warCardsDisplay = string.Format
            ("Player {0} Battle Card: {1} of {2}'s -- VS -- Player {3} Battle Card: {4} of {5}'s <br><hr/>",
            player1.Name, card1_.Kind, card1_.Suit, player2.Name, card2_.Kind, card2_.Suit);
            return warCardsDisplay;
        }
    }
}