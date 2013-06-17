//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class ThirdDigidIsSeven
{
    static void Main(string[] args)
    {
        Console.Write("Write your number: ");
        int number = int.Parse(Console.ReadLine());
        number = number / 100;
        if (number % 10 == 7)
        {
            Console.WriteLine("The third digit of this number is 7");
        }
        else
        {
            Console.WriteLine("The third digid of this number is not 7");
        }

    }
}
