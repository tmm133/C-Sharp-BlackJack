using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Seat //Maybe will add in some shit for min/max bets of the table
    {
        public int seatNumber { get; set; }
        public Player player { get; set; }

        public Seat(int seatNum)
        {
            seatNumber = seatNum;
            player = null;
        }

        public Seat(int seatNum, Player p)
        {
            seatNumber = seatNum;
            player = p;
        }
    }
}
