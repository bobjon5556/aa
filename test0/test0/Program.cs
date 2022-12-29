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
        static int[] cardSet = new int[52];

        private void IntializeCardOpened()
        {
            for (int i = 0; i <= 52; i++)
                
                cardOpened[i] = false;
        }

        // [4, 13]으로 grid를 나눔
        
        private int[] trumpCardSet;//내가 사용할 카드세트
        private string[] trumpCardMark;//트럼프카드 마크
        public void SetupTrumpCards()
        {
            trumpCardSet = new int[52];
            for (int i = 0; i < trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i + 1;
                Console.Write("{0}", trumpCardSet[i]);
                //ioop 카드를 셋업하는 루프
                //Setuptrumpcard()
            }
            trumpCardMark = new string[4] { "♥", "♠", "◈", "♣" };
        }
        private void CardSlot()
        {
            for (int i = 0; i < 4; i++)
            {
                int row = new RowDefinition[i];
                board.RowDefinitions.Add(row);
            }
            for (int i = 0; i < 13; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                board.ColumnDefinitions.Add(col);
            }
        }
        //셔플
        public void Suffle()
        {
            for (int i = 0; i < 100; i++)
            {
                int A = 0;
                int B = 0;
                int temp;

                Random rand = new Random();

                A = rand.Next(0, 52);
                B = rand.Next(0, 52);



                temp = cardSet[A];
                cardSet[A] = cardSet[B];
                cardSet[B] = temp;
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

