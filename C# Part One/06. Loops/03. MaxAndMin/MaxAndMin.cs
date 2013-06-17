using System;
using System.Linq;

    class MaxAndMin
    {
        static void Main()
        {
            Console.Write("How many numbers do you want to enter? ");
            int N = int.Parse(Console.ReadLine());

            int[] numbers = new int[N];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int minNumber = numbers.Min();
            int maxNumber = numbers.Max();

            Console.WriteLine("The maximal number is: {0}", maxNumber);
            Console.WriteLine("The minimal number is: {0}", minNumber);
        }
    }
