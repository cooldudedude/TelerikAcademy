using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter your number ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit number ");
        int bitNumber = int.Parse(Console.ReadLine());
        int mask = 1 << bitNumber;
        int numberAndMask = number & mask;
        int result = numberAndMask >> bitNumber;

        Console.WriteLine("The value of bit {0} is: {1}", bitNumber, result);

    }
}
