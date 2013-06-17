using System;
using System.Text;
class ACII_Table
{
    static void Main()
    {
        for (int i = 0; i < 255; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }


    }
}

