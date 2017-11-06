using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOWarChal13
{
    public class Deck
    {
        public List<Card> deck { get; set; }

        // Making two arrays to make creating a list of cards easier.
        string[] Suits = new string[] 
        {"Heart","Spade","Club","Diamond"};
        string[] Kinds = new string[]
        {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen" ,"King", "Ace" };

        public string CreateDeck (Deck deck_)
        {
            // text to display showing that shuffling is happening behind the scenes.
            string shuffle = "Shuffling the Deck...<br>";
            deck_.deck = new List<Card>();
            // creating a list of cards from arrays and adding each to a deck.
            foreach (var suit in Suits)
            {
                foreach (var kind in Kinds)
                {
                    deck_.deck.Add(new Card() {Kind = kind,  Suit = suit});

                }
            }
            // adding card values.
            foreach (var card in deck_.deck)
            {
                findCardValue(card);
            }
            // shuffling the card.
            Shuffle(deck_.deck);

            return shuffle;
        }

        private void findCardValue(Card card)
        {
            if (card.Kind == "Jack") card.Value = 11;
            else if (card.Kind == "Queen") card.Value = 12;
            else if (card.Kind == "King") card.Value = 13;
            else if (card.Kind == "Ace") card.Value = 14;
            else card.Value = int.Parse(card.Kind);
        }

        private Random rnd = new Random();

        public void Shuffle(List<Card> cards)
        {
            // making new deck to add cards to.
            Deck D = new Deck();
            D.deck = new List<Card>();
            // looping through each card in the old deck.
            for (int i = 0; i < 52; i++)
            {
                // randomly grabbing a card from the old deck and assigning it to a new card.
                Card card = cards.ElementAt(rnd.Next(cards.Count -1));
                // adding the card to our new deck.
                D.deck.Add(card);
                // removing it from the old deck.
                cards.Remove(card);
            }
            cards.Clear();
            
            // putting all the cards into the old deck.
            cards.AddRange(D.deck);
        }

    }
}