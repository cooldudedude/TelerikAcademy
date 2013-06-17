using System;

class NotDivisibleByThreeOrSeven
{
    static void Main()
    {
        Console.Write("Enter interval length: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
                continue;
            else
            {
                Console.WriteLine(i);
            }
        }

    }
}