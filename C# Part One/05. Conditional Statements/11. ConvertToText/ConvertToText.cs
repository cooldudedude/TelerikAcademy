using System;

class ConvertToText
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int thirdNumber = 0;

        string firstWord = "";
        string secondWord = "";
        string thirdWord = "";

        Console.Write("Enter your number (it must be between 0 and 999): ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10)
        {
            firstNumber = number;

            switch (firstNumber)
            {
                case 1:
                    firstWord = "One";
                    break;
                case 2:
                    firstWord = "Two";
                    break;
                case 3:
                    firstWord = "Three";
                    break;
                case 4:
                    firstWord = "Four";
                    break;
                case 5:
                    firstWord = "Five";
                    break;
                case 6:
                    firstWord = "Six";
                    break;
                case 7:
                    firstWord = "Seven";
                    break;
                case 8:
                    firstWord = "Eight";
                    break;
                case 9:
                    firstWord = "Nine";
                    break;
                default:
                    firstWord = "";
                    break;
            }
        }
        else if (number > 9 && number < 20)
        {
            switch (number)
            {
                case 10:
                    firstWord = "Ten";
                    break;
                case 11:
                    firstWord = "Eleven";
                    break;
                case 12:
                    firstWord = "Twelve";
                    break;
                case 13:
                    firstWord = "Thirteen";
                    break;
                case 14:
                    firstWord = "Fourteen";
                    break;
                case 15:
                    firstWord = "Fifteen";
                    break;
                case 16:
                    firstWord = "Sixteen";
                    break;
                case 17:
                    firstWord = "Seventeen";
                    break;
                case 18:
                    firstWord = "Eighteen";
                    break;
                case 19:
                    firstWord = "Ninteen";
                    break;
            }
        }

        else if (number > 19 && number < 100)
        {
            firstNumber = (number % 100) / 10;
            secondNumber = (number % 10);

            switch (firstNumber)
            {
                case 2:
                    firstWord = "twenty";
                    break;
                case 3:
                    firstWord = "thirty";
                    break;
                case 4:
                    firstWord = "fourty";
                    break;
                case 5:
                    firstWord = "fifty";
                    break;
                case 6:
                    firstWord = "sixty";
                    break;
                case 7:
                    firstWord = "seventy";
                    break;
                case 8:
                    firstWord = "eighty";
                    break;
                case 9:
                    firstWord = "ninty";
                    break;
                default:
                    firstWord = "";
                    break;
            }

            switch (secondNumber)
            {
                case 1:
                    thirdWord = "one";
                    break;
                case 2:
                    thirdWord = "two";
                    break;
                case 3:
                    thirdWord = "three";
                    break;
                case 4:
                    thirdWord = "four";
                    break;
                case 5:
                    thirdWord = "five";
                    break;
                case 6:
                    thirdWord = "six";
                    break;
                case 7:
                    thirdWord = "seven";
                    break;
                case 8:
                    thirdWord = "eight";
                    break;
                case 9:
                    thirdWord = "nine";
                    break;
                default:
                    thirdWord = "";
                    break;

            }
        }
        else if (number >= 100)
        {
            firstNumber = ((number % 1000) / 100);
            secondNumber = (number % 100) / 10;
            thirdNumber = (number % 10);

            switch (firstNumber)
            {
                case 1:
                    firstWord = "One hundred";
                    break;
                case 2:
                    firstWord = "Two hundred";
                    break;
                case 3:
                    firstWord = "Three hundred";
                    break;
                case 4:
                    firstWord = "Four hundred";
                    break;
                case 5:
                    firstWord = "Five hundred";
                    break;
                case 6:
                    firstWord = "Six hundred";
                    break;
                case 7:
                    firstWord = "Seven hundred";
                    break;
                case 8:
                    firstWord = "Eight hundred";
                    break;
                case 9:
                    firstWord = "Nine hundred";
                    break;
                default:
                    firstWord = "";
                    break;
            }

            switch (secondNumber)
            {
                case 0:
                    secondWord = null;
                    break;
                case 1:
                    secondWord = "";
                    break;
                case 2:
                    secondWord = "twenty";
                    break;
                case 3:
                    secondWord = "thirty";
                    break;
                case 4:
                    secondWord = "fourty";
                    break;
                case 5:
                    secondWord = "fifty";
                    break;
                case 6:
                    secondWord = "sixty";
                    break;
                case 7:
                    secondWord = "seventy";
                    break;
                case 8:
                    secondWord = "eighty";
                    break;
                case 9:
                    secondWord = "ninty";
                    break;
            }

            switch (thirdNumber)
            {
                case 1:
                    thirdWord = "one";
                    break;
                case 2:
                    thirdWord = "two";
                    break;
                case 3:
                    thirdWord = "three";
                    break;
                case 4:
                    thirdWord = "four";
                    break;
                case 5:
                    thirdWord = "five";
                    break;
                case 6:
                    thirdWord = "six";
                    break;
                case 7:
                    thirdWord = "seven";
                    break;
                case 8:
                    thirdWord = "eight";
                    break;
                case 9:
                    thirdWord = "nine";
                    break;
                default:
                    thirdWord = "";
                    break;
            }

            if (secondNumber == 0 && (number != 100 && number != 200 && number != 300 && number != 400 && number != 500 && number != 600 &&
                                      number != 700 && number != 800 && number != 900))          
            {
                firstWord = firstWord + " and";
            }
            
        }
        
        if (number > 1000)
        {
            Console.WriteLine("Wrong input");
        }


        Console.WriteLine("{0} {1}{2}", firstWord, secondWord, thirdWord);
    }
}