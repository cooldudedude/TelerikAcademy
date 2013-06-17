using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        double[] numbers = new double[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        double maximumNumber = numbers.Max();
        Console.Write("The biggest of the numbers is: ");
        Console.WriteLine(maximumNumber);
    }

    
}
