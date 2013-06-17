using System;

class Sequence
{
    static void Main()
    {
        int PositiveNumbers = 2;
        int NegativeNumbers = -3;
        Console.WriteLine(PositiveNumbers);
        Console.WriteLine(NegativeNumbers);

        for (int loop = 0; loop < 10; loop++)
        {
            PositiveNumbers = PositiveNumbers + 2;
            NegativeNumbers = NegativeNumbers - 2;
            Console.WriteLine(PositiveNumbers);
            Console.WriteLine(NegativeNumbers);
        }
    }
}
