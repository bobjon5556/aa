using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace Snake
{
    class Program


    {

        public static void Main()
        {
            Map map = new Map();
            SnakeBody snake = new SnakeBody();
            Control control = new Control();
            Food food = new Food();
            ConsoleKeyInfo command;
            Console.SetWindowSize(110, 60);
            bool loop = true;
            do
            {


                while (Console.KeyAvailable == false)
                {
                    Console.Clear();

                    if (control.CookTime()) food.MakeFood(snake, map);
                    control.PrintMap(snake, map);
                    if (control.MoveSnake(snake, map))
                    {
                        loop = false;
                        break;
                    }
                    Thread.Sleep(150);
                }
                // Loop until input is entered.
                if (!loop) break;
                command = Console.ReadKey(true);
                control.WhereGo(command);

            } while (command.Key != ConsoleKey.Escape);
            Console.Clear();
            Console.Write("주금");
            Console.ReadKey();
        }
    }
}