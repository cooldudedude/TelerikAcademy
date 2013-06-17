using System;
using System.Text;

class Copyright
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string copyright = "\u00a9";
        Console.WriteLine("  " + copyright);
        Console.WriteLine(" " + copyright + copyright + copyright);
        Console.WriteLine(copyright + copyright + copyright + copyright + copyright);
    }
}

