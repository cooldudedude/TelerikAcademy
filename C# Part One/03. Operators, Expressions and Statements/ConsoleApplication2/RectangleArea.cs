//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("This program calculates a rectangle's area by given width and height");
        Console.Write("Please enter the rectangle's width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Please enter the rectangle's height: ");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("The area of this rectangle is " + (width * height));
    }
}