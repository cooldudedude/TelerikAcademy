using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("The greater of the two numbers is: ");
        Console.WriteLine(Math.Max(number1, number2));
    }
}
