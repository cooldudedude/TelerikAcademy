using System;

class BoolBit
{
    static void Main()
    {
        Console.Write("Enter your number ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int result = numberAndMask >> p;
        if (result == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
