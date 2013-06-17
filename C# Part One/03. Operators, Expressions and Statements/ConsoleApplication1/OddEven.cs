//Write an expression that checks if given integer is odd or even.

using System;

class OddEven
{
    static void Main()
    {
        Console.WriteLine("This program determines if a number is odd or even");
        Console.Write("Entery your number ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}
