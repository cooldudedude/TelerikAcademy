//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Trapezoid's area = ½(a+b) × h

using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("To calculate the area of your Trapezoid, enter its sides and height");
        Console.Write("Enter the first side ");
        float sideA = float.Parse(Console.ReadLine());
        Console.Write("Enter the second side ");
        float sideB = float.Parse(Console.ReadLine());
        Console.Write("Enter the height of the Trapezoid ");
        float height = float.Parse(Console.ReadLine());

        float area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area of the trapezoid is " + area);
    }
}

