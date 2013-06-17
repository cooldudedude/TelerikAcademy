using System;
using System.Numerics;

class SequenceOfFibonacci
{
    static void Main()
    {
        //The fibonacci sequence in our casei is too long, so we need to use big integer
        
        BigInteger fibonacciNumber1 = 0;
        BigInteger fibonacciNumber2 = 1;

        Console.WriteLine(fibonacciNumber1);
        Console.WriteLine(fibonacciNumber2);

        for (int i = 0; i < 100; i++)
        {
            BigInteger fibonacciNumber3 = fibonacciNumber1 + fibonacciNumber2;
            fibonacciNumber1 = fibonacciNumber2;
            fibonacciNumber2 = fibonacciNumber3;
            Console.WriteLine(fibonacciNumber3);
        }
    }
}
