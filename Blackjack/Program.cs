namespace Blackjack
{
    internal class Program
    {


        static void Main(string[] args) 
        {
            //Variables for deciding things
            string yesNo;
            bool playerTurn = true;

            //I make a objekt deck using my class called deck 
            Deck deck = new Deck();

            //Asks user if they are ready to play
            Console.WriteLine("Klar til at spille (y/n)");
            yesNo = Console.ReadLine().ToLower();

            //Checks if user said yes
            if (yesNo == "y")
            {
                //Clears the console
                Console.Clear();

                //a for loop to pickup 2 cards for the player
                for (int i = 0; i < 2; i++)
                {
                    deck.PickUp(playerTurn);
                    
                }

                //set a bool to false to indicate that its the computers turn to pickup cards
                playerTurn = false;

                //a for loop to pickup 2 cards for the computer
                for (int i = 0; i < 2; i++)
                {
                    deck.PickUp(playerTurn);              
                }

                //runs a method to show all the players cards and one of the computers cards
                deck.showTablePlayersTurn();

                //a loop that asks users if they want to pickup another card
                do
                {
                    //asks the user to hit or not
                    Console.WriteLine("do you want to hit (y/n)");
                    yesNo = Console.ReadLine().ToLower();

                    //checks choice
                    if (yesNo == "y")
                    {
                        //sets it to the players turn to pickup cards and picks up one card
                        playerTurn = true;
                        deck.PickUp(playerTurn);
                    }

                    //shows players cards and one of computers cards
                    deck.showTablePlayersTurn();
                } while (yesNo != "n");

                //a do while loop for the computer to pickup cards
                do
                {
                    //checks if the computers cards sum is less then 15, if it is then it picks up a card
                    if (deck.ComputerSum < 15)
                    {

                        yesNo = "y";
                        playerTurn = false;
                        deck.PickUp(playerTurn);
                    }
                    //if not then it says no
                    else
                    {
                        yesNo = "n";
                    }

                    //Shows all players cards and all computers cards
                    deck.showTable();
                    
                } while (yesNo != "n"); 

                //Waits 3 seconds so it doesn't let the user see what the computer picked up
                Thread.Sleep(3000);

                //Checks whos closer, palyer or computer
                if (21 - deck.PlayerSum < 21 - deck.ComputerSum)
                {
                    Console.Clear();
                    Console.WriteLine("Player WON!!!!");
                }
                else if (deck.PlayerSum == deck.ComputerSum)
                {
                    Console.Clear();
                    Console.WriteLine("Both Win");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Computer Won!!!!!");
                }

            }
        }
    }
}