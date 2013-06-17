using System;
using System.Threading;
using System.Globalization;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Menu: \n Press 1 for int \n Press 2 for double \n Press 3 for string");

        byte menu = byte.Parse(Console.ReadLine());

        switch (menu)
        {
            case 1:
                Console.Write("Enter input: ");
                int inputInt = int.Parse(Console.ReadLine());

                Console.WriteLine("New input is {0}", (inputInt +1));
                break;
            case 2:
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

                Console.Write("Enter input: ");
                double inputDouble = double.Parse(Console.ReadLine());
                inputDouble = inputDouble + 1;
                Console.WriteLine("New input is {0}", inputDouble);
                break;
            case 3:
                Console.Write("Enter input: ");
                string inputString = Console.ReadLine();

                Console.WriteLine("New input is {0}", inputString + "*");
                break;
            default:
                Console.WriteLine("Wrong input...");
                break;
        }
    }
}
