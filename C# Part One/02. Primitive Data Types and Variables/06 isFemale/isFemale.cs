using System;

class isFemale
{
    static void Main()
    {
        bool isFemale;
        Console.Write("What is your sex ? (male/female) ");
        string sex = Console.ReadLine();
        if (sex == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine(isFemale);
    }
}

