using System;

class SevenlandNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int result = 0;

        result = input + 1;

            for (int i = 0; i < 1; i++)
            {
                int lastNumber = input % 10;
                int secondNumber = ((input / 10) % 10);
                int firstNumber = ((input / 100) % 10);

                if (lastNumber == 6)
                {
                    result += 3;
                }

                if (lastNumber == 7)
                {
                    result += 2;
                }
                if (lastNumber == 8)
                {
                    result += 1;
                }

                if (firstNumber == 1 && 6 < secondNumber && secondNumber < 10)
                {
                    result = 200;
                }

                if (firstNumber == 2 && 6 < secondNumber && secondNumber < 10 )
                {
                    result = 300;
                }

                if (firstNumber == 3 && 6 < secondNumber && secondNumber < 10)
                {
                    result = 400;
                }

                if (firstNumber == 4 && 6 < secondNumber && secondNumber < 10)
                {
                    result = 500;
                }
                if (firstNumber == 5 && 6 < secondNumber && secondNumber < 10)
                {
                    result = 600;
                }

                if (firstNumber == 6 && 6 < secondNumber && secondNumber < 10)
                {
                    result = 700;
                }


                if (firstNumber == 1 && secondNumber == 6 && 5 < lastNumber && lastNumber < 10)
                {
                    result = 200;
                }

                if (firstNumber == 2 && secondNumber == 6 && 5 < lastNumber && lastNumber < 10)
                {
                    result = 300;
                }
                if (firstNumber == 3 && secondNumber == 6 && 5 < lastNumber && lastNumber < 10)
                {
                    result = 400;
                }
                if (firstNumber == 4 && secondNumber == 6 && 5 < lastNumber && lastNumber < 10)
                {
                    result = 500;
                }
                if (firstNumber == 5 && secondNumber == 6 && 5 < lastNumber && lastNumber < 10)
                {
                    result = 600;
                }

                if (firstNumber == 6 && secondNumber == 6 && 5 < lastNumber && lastNumber < 10)
                {
                    result = 700;
                }
            }

        Console.WriteLine(result);
    }
}