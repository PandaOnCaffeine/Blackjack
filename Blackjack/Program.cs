namespace Blackjack
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string yesNo;
            bool playerTurn = true;


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

                do
                {
                    if (deck.ComputerSum < 15)
                    {
                        yesNo = "y";
                        playerTurn = false;
                        deck.PickUp(playerTurn);
                    }
                    else
                    {
                        yesNo = "n";
                    }
                    deck.showTable();
                } while (yesNo != "n");
            }
        }
    }
}