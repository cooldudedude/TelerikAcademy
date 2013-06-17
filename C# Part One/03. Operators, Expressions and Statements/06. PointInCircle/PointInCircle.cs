using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates for the point:");
        int strX = int.Parse(Console.ReadLine());
        int strY = int.Parse(Console.ReadLine());
     
        int radius = 5;

        if ((strX * strX + strY * strY) <= radius * radius)
        {
            Console.WriteLine("The point is within the Circle");
        }
        else
        {
            Console.WriteLine("The point is not within the Circle");
        }
    }
}