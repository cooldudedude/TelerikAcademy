using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size: ");
        uint size = uint.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 1; j <= size; j++)
            {
                Console.Write(i+j);
            }

            Console.WriteLine();
        }

    }
}