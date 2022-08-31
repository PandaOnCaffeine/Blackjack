using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public struct Cards
    {
        public string CardSymbol { get; }
        public int CardRank { get; }
        public int CardNumber { get; }

        public Cards(string cardSymbol, int cardRank, int cardNumber)
        {
            this.CardSymbol = cardSymbol;
            this.CardRank = cardRank;
            this.CardNumber = cardNumber;
        }

        public override string ToString()
        {
            if (CardNumber > 10)
            { 
                string cardWithPicture = "";
                switch (CardNumber)
                {
                    case 11:
                        cardWithPicture = "Knight";
                        break;
                    case 12:
                        cardWithPicture = "Queen";
                        break;
                    case 13:
                        cardWithPicture = "King";
                        break;
                    default:
                        break;
                }
                return CardSymbol + ":" + cardWithPicture;
            }
            else
            {
                return CardSymbol + ":" + CardNumber;
            }
            return base.ToString();
        }
    }
}
