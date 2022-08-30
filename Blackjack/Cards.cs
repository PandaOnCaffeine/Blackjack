using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public struct Cards
    {
        //public CardColors colors;
        //public CardValues values;
        private int colors;
        private int value;


        public Cards(int color, int value)
        {
            this.colors = color;
            this.value = value;
        }
    }
}
