using System;

class NumbersN
{
    static void Main()
    {
        Console.WriteLine("How many numbers you want to sum? ");
        uint n = uint.Parse(Console.ReadLine());
        double[] numbersN = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter {0} number: ", i+1);
            numbersN[i] = double.Parse(Console.ReadLine());
        }

        double result = 0;

        for (int i = 0; i < n; i++)
        {
            result = result + numbersN[i];
        }

        Console.WriteLine(result);
    }
}

/* Решение без масиви:
 * 
 using System;

class Test
{static void Main()
    {
        Console.WriteLine("How many numbers you want to sum? ");
        uint n = uint.Parse(Console.ReadLine());

        int result = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter next number: ");
            result += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(result);
    }
}

*/