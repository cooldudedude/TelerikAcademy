using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        if (number1 > number2)
        {
            int temp = 0;

            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("The first number is greater than the second...exchanging numbers...");
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
        else
        {
            Console.WriteLine("The second number is greater than the first, no exchange is needed");
        }
    }
}
