using System;
using System.Numerics;

class NumberOfZeros
{
    static void Main()
    {
        Console.Write("Enter N: ");
        uint n = uint.Parse(Console.ReadLine());

        BigInteger NFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            NFactorial *= i;
        }

        int NumberOfZeros = 0;

        while (NFactorial % 10 == 0)
        {
            NumberOfZeros++;
            NFactorial = NFactorial / 10;
        }

        Console.WriteLine("There are {0} zeros in {1} factorial", NumberOfZeros, n);
    }
}