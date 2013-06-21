using System;

class Anacci
{
    static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondletter = char.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        int firstNumber = firstLetter - 64;
        int secondNumber = secondletter - 64;
        int thirdNumber = (firstNumber + secondNumber + 64);
        
        Console.WriteLine(firstLetter);

        Console.Write((char)(secondNumber + 64));
        Console.Write((char) thirdNumber);

        Console.WriteLine();

        thirdNumber = (firstNumber + secondNumber + 64);

        firstNumber = secondNumber;
        secondNumber = (thirdNumber - 64);

        for (int i = 1; i <= lines - 2 ; i++)
        {
            thirdNumber = (firstNumber + secondNumber + 64);

            if (thirdNumber - 64 > 26)
            {
                thirdNumber = (((thirdNumber - 64) % 26) + 64 );
            }

            firstNumber = secondNumber;
            secondNumber = (thirdNumber - 64);

            Console.Write((char)(thirdNumber));
            Console.Write(new string(' ', i));

            thirdNumber = (firstNumber + secondNumber + 64);
            
            if (thirdNumber - 64 > 26)
            {
                thirdNumber = (((thirdNumber - 64) % 26) + 64 );
            }

            firstNumber = secondNumber;
            secondNumber = (thirdNumber - 64);

            Console.Write((char)(thirdNumber));
            Console.WriteLine();
        }
    }
}