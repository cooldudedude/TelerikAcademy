using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * radius * Math.PI;
        double area = radius * radius * Math.PI;

        Console.WriteLine("The perimeter of the circle is: {0:F3}", perimeter);
        Console.WriteLine("The area of the circle is: {0:F3}", area);
    }
}
