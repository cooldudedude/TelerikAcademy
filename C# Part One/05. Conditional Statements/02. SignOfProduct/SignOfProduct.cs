using System;

class SignOfProduct
{
    static void Main()
    {
        double[] numbers = new double[3];

        Console.WriteLine("Enter three numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        bool notNull = true;

        if (numbers[0] == 0 || numbers[1] == 0 || numbers[2] == 0)
        {
            Console.WriteLine("The product of the numbers is 0");
            notNull = false;
        }

        if (notNull == true)
        {
            int result = 0;
        
            if (numbers[0] <0 )
            {
                result++;
            }

            if (numbers[1] < 0)
            {
                result++;
            }

            if (numbers[2] < 0)
            {
                result++;
            }

            if (result == 1 || result == 3)
            {
                Console.WriteLine("The product of the numbers is negative");
            }
            else
            {
                Console.WriteLine("The product of the numbers is positive");
            }
        }
    }
}
