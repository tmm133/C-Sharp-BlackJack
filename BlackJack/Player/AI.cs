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

        public AI(string AIname, int difcultyLvl)
        {
            name = AIname;
            difficultyLevel = difcultyLvl;
        }

        public void makeMove()
        {
            switch(difficultyLevel)
            {
                case 0:
                    noviceAIMove();
                    break;
                case 1:
                    goodAIMove();
                    break;
                case 2:
                    proAIMove();
                    break;
            }
        }

        public void noviceAIMove()
        {

        }

        public void goodAIMove()
        {

        }

        public void proAIMove()
        {

        }
    }
}
