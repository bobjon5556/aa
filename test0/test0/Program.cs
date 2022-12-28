using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Program1
    {
        static char Image;


        private void IntializeCardOpened()
        {
            for (int i = 0; i <= 52; i++)
                cardOpened[i] = false;
        }

        // [4, 13]으로 grid를 나눔
        private void CardSlot()
        {
            for (int i = 0; i < 4; i++)
            {
                RowDefinition row = new RowDefinition();
                board.RowDefinitions.Add(row);
            }
            for (int i = 0; i < 13; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                board.ColumnDefinitions.Add(col);
            }
        }

        // card를 random 하게 배치
        private void RandomCards()
        {
            int[] flag = new int[53];
            Random r = new Random();

            for (int row = 0; row < 4; row++)
                for (int col = 0; col < 13; col++)
                {
                    int n = r.Next(1, 53);
                    while (flag[n] != 0)
                        n = r.Next(1, 53);
                    flag[n] = 1;
                    cards[row, col] = n;
                }
        }

        // 전체 카드를 그려줌
        private void DrawBoard()
        {
            for (int row = 0; row < 4; row++)
                for (int col = 0; col < 13; col++)
                {
                    DrawCard(row, col, cards[row, col], cardOpened[cards[row, col]]);
                }
        }
        static void Main()
        {
            IntializeCardOpened();      // 카드를 모드 hidden으로 표시 
            CardSlot();                      // grid를 [4,13] 으로 나누어 줌
            RandomCards();              // 카드를 랜덤하게 위치시킴
            DrawBoard();                  // 카드를 그려줌
        }
            


       

    }
}

