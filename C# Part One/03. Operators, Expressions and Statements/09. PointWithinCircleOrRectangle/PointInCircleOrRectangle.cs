using System;

class PointInCircleOrRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates of the point");
        int pointX = int.Parse(Console.ReadLine());
        int pointY = int.Parse(Console.ReadLine());
       
        double radius = 3;
        double centerX = 1;
        double centerY = 1;

        if ((((pointX - centerX) * (pointX - centerX)) + ((pointY - centerY) * (pointY - centerY)) <= (radius * radius)) &&
            ((pointX >= -1 && pointX <= 5) && (pointY <= 1 && pointX >= -1)))
        {
            Console.WriteLine("The point is within the circle and triangle");
        }
        else
        {
            Console.WriteLine("The point is not within the circle and triangle");
        }
    }
}