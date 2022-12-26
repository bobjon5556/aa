using System;

namespace test6
{
    internal class Program
    {
        public static void SetFeld()
        {

    / 1st Line

    Console.WriteLine("      |       |     ");
            Console.WriteLine("   {0}  |   {1}   |   {2}", 1, 2, 3);
            Console.WriteLine("______|_______|______");

            // 2nd Line
            Console.WriteLine("      |       |     ");
            Console.WriteLine("   {0}  |   {1}   |   {2}", 1, 2, 3);
            Console.WriteLine("______|_______|______");

            // 3rd Line
            Console.WriteLine("      |       |     ");
            Console.WriteLine("   {0}  |   {1}   |   {2}", 1, 2, 3);
            Console.WriteLine("      |       |     ");
        }

        static char[,] playerField =
{
    {'1', '2', '3' },
    {'4', '5', '6' },
    {'7', '8', '9' },
};


        static void Main(string[] args)
        {
            
            Random randommine= new Random();
            const int MINE_PERCETAGE = 30;
            const int BOARD_SIZE_X = 10;
            const int BOARD_SIZE_Y = 10;

            bool is DebugMode = false;
            bool is GameOver=false;
            bool isplayerwin = false;
            int playerTurnCnt = 0;

            /*10 x 10 보드에 지뢰를 초기화 한다.
             * 
             * gameBoard 상태
             * 지뢰:MINE_PERCETAGE 미만의 값
             * 빈칸:MINE_PERCETAGE 이상의 값
             * 
             * playBoard 상태
            -2:지뢰있음
            -1:초기값
            n:주변 9타일 이내의 지뢰수(0일경우 * 표기,양수일 경우 정수 표기)

            minecntmap상태
            -1:지뢰있음
            n:주변 9타일 이내의 지뢰 수
            */

            int[,] gameBoard= new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            int[,] playBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            int[,] mineCntmap = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int y = 0; y < BOARD_SIZE_Y y++)
            {
                for (int(int x = 0; x < BOARD_SIZE_X x++)
                {
                    gameBoard[BOARD_SIZE_Y, BOARD_SIZE_X] = Random.Next(1, 100 + 1);



                }
            
            
            }

            //게임시작
            while (isgameover == false)
                for (int y = 0; y < BOARD_SIZE_Y y++)
                {
                    for (int(int x = 0; x < BOARD_SIZE_X x++)
                    {
                        switch (playerBoard[y, BOARD_SIZE_X])
                        { case -2:
                                Console.Write("x"PadRight(3 ''));
                                break;



                        }

                    }

                }
            int playerX = 0;
            int playerY = 0;
            bool isLocationValid=false;


            while(isLocationValid==false)
            {
                Console.Write("[플레이어] x 좌표 입력:");
                int.TryParse(Console.ReadLine(), out playerX);
                Console.Write("[플레이어] y 좌표 입력:");
                int.TryParse(Console.ReadLine(), out playerY);

                isLocationValid =
                    (0 <= playerX && playerX < BOARD_SIZE_X) &&
                    (0 <= playerY && playerY < BOARD_SIZE_Y);

                if(isLocationValid==false)
                {
                    Console

                }

                playerTurnCnt++;

                if(playerTurnCnt.Equals(1))
                {
                    gameBoard[playerY, playerX] = MINE_PERCETAGE + 1;
                    mineCntmap[playerY, playerX] = 0;
                    playBoard[playerY, playerX] = -1;

                    for(int y=0; y<BOARD_SIZE_Y; y++)
                    {
                        for(int x=0; x<BOARD_SIZE_X; x++)
                        {
                            if (mineCntmap[y,x].Equals(-1)==false) { continue; }

                            bool isSearchTilevalid = false;
                            for(int serchy=y-1; serchy<=y+1; serchy++)
                            {
                                for (int serchy = x - 1; serchy <= x + 1; serchx++)


                            }
                        }

                    }

                }
               


            }




                        
        }




        
    }
                





            
    
}
        

    
