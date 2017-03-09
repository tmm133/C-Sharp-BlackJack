using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Human : Player
    {
        public Human(int ID, string playerName, int cash)
        {
            id = ID;
            name = playerName;
            money = cash;
        }
    }
}
