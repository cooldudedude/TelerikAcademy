using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter fibonacci length: ");
        uint length = uint.Parse(Console.ReadLine());

        BigInteger fibonacciNumber1 = 0;
        BigInteger fibonacciNumber2 = 1;

        if (length == 0)
        {
            Console.WriteLine("Wrong input");
        }
        else if (length == 1)
        {
            Console.WriteLine(fibonacciNumber1);
        }
        else if (length == 2)
        {
            Console.WriteLine(fibonacciNumber1);
            Console.WriteLine(fibonacciNumber2);
        }
        else
        {
            Console.WriteLine(fibonacciNumber1);
            Console.WriteLine(fibonacciNumber2);

            for (int i = 0; i < length - 2; i++)
            {
                BigInteger fibonacciNumber3 = fibonacciNumber1 + fibonacciNumber2;
                fibonacciNumber1 = fibonacciNumber2;
                fibonacciNumber2 = fibonacciNumber3;
                Console.WriteLine(fibonacciNumber3);
            }
        }
    }
}