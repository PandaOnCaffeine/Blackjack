using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public struct Cards
    { 
        //public CardColors color;
        //public CardValues value;
        private int colors = 0;
        private int values = 0;
        private int[,] deck = new int[4,13];
        public int[,] Deck { get { return deck; } }
        public Cards()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[i,j] = j;
                }
            }
        }
    }
}
