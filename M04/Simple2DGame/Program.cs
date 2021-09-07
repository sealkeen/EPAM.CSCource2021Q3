﻿using System;
using Simple2DGameLib;

namespace Simple2DGame
{
    class Program
    {
        //Develop a geometric shapes class hierarchy - Circle, Triangle, Square, Rectangle, etc...
        //Classes should describe the properties of a shape and have methods for calculating the area and perimeter of the shape.
        //(A task with an emphasis on building an inheritance hierarchy, without unduly detailed implementation).
        //Create a class hierarchy and implement key methods for a computer game(no functional requirements yet). Game's plot:

        //A player can move within a rectangular field with size Width* Height
        //There are some bonuses on the fiels(apples, cherries, bananas) which could be picked up by a player and give them score points
        //There are some monsters(wolves, bears) hunting the player and move using an algoritm
        //There are some obstacles on the field(stones, trees) which player and monster should avoid
        //The goal is to collect all bonuses and don't be eaten by monsters
        static void Main(string[] args)
        {
            RenderArea renderArea = new RenderArea();
            Rectangle player = new Rectangle( new[,] { 
                { '\\', '0', '/' },
                { ' ', 'O', ' ' },
                { '/', ' ', '\\' } } 
            );
            renderArea.AddElement(player);
            renderArea.Draw(renderArea);
            Console.SetCursorPosition(0, 0);
            var key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape) {
                key = Console.ReadKey();
                switch (key.Key) {
                    case ConsoleKey.RightArrow:
                        renderArea[0].MoveRight(renderArea);
                        break;
                    case ConsoleKey.LeftArrow:
                        renderArea[0].MoveLeft();
                        break;
                    case ConsoleKey.UpArrow:
                        renderArea[0].MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        renderArea[0].MoveDown(renderArea);
                        break;
                }
                Console.Clear();
                renderArea.Draw(renderArea);
                Console.SetCursorPosition(0, 0);
            }

        }
    }
}
