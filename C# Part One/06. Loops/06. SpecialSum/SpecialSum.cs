using System;

class SpecialSum
{
    static void Main()
    {
        Console.WriteLine("This program calculates the following sum: S = 1 + 1!/X + 2!/X2 + … + N!/XN");
        Console.Write("Please enter interval length(N): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter X: ");
        decimal x = decimal.Parse(Console.ReadLine());

        decimal[] xArray = new decimal[n+2];

        decimal newX = x;

        long NFactorial = 1;
        long[] NFactorialArray = new long[n+2];

        decimal result = 1 + ( 1 / x );

        for (int i = 2; i <= n; i++)
        {
            NFactorial *= i;
            NFactorialArray[i] = NFactorial;

            newX = newX * x;
            xArray[i] = newX;

            result = result + (NFactorialArray[i] / xArray[i]);
        }

        Console.WriteLine(result);
    }

}
