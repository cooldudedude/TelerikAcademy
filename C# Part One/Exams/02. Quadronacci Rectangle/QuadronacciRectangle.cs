using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long fNumber  = long.Parse(Console.ReadLine());
        long sNumber  = long.Parse(Console.ReadLine());
        long tNumber  = long.Parse(Console.ReadLine());
        long foNumber = long.Parse(Console.ReadLine());

        int rows    = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        long[] numbers = new long[columns + 1];

        numbers[0] = fNumber;
        numbers[1] = sNumber;
        numbers[2] = tNumber;
        numbers[3] = foNumber;

        for (int i = 0; i < rows; i++)
        {

            numbers[4] = numbers[0] + numbers[1] + numbers[2] + numbers[3];

            for (int j = 0; j < columns; j++)
            {
                if (i == 0 && j < 4)
                {
                    Console.Write(numbers[j] + " ");
                }
                else if (i >= 0)
                {
                    numbers[4] = numbers[0] + numbers[1] + numbers[2] + numbers[3];
                    numbers[0] = numbers[1];
                    numbers[1] = numbers[2];
                    numbers[2] = numbers[3];
                    numbers[3] = numbers[4];
                    if (j == columns - 1)
                    {
                        Console.Write(numbers[4]);
                    }
                    else
                    {
                        Console.Write(numbers[4] + " ");
                        
                    }
                }
               
                
			}

            Console.WriteLine();

            
        }
    }
}
