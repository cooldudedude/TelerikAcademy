using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter 'a' ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter 'b' ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter 'c' ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0:F2}", root1);
            Console.WriteLine("x2 = {0:F2}", root2);
        }
        else if (discriminant == 0)
        {
            double root = (-b) / 2 * a;
            Console.WriteLine("The discriminant = 0. Therefore there is only one root");
            Console.WriteLine("x = {0:3F2}", root);
        }
        else
        {
            Console.WriteLine("This equation has no roots");
        }
    }
}