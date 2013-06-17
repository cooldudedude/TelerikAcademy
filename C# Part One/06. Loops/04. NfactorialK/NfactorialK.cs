using System;

    class NfactorialK
    {
        static void Main()
        {
            Console.WriteLine("This program calculates N!/K");
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            double K = double.Parse(Console.ReadLine());

            long dividend = 1;

            for (int i = 1; i <= N; i++)
            {
                dividend *= i;
            }
            decimal result = (decimal) (dividend / K);

            Console.WriteLine(result);
        }
    }
