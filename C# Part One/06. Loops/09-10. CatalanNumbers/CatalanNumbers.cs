using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Which Catalan number would you like to know? ");
        uint length = uint.Parse(Console.ReadLine());

        long dividend = 1;
        long divisor1 = 1;
        long divisor2 = 1;

        for (int i = 1; i <= 2* length; i++)
        {
            dividend *= i; 
        }

        for (int i = 1; i <= length + 1; i++)
        {
            divisor1 *= i;
        }

        for (int i = 1; i <= length; i++)
        {
            divisor2 *= i;
        }

        decimal result = (decimal)(dividend / (divisor1 * divisor2));
        Console.WriteLine("The {0} Catalan number is {1}",length, result);
    }
}