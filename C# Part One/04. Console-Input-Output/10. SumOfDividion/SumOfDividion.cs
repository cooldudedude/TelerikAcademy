using System;

class SumOfDividion
{
    static void Main()
    {
        Console.Write("Enter interval length: ");
        float interval = float.Parse(Console.ReadLine());

        float divisor1 = 2;
        float divisor2 = 3;

        float result = 1;

        for (int i = 0; i < interval; i++)
        {
            float firstNumber = (1 / divisor1);
            float secondNumber = (1 / divisor2);

            result = result + firstNumber - secondNumber;

            divisor1 += 2;
            divisor2 += 2;
        }

        Console.WriteLine(result);
    }
}