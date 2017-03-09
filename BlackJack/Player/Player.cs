using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public int id;
        public string name { get; set; }
        public int money { get; set; }
        public List<Card> hand = new List<Card>();

        public void hit(ref Deck shoe)
        {
            hand.Add(shoe.dealCard());
        }

        public void stand()
        {

        }

        public void doubleDown()
        {

        }

        public void split()
        {

        }

        public void surrender()
        {

        }

        public int getTotalCardValue()
        {
            int total = 0;
            bool hasAce = false;
            int numberOfAces = 0;
            foreach(Card c in hand)
            {
                total += c.getValue();
                if (c.getRank() == "A")
                {
                    hasAce = true;
                    numberOfAces++;
                }
            }

            if (hasAce && total > 21)
            {
                for(int i = 0; i < numberOfAces; i++)
                    total -= 10;
            }

            return total;
        }

        public void clearHand()
        {
            hand.Clear();
        }
    }
}
