using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class AI : Player
    {
        private int difficultyLevel { get; set; }

        public AI(string AIname, int difcultyLvl, int ID)
        {
            //Random r = new Random();
            id = ID;//r.Next(100000, 500000);
            name = AIname;
            difficultyLevel = difcultyLvl;
            surrender(false);
        }

        public void makeMove(ref Deck shoe)
        {
            switch(difficultyLevel)
            {
                case 0:
                    noviceAIMove(ref shoe);
                    break;
                case 1:
                    goodAIMove(ref shoe);
                    break;
                case 2:
                    proAIMove(ref shoe);
                    break;
            }
        }

        public void makeBet(Random r)
        {
            switch (difficultyLevel)
            {
                case 0:
                    noviceAIBet(r);
                    break;
                case 1:
                    //goodAIBet();
                    break;
                case 2:
                    //proAIBet();
                    break;
            }
        }

        public void noviceAIMove(ref Deck shoe)
        {
            while (getTotalCardValue() < 17)
            {
                hand.Add(shoe.dealCard());
            }
        }

        public void noviceAIBet(Random r)
        {
            int bet = r.Next(10, money/4);
            placeBet(bet);
        }

        public void goodAIMove(ref Deck shoe)
        {

        }

        public void proAIMove(ref Deck shoe)
        {

        }
    }
}
