namespace Blackjack
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string yesNo;
            bool gameDone = false;
            bool playerTurn = true;
            int playerSum = 0;
            int computerSum = 0;

            List<Cards> computerCards = new List<Cards>();

            Deck deck = new Deck();

            Console.WriteLine("Klar til at spille (y/n)");
            yesNo = Console.ReadLine().ToLower();
            if (yesNo == "y")
            {
                Console.Clear();

                for (int i = 0; i < 2; i++)
                {
                    deck.PickUp(playerTurn);
                    
                }

                playerTurn = false;
                for (int i = 0; i < 2; i++)
                {
                    deck.PickUp(playerTurn);              
                }
                deck.showTablePlayersTurn();

                do
                {
                    Console.WriteLine("do you want to hit (y/n)");
                    yesNo = Console.ReadLine().ToLower();

                    if (yesNo == "y")
                    {
                        playerTurn = true;
                        deck.PickUp(playerTurn);
                    }

                    deck.showTablePlayersTurn();
                } while (yesNo != "n");

                deck.playerCards[0];
                foreach (Cards c in deck.playerCards)
                {
                    Console.WriteLine(c);
                }


            }




        }
    }
}