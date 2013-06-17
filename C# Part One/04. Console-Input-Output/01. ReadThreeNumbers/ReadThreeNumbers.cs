using System;

class ReadThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter number 3: ");
        int number3 = int.Parse(Console.ReadLine());

        Console.WriteLine("You numbers are {0}, {1} and {2}", number1, number2, number3);
    }
}
