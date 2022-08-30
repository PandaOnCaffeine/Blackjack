namespace Blackjack
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Cards cards = new Cards();
            Console.WriteLine($"{cards.Deck}");
            Console.WriteLine("");
        }
    }
}