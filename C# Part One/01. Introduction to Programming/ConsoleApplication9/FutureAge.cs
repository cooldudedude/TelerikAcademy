using System;

class FutureAge
{
    static void Main()
    {
        Console.WriteLine("What is your age ?");
        int FutureAge = Convert.ToInt16(Console.ReadLine());
        Console.Write("Your age in 10 years will be ");
        Console.Write(FutureAge+10);
        Console.WriteLine(" years");
    }
}
