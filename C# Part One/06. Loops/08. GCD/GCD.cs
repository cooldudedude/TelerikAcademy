using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double fNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double sNumber = double.Parse(Console.ReadLine());

        if (fNumber < sNumber)
        {
            double temp = fNumber;
            fNumber = sNumber;
            sNumber = temp;
        }

        double result;
        double resultRemainder;

        Console.WriteLine();
        while (true)
        {
            result = fNumber / sNumber;
            resultRemainder = fNumber % sNumber;

            if (resultRemainder != 0)
            {
                Console.WriteLine("{0} : {1} = {2} ; reminder = {3}", fNumber, sNumber, result, resultRemainder);
                fNumber = sNumber;
                sNumber = resultRemainder;
            }
            else
            {
                Console.WriteLine("The Greatest Common Divider is: {0}", sNumber);
                break;
            }
        }
    }
}