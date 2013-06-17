using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter your number ");
        int n = int.Parse(Console.ReadLine());
        if (n == 2 || n == 3 || n == 5 || n == 7)
        {
            Console.WriteLine("The number is prime");
        }
        else if ((n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0) && (n % 7 != 0))
        {
            Console.WriteLine("The number is prime");
        }
        else
        {
            Console.WriteLine("The number is not prime");
        }
    }
}

