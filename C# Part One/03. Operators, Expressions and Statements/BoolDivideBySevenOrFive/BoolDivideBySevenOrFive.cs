using System;

class BoolDivideBySevenOrFive
{
    static void Main()
    {
        Console.WriteLine("This program checks if a number can be divided by both 7 and 5 at the same time");
        Console.Write("Enter your number ");
        int number = int.Parse(Console.ReadLine());
        if (number % 7 == 0 && number % 5 == 0)
        {
            Console.WriteLine("This number can be divided by both 7 and 5");
        }
        else
        {
            Console.WriteLine("This number cannot be divided by both 7 and 5");
        }
    }
}