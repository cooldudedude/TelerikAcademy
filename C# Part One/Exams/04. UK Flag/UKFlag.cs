using System;

class UKFlag
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size / 2; i++)
        {
            Console.Write(new string('.', i));
            Console.Write("\\");
            Console.Write(new string('.', size / 2 - (i + 1)));
            Console.Write("|");

            Console.Write(new string('.', size / 2 - (i + 1)));
            Console.Write("/");
            Console.Write(new string('.', i));

            Console.WriteLine();
        }
        Console.Write(new string('-', (size / 2)));
        Console.Write("*");
        Console.Write(new string('-', size / 2));
        Console.WriteLine();

        for (int i = 0; i < size / 2; i++)
        {
            Console.Write(new string('.', size / 2 - (i + 1)));
            Console.Write("/");
            Console.Write(new string('.', i));
            Console.Write("|");

            Console.Write(new string('.', i));
            Console.Write("\\");
            Console.Write(new string('.', size / 2 - (i + 1)));

            Console.WriteLine();
        }
    }
}