using System;

class ReadPositiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter two positive numbers:");
        uint number1 = uint.Parse(Console.ReadLine());
        uint number2 = uint.Parse(Console.ReadLine());

        int numbersP = 0;

        if (number2 > number1) // Застраховам се, за да съм сигурен, че number1 е по-голямото число
        {
            uint temp;
            temp = number1;
            number1 = number2;
            number2 = temp;
        }

        for (uint i = number2; i <= number1; i++)
        {
            if (i % 5 == 0) 
            {
                numbersP++;
            }
        }
        Console.WriteLine("There are {0} numbers that can be divided by 5 between the two numbers", numbersP);
    }
}

