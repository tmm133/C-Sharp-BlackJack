using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        //private List<Card> cards = new List<Card>();
        private List<Card> cards = new List<Card>();
        public int totalCardsBeforeDealing = 0;

        public Deck(){}

        public void addCard(Card c)
        {
            cards.Add(c);
            totalCardsBeforeDealing++;
        }

        public void clearDeck()
        {
            cards.Clear();
        }

        public void shuffle() //Implements fisher-yates shuffle
        {
            Random random = new Random();
            int n = cards.Count();
            for (int i = 0; i < n; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                int r = i + (int)(random.NextDouble() * (n - i));
                Card car = cards[r];
                cards[r] = cards[i];
                cards[i] = car;
            }
        }

        public int getNumCardsRemaining()
        {
            return cards.Count();
        }

        //Gives top card to player and removes it from the shoe
        public Card dealCard()
        {
            Card tempCard = new Card(cards[0].getSuite(), cards[0].getRank(), cards[0].getValue());

            cards.Remove(cards[0]);

            return tempCard;
        }

    }
}
