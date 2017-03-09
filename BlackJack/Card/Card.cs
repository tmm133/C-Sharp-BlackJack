using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        private string suit { get; set; }
        private string rank { get; set; }
        private int value { get; set; }

        public Card(string s, string r, int v)
        {
            suit = s;
            rank = r;
            value = v;
        }

        public string getSuite()
        {
            return suit;
        }

        public string getRank()
        {
            return rank;
        }

        public int getValue()
        {
            return value;
        }
    }
}
