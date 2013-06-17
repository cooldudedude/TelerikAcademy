using System;

class SortValues
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers to sort:"); 
        double[] numbers = new double[3];

        for (int i = 0; i < numbers.Length ; i++)
			{
			    numbers[i] = double.Parse(Console.ReadLine());
			}
        Console.WriteLine();

        if (numbers[0] > numbers[1] && numbers[1] > numbers[2])
        {
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
        }

        if (numbers[0] > numbers[2] && numbers[2] > numbers[1])
        {
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[1]);
        }

        if (numbers[1] > numbers[0] && numbers[0] > numbers[2])
        {
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
        }

        if (numbers[1] > numbers[2] && numbers[2] > numbers[0])
        {
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[0]);
        }

        if (numbers[2] > numbers[1] && numbers[1] > numbers[0])
        {
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[0]);
        }

        if (numbers[2] > numbers[0] && numbers[0] > numbers[1])
        {
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
        }

    }
}