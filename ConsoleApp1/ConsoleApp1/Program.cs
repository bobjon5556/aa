using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Task
    {
        /**
         * 5x5 보드 ( 사이즈 줘도 ok)
         * 빈 곳 중에 아무곳이나 사람( 이모티콘 또는 옷)을 초기화해서
         * w, a, s, d 입력 받아서 빈 곳을 자유롭게 이동하는 프로그램 작성.
         * - 조건 사람은 빈 곳을 다닐 수 있음
         */

        static int FIELDMAX_X = 3;                                     // 화면 최대 크기 X
        static int FIELDMAX_Y = 3;                                     // 화면 최대 크기 Y
        static string[,] field = new string[FIELDMAX_X, FIELDMAX_Y];    // 화면 출력 내용을 담을 배열
        static int playerX = 2;                                         // 플레이어 좌표  X
        static int playerY = 2;                                         // 플레이어 좌표  Y

        static ConsoleKeyInfo Input;                                        // 유저 키입력을 받을 변수
        static bool Escape = false;                                     // 유저 키입력중 Escape를 누를 시 true바뀌는 bool변수

        static void Main(string[] args)
        {
            fieldInit();                                                // 배열 초기화 함수
            while (!Escape)                                             // Escape Bool 값이 false면 반복
            {
                fieldDraw();                                            // 배열에 담긴 내용 그리는 함수 
                move();                                                 // player의 좌표값을 변경하는 함수
                Console.Clear();                                        // 화면 초기화 함수
            }

        }

        static ConsoleKey getInput()                                    // 유저 입력을 받을 함수
        {
            Input = Console.ReadKey(true);
            return Input.Key;                                           // 저장받은 ConsoleKey 값을 반환
        }
        static void fieldInit()                                         // 배열 초기화 함수                   
        {

            for (int y = 0; y < FIELDMAX_Y; y++)
            {
                for (int x = 0; x < FIELDMAX_X; x++)
                {
                    if (y.Equals(0)                                     // y값이 0 이라면
                        || y.Equals(FIELDMAX_Y - 1)                     // y값이 최대 값이라면
                        || x.Equals(0)                                  // x값이 0 이라면
                        || x.Equals(FIELDMAX_X - 1))                    // x값이 최대 값이라면
                    {
                        field[y, x] = "■";                              // ■ 대입
                    }
                    else
                    {
                        field[y, x] = ". ";                             // 아니라면 . 대입
                    }
                }
            }
        }
        static void fieldDraw()                                         // 배열에 담긴 내용 그리는 함수
        {
            for (int y = 0; y < FIELDMAX_Y; y++)
            {
                for (int x = 0; x < FIELDMAX_X; x++)
                {
                    if (playerX.Equals(x) && playerY.Equals(y))         // 반복문 index의 값이 플레이어의 좌표라면 배열에 담긴 값 대신 플레이어 출력
                    {
                        Console.Write("♥");
                    }
                    else
                    {
                        Console.Write($"{field[y, x]}");
                    }

                }
                Console.WriteLine();
            }
        }
        static void move()                                              // player의 좌표값을 변경하는 함수
        {
            switch (getInput())
            {
                case ConsoleKey.W:
                    if (playerY < 2)
                    {
                        break;
                    }
                    else
                    {
                        playerY--;
                    }
                    break;
                case ConsoleKey.S:
                    if (FIELDMAX_Y - 2 <= playerY)
                    {
                        break;
                    }
                    else
                    {
                        playerY++;
                    }
                    break;
                case ConsoleKey.A:
                    if (playerX < 2)
                    {
                        break;
                    }
                    else
                    {
                        playerX--;
                    }
                    break;
                case ConsoleKey.D:
                    if (FIELDMAX_X - 2 <= playerX)
                    {
                        break;
                    }
                    else
                    {
                        playerX++;
                    }
                    break;
                case ConsoleKey.Escape:
                    Escape = true;
                    break;
                default:
                    break;

            }
        }
    }
}
