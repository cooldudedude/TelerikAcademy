using System;

class ExchangeBit
{
    static void Main()
    {
        // I would recommend, testing the application with 56 or 117440512

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int mask24bit = 7 << 24;
        int numberAndMask24 = mask24bit & number;
        int bit24 = numberAndMask24 >> 24;
        
        int maskThirdBit = 7 << 3;
        int numberAndMask3 = maskThirdBit & number;
        int bit3 = numberAndMask3 >> 3;

        number = (~numberAndMask3) & number;
        number = (bit24 << 3) | number;

        number = (~numberAndMask24) & number;
        number = (bit3 << 24) | number;

        Console.WriteLine(Convert.ToString(number , 2).PadLeft (32, '0'));

    }
}