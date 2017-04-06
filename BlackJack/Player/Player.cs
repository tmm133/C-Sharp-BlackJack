using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlackJack
{
    public class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public int money { get; set; }
        [XmlIgnore]
        public List<Card> hand = new List<Card>();
        [XmlIgnore]
        private int bet { get; set; }
        [XmlIgnore]
        private bool surrendered { get; set; }

        public void hit(ref Deck shoe)
        {
            hand.Add(shoe.dealCard());
        }

        public void placeBet(int b)
        {
            bet = b;
        }

        public int getBet()
        {
            return bet;
        }

        public void stand()
        {

        }

        public bool doubleDown()
        {
            if ((bet *= 2) <= money)
            {
                return true;
            }
            else
            {
                bet /= 2;
                return false;
            }
        }

        public void split()
        {

        }

        public void surrender(bool s)
        {
            surrendered = s;
        }

        public void collectSurrender()
        {
            money -= (bet / 2);
        }

        public bool getSurrender()
        {
            return surrendered;
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

        public void recievePayout()
        {

        }

        public void loseHand()
        {
            money -= bet;
        }

        public void clearHand()
        {
            hand.Clear();
        }
    }
}
