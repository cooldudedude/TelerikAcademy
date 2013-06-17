using System;

class ModifyBitValue
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter desired position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter desired value (0/1): ");
        int value = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int result = 0;

        if (value == 1)
        {
            result = mask | number;
        }
        else if (value == 0)
        {
            result = ~(mask) & number;
        }
        else
        {
            Console.WriteLine("Invalid Input!");
            
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}