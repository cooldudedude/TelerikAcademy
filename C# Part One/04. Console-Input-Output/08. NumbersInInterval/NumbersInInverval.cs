using System;

class NumbersInInverval
{
    static void Main()
    {
        Console.Write("Enter interval length: ");
        int interval = int.Parse(Console.ReadLine());

        for (int i = 1; i <= interval; i++)
        {
            Console.WriteLine(i);
        }
    }
}