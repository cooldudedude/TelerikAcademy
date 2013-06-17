using System;

class NFactorialKminusN
{
    static void Main()
    {
        Console.WriteLine("This program calculates N!*K!/(K-N)!");
        Console.Write("Enter N (must be smaller than K): ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K (must be bigger than N): ");
        double K = double.Parse(Console.ReadLine());

        long NFactorial = 1;
        long KFactorial = 1;
        long KMinusNFactorial = 1;

        if (K < N)
        {

            for (int i = 1; i <= N; i++)
            {
                NFactorial *= i;
            }

            for (int i = 1; i <= K; i++)
            {
                KFactorial *= i;
            }

            for (int i = 1; i <= (K - N); i++)
            {
                KMinusNFactorial *= i;
            }

            decimal result = (decimal)((NFactorial * KFactorial) / KMinusNFactorial);

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Wrong input...K must be bigger than N");
        }
    }
}
