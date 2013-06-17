using System;

class HelloWorld
{
    static void Main()
    {
        string hello = "Hello ";
        string world = "World";
        object helloworld = hello + world;
        
        string hi = (string)helloworld;
        Console.WriteLine(hi);
    }
}

