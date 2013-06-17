using System;

class ValueExchange
{
    static void Main()
    {
        int first = 5;
        int second = 10;
        int third = 0;

        third = first;
        first = second;
        second = third;

        Console.WriteLine(first);
        Console.WriteLine(second);

    }
}

