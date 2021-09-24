using System;
using System.Collections.Generic;
using System.Text;
using ShapeLib;

namespace Simple2DGameLib
{
    public class Game
    {
        public Game()
        {
            var renderArea = new RenderArea();
            var player = new Player((new[,]
                {
                    { ' ', '0', ' ' },
                    { '/',  'O', '\\' },
                    { ')',  'H', '(' }
                })
            );
            
            renderArea.AddElement(player);
            renderArea.Draw();
            Console.SetCursorPosition(0, 0);

            var key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        renderArea[0].MoveRight(renderArea);
                        break;
                    case ConsoleKey.LeftArrow:
                        renderArea[0].MoveLeft(renderArea);
                        break;
                    case ConsoleKey.UpArrow:
                        renderArea[0].MoveUp(renderArea);
                        break;
                    case ConsoleKey.DownArrow:
                        renderArea[0].MoveDown(renderArea);
                        break;
                }
                Console.Clear();
                renderArea.Draw();
                Console.SetCursorPosition(0, 0);
            }
        }
    }
}
