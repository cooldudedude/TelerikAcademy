using System;

class NullValue
{
    static void Main()
    {
        int? zero = null;
        double? doublezero = null;

        Console.WriteLine(zero + 150);
        Console.WriteLine(doublezero + 250);
        Console.WriteLine(zero + doublezero);
  
    }
}

