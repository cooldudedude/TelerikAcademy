using System;

class ExchangeBitInterval
{
    static void Main()
    {
        // Test with 15 for easier results

        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter initial position ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter final position ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter interval ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        for (int i = 0; i < k; i++)
        {
            int maskPBit = 1 << (p+i);
            int numberAndMaskP = maskPBit & number;
            int bitP = numberAndMaskP >> (p+i);
        
            int maskQbit = 1 << (q+i);
            int numberAndMaskQ = maskQbit & number;
            int bitQ = numberAndMaskQ >> (q+i);

            number = (~numberAndMaskP) & number;
            number = (bitQ << p+i) | number;

            number = (~numberAndMaskQ) & number;
            number = (bitP << q+i) | number;
        }

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

    }
}