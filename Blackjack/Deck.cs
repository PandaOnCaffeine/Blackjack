using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Deck
    {
        public List<Cards> playerCards = new List<Cards>();
        public List<Cards> computerCards = new List<Cards>();

        private int playerSum = 0;
        private int computerSum = 0;
        string cardSymbol = "";
        int cardRank = 0;

        int[,] cards = new int[,]
        {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        };

        Random rng = new Random();


        public int PlayerSum { get { return playerSum; } }
        public int ComputerSum { get { return computerSum; } }


        public void PickUp(bool turn)
        {
            bool player = turn;
            if (player == true)
            {
                int symbol = rng.Next(0, cards.GetLength(0));
                int number = rng.Next(0, cards.GetLength(1));

                int cardNumber = cards[symbol, number];

                if (cardNumber > 10)
                {
                    cardRank = 10;
                }
                else
                {
                    cardRank = cardNumber;
                }

                switch (symbol)
                {
                    case 0:
                        cardSymbol = "Hearts";
                        break;
                    case 1:
                        cardSymbol = "Spades";
                        break;
                    case 2:
                        cardSymbol = "Clubs";
                        break;
                    case 3:
                        cardSymbol = "Diamond";
                        break;
                    default:
                        break;
                }
                Cards card = new Cards(cardSymbol, cardRank, cardNumber);
                playerCards.Add(card);
                playerSum += cardRank;
            }
            else
            {
                int symbol = rng.Next(0, cards.GetLength(0));
                int number = rng.Next(0, cards.GetLength(1));

                int cardNumber = cards[symbol, number];

                if (cardNumber > 10)
                {
                    cardRank = 10;
                }
                else
                {
                    cardRank = cardNumber;
                }

                switch (symbol)
                {
                    case 0:
                        cardSymbol = "Hearts";
                        break;
                    case 1:
                        cardSymbol = "Spades";
                        break;
                    case 2:
                        cardSymbol = "Clubs";
                        break;
                    case 3:
                        cardSymbol = "Diamond";
                        break;
                    default:
                        break;
                }
                Cards card = new Cards(cardSymbol, cardRank, cardNumber);
                computerCards.Add(card);
                computerSum += cardRank;
            }

        }
        public void showTablePlayersTurn()
        {
            Console.Clear();
            Console.WriteLine("Players cards: Sum: " + playerSum);
            foreach (Cards c in playerCards)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("");
            Console.WriteLine("Computers cards:");
            Console.WriteLine(computerCards[0]);
        }
    }
}
