using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Dealer : Player
    {
        public Dealer() { }

        //Overrides Player::Hit()
        public void hit(ref Deck shoe)
        {
            while(getTotalCardValue() < 17)
            {
                hand.Add(shoe.dealCard());
            }
        }

        public void collectChips(Player p)
        {

        }

        public void payoutChips(Player p)
        {

        }
    }
}
