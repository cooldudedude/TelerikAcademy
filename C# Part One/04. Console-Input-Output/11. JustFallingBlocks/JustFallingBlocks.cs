using System;
using System.Threading;
using System.Collections.Generic;

class JustFallingBlocks
{
    struct Dwarf
    {
        public int positionX;
        public int positionY;
        public string form;
    }

    struct Spawn
    {
        public int positionX;
        public int positionY;
        public char form;
    }

    static void Main()
    {
        //sets thw window
        Console.SetWindowSize(70, 40);                     
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;

        //Rocks
        char[] array = new char[] { '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        Random rand = new Random();                  

        List<Spawn> fallingRocks = new List<Spawn>(); 

        //The Dwarf
        Dwarf dwarf = new Dwarf();
        dwarf.positionX = Console.WindowWidth / 2;
        dwarf.positionY = Console.WindowHeight - 2; 
        dwarf.form = "@";

        //Game Engine
        bool runGame = true;
        while (runGame)                                       
        {
            Console.Clear();                                
            Console.SetCursorPosition(dwarf.positionX, dwarf.positionY); 
            Console.Write(dwarf.form);

            if (Console.KeyAvailable)
            {
                
                ConsoleKeyInfo controls = Console.ReadKey();
                if (controls.Key == ConsoleKey.LeftArrow && dwarf.positionX > 0)                              
                {
                    dwarf.positionX--;
                }

                if (controls.Key == ConsoleKey.RightArrow && dwarf.positionX < (Console.WindowWidth - dwarf.form.Length))
                {
                    dwarf.positionX++;
                }
            } 
             
            //Spawns rocks
            Spawn rock = new Spawn();
            rock.form = array[rand.Next(0, array.Length)]; 
            
            rock.positionY = 0;
            rock.positionX = rand.Next(0, Console.WindowWidth);

            fallingRocks.Add(rock);

            //The falling of the rocks
            List<Spawn> updatedFallingRocks = new List<Spawn>();
            for (int i = 0; i < fallingRocks.Count; i++)
            {
                Spawn currentSpawn = new Spawn();
                currentSpawn.form = fallingRocks[i].form;
                currentSpawn.positionX = fallingRocks[i].positionX;
                currentSpawn.positionY = fallingRocks[i].positionY + 1;

                if (currentSpawn.positionY < Console.WindowHeight - 1)
                {
                    updatedFallingRocks.Add(currentSpawn);                
                }
                
            }

            fallingRocks = updatedFallingRocks;

            // Draws the rocks
            for (int i = 0; i < fallingRocks.Count; i++)  
            {
                Console.SetCursorPosition(fallingRocks[i].positionX, fallingRocks[i].positionY);
                Console.Write(fallingRocks[i].form);
            }

            //Collision detection system
            for (int i = 0; i < fallingRocks.Count; i++)
            {
                if (fallingRocks[i].positionX == dwarf.positionX && dwarf.positionY == fallingRocks[i].positionY)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("You were hit!!!");
                    Console.WriteLine("GAME OVER!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                    runGame = false;
                    break;
                }
            }

            Thread.Sleep(150);
        }
    }
}