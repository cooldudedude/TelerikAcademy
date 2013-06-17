using System;

class AllCards
{
    static void Main()
    {
        string[] cards = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Jack", "Queen", "King", "Ace" };
        string[] colours = { "Clubs", "Spades", "Diamonds", "Hearts" };

        foreach (var card in cards)
        {
            foreach (var colour in colours)
            {
                Console.WriteLine("{0} of {1}",card,colour) ;
            }
        }
    }
}
