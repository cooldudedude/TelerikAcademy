using System;

class BiggestInt
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int[] numbers = new int[3];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        if (numbers[0] > numbers[1] && numbers[0] > numbers[2])
        {
            Console.WriteLine("{0} is the biggest number", numbers[0]);
        }
        else if (numbers[1] > numbers[0] && numbers[1] > numbers[2])
        {
            Console.WriteLine("{0} is the biggest number", numbers[1]);
        }
        else
        {
            Console.WriteLine("{0} is the biggest number", numbers[2]);
        }

    }
}
