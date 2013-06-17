using System;

class Square
{
    static void Main()
    {
        double square = Math.Pow(12345, 2); //Принципно, тъй като .pow е много бавна функция, е по-удачно да ги умножим square*square...
        Console.WriteLine(square);
    }
}
