using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace snake
{
    //■▣▦▧▤□
    class Program
    {
        static public int gameover = 0;
        static public int foodeat = 0;
        static public int waitspeed = 200;
        static public int foodvalue = 0;
        static public int reset = 1;
        static public List<int> px = new List<int> { };
        static public List<int> py = new List<int> { };
        static public int[] foodposition = new int[] { 0, 0 };
        static public int nail = 5;
        static void Main(string[] args)
        {
            cursorposition cursor = new cursorposition();
            makemap makemap = new makemap();
            setting setting = new setting();
            food food = new food();
            while (true)
            {

                setting.hidecursor();
                if (gameover == 0)
                {
                    if (reset == 1)
                    {
                        Console.SetCursorPosition(0, 0);
                        makemap.makemapstart();
                        setting.hidecursor();
                        reset = 0;
                    }
                    Thread.Sleep(waitspeed);
                    if (Console.KeyAvailable)
                    {
                        cursor.keydown();
                    }
                    px.Add(cursor.x);
                    py.Add(cursor.y);
                    if (px.Count > nail)
                    {
                        Console.SetCursorPosition(px[0], py[0]);
                        Console.Write("  ");
                        px.Remove(px[0]);
                        py.Remove(py[0]);
                    }

                    if (Console.KeyAvailable)
                    {
                        cursor.keydown();
                    }
                    if (px[px.Count - 1] >= 56)
                    {
                        if (cursor.rotation == "R")
                        {
                            gameover = 1;
                        }
                    }
                    if (px[px.Count - 1] < 4)
                    {
                        if (cursor.rotation == "L")
                        {
                            gameover = 1;
                        }
                    }
                    if (py[py.Count - 1] >= 19)
                    {
                        if (cursor.rotation == "D")
                        {
                            gameover = 1;
                        }
                    }
                    if (py[py.Count - 1] < 3)
                    {
                        if (cursor.rotation == "U")
                        {
                            gameover = 1;
                        }
                    }

                    if (gameover == 0)
                    {
                        for (int i = 0; i < px.Count - 1; ++i)
                        {
                            if (foodposition[0] * 2 == px[i] && foodposition[1] == py[i])
                            {
                                foodvalue = 1;
                            }
                            else
                            {
                                foodvalue = 0;
                            }
                        }
                        if (foodeat == 1)
                        {
                            if (foodvalue == 0)
                            {
                                Console.SetCursorPosition(foodposition[0] * 2, foodposition[1]);
                                Console.Write("◎");
                            }
                        }
                        if (foodeat == 0)
                        {
                            if (foodvalue == 0)
                            {
                                food.makefood();
                                foodposition[0] = food.foodpositionx;
                                foodposition[1] = food.foodpositiony;
                                foodeat = 1;
                            }
                        }
                        for (int i = 0; i < px.Count - 2; ++i)
                        {
                            if (px[px.Count - 1] == px[i] && py[py.Count - 1] == py[i])
                            {
                                //Console.Write("p");
                                gameover = 1;
                            }
                        }
                        cursor.drawplayer();
                        Console.SetCursorPosition(0, 0);
                        if (px[px.Count - 1] == foodposition[0] * 2 && py[py.Count - 1] == foodposition[1])
                        {
                            foodeat = 0;
                            if (-100 < waitspeed)
                            {
                                waitspeed -= 3;
                            }
                            nail += 1;
                        }
                    }
                }
                if (gameover == 1)
                {
                    gameovermap gameovermap = new gameovermap();
                    gameovermap.make();
                    while (gameover == 1)
                    {
                        if (Console.KeyAvailable)
                        {

                            cursor.keydown();
                        }
                    }
                }
            }
        }
    }
    class setting
    {
        public bool cursor = false;
        public void hidecursor()
        {
            Console.CursorVisible = cursor;
        }
    }
    class makemap
    {
        public int mapHeight = 40;
        public int mapWidth = 20;
        public void makemapstart()
        {
            Console.WriteLine("");
            for (int h = 0; h < 20; ++h)
            {
                for (int w = 0; w < 30; ++w)
                {
                    if (h == 0 || h == 19)
                    {
                        Console.Write("▣");
                    }
                    else if (w == 0 || w == 29)
                    {
                        Console.Write("▣");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
    class cursorposition : Program
    {
        public string rotation = "U";
        public int x = 30;
        public int y = 10;
        public void keydown()
        {
            if (gameover == 0)
            {
                ConsoleKeyInfo ki;
                ki = Console.ReadKey(true);
                switch (ki.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (rotation != "L")
                        {
                            rotation = "R";
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (rotation != "R")
                        {
                            rotation = "L";
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (rotation != "D")
                        {
                            rotation = "U";
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (rotation != "U")
                        {
                            rotation = "D";
                        }
                        break;
                }
            }
            else if (gameover == 1)
            {
                ConsoleKeyInfo ki;
                ki = Console.ReadKey(true);
                switch (ki.Key)
                {
                    case ConsoleKey.Spacebar:
                        gameover = 0;
                        reset = 1;
                        ////////////////////
                        nail = 5;
                        foodeat = 0;
                        waitspeed = 200;
                        foodvalue = 0;
                        int[] foodposition = new int[] { 0, 0 };
                        List<int> px = new List<int> { };
                        List<int> py = new List<int> { };
                        rotation = "U";
                        x = 30;
                        y = 10;
                        break;
                }
            }
        }
        public void drawplayer()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▩");
            if (rotation == "R")
            {
                x += 2;
            }
            if (rotation == "L")
            {
                x -= 2;
            }
            if (rotation == "U")
            {
                y -= 1;
            }
            if (rotation == "D")
            {
                y += 1;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("▩");
        }

    }
    class food : Program
    {
        public int foodpositionx;
        public int foodpositiony;
        private int breakwhile = 1;
        Random Rx = new Random();
        Random Ry = new Random();
        public void makefood()
        {
            foodpositionx = Rx.Next(1, 29);
            foodpositiony = Ry.Next(2, 20);
            breakwhile = 1;
            while (breakwhile == 1)
            {
                if (px.Contains(foodpositionx * 2) && py.Contains(foodpositiony))
                {
                    foodpositionx = Rx.Next(1, 29);
                    foodpositiony = Ry.Next(2, 20);
                    breakwhile = 1;
                }
                else
                {
                    Console.SetCursorPosition(foodpositionx * 2, foodpositiony);
                    Console.Write("◎");
                    breakwhile = 0;
                }
            }
        }
    }
    class gameovermap : Program
    {
        public void make()
        {
            Console.SetCursorPosition(0, 1);
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n"); //60, 20
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.SetCursorPosition(25, 5);
            Console.Write("Game over");
            Console.SetCursorPosition(0, 20);
            Console.Write("score:" + nail);
            Console.SetCursorPosition(18, 12);
            Console.Write("- Press the spacebar -");
        }
    }
}