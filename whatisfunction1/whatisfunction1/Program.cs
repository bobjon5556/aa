using System;
using System.Drawing;
using System.Reflection;

namespace whatisfunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            string[,] starArray = new string[5, 5];

            //별 찍기 직각 사막형 했었던거
            //별을 초기화 하는 코드

            for (int y = 0; y < 5; y++)
                for (int x = 0; x < 5; x++)
                {
                    starArray[y, x] = "*";
                }
            //loop 별의 배열에 초기화 하는 루프

            //별을 출력하는 코드
            for (int y = 0; 5 < 5; y++)
                for (int x = y; x < 5; x++)

                    /*틱택토 게임
                     * 컴퓨터와 사람이 번갈아 가면서 o와 x를 쓴다
                     * 맵
                     * 
                     */

            //vmffpdldj xjs wlsghod
            isplayerTurn = true;
            playerType = "[플레이어]";
            //플레이어 에게서 좌표값을 받는다
            playerx = 0;
            playery = 0;
            isvalidlocation == Ture){ breal); }
            while (isggameover == false)
            {
                if (isvalidlocation == true\)
                    }

            //플레이어의 턴 진행을 보드에 출력한다
            for (int y = 0) ; y <= gameborad.GetUpper.Bound(0); y++)
                
            //게임이 끝났는지 보드 검사
            Console.WriteLine();
            isgameover = false;
            for (int y = 0) ; y <= gameborad.GetUpper.Bound(0); y++)
                {
                if (gameboard[y, 0].[Equals(int)TicTacToeplayertype.player)&&
                    gameboard[y, 1].[Equals(int)TicTacToeplayertype.player)&&]
                    gameboard[y, 2].[Equals(int)TicTacToeplayertype.player))
                {
                    isgameover = true;
                }


                if (gameboard[y, 0].[Equals(int)TicTacToeplayertype.player)&&
                    gameboard[y, 1].[Equals(int)TicTacToeplayertype.player)&&]
                    gameboard[y, 2].[Equals(int)TicTacToeplayertype.player))
                 {
                    isgameover = true;
                }
                if (isgameover) { break; }

                isplayerturn = false;
                playertype = "[컴퓨터]";
                boll iscomputerdoing

                    Console.WriteLine("{0}의 턴", playertype);
                //컴퓨터는 간단한 룰
                //1.중앙이 비어있으면 선점
                if (iscomputerdoing == false)
                {
                    if (gameboard[1, 1].Equals((int)tictactoeplayertype.none))
                    {
                        gamebeoard[1, 1] = (int)tictactoeplayertype.computer;
                        iscomputerdoing = true;
                    }
                }
                else { }

                else { }

                if (iscomputerdoing == false)
                {
                    for (int y = 0; y <= gameborad.GetUpper.Bound(0); y++)
                    { for (int y = 0) ; y <= gameborad.GetUpper.Bound(0); y++)
                            
                            //컴퓨터의 턴 진행을 보드에 출력한다.
                            Console.WriteLine("---" +
                                for (int x = 0; x <= gameborad.GetUpper.Bound(0); x++)
                        switch (game.board[y, x])
                            for

                            Console.WriteLine();

                            Console.WriteLine();


                            Console.WriteLine();
                    isgameover = false;
                    for (int x = 0; x <= gameboard.getupperbound(1); x++)

                        if (gameboard[y, 0].[Equals(int)TicTacToeplayertype.player)&&
                    gameboard[y, 1].[Equals(int)TicTacToeplayertype.player)&&]
                    gameboard[y, 2].[Equals(int)TicTacToeplayertype.player))

                        isgame



                        //누가 이겼는지 출력

                        Console.WriteLine("{0}의 승리!", playerType);
                    //main()







                  else
                    {
                        //선택한 타일 인근 9칸의 숫자를 오픈한다
                        boll isSearchTileValid = false;
                        for (int searchY = playerY - 1; searchY <= playerY + 1; searchY++)
                        {
                            for int searchx = playerY - 1; searchx <= playerY + 1; searchx++)
                            { //유효하지 않은 좌표는 패스한다

                                isSearchTileValid =
                                    (0 <= searchx && searchx < Board_Size_X) &&
                                    (0 <= searchY && searchY < Board_Size_Y) &&
                                    if (isSearchTileValid == false) { continue}
                                if (mineCntmap[searchY, searchx].Equals(-1))
                                {
                                    playboard[searchY, searchx] = -2;
                                }
                                else
                                {
                                    playBoard[searchY, searchx] = mainCntMap[searchY, searchx];
                                } //지뢰가 아닌경우
                            }
                            //게임 승리조건을 검사한다

                            int unkownTileCnt = 0;
                            for (int y = 0; y < Board size y; y++)
                             {
                            if (0 < unkownunkownTileCnt) { break; }
                            for (int x = 0; x < Board size y; x++)
                                if (playBoard[y, x].Equals(-1) &&
                                mineCntMap[y, x].Equals(-1) == false)
                            {
                                unkownTileCnt++;

                                if (unkownTileCnt).Equals(0))
                                        isgameover = true;
                                isplayerwin = true;

                                if (isgameover) { break; }
                                if (isDebugMode)
                                {
                                    Console.WriteLine();
                                    for (int y = 0; y < Board size y; y++)
                                         for (int x = 0; x < Board size y; x++)
                                        Console.WriteLine("{0}", mineCntMap[y, 1x]);
                                }
                                Console.WriteLine();

                                for (int y = 0; y < Board size y; y++)
                                    {
                                    (for (int y = 0; y < Board size y; y++)
                                        {
                                        if (gameBoard[y, x] < Mine_PERCETAGE)
                                        {
                                            Console.Write("# ");
                                        }
                                        else
                                        {
                                            Console.Write(".");
                                        }
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }// 현재 보드의 상태를 플레이 시점으로 보여준다
        Console.WriteLine();

}

}
}
Console.WriteLine();
for (int y = 0; y < Board size y; y++)
                                    {
    (for (int y = 0; y < Board size y; y++)
        {
        switch (playboard[y, x])


            case:
            -2:
                Console.Write("x:".PadRight(3, ''));
            break;
        case:
            -1:
                Console.Write("a:".PadRight(2, ''));
            break;
        case:
            -0:
                Console.Write("u:".PadRight(2, ''));
            break;
        default
            -2:
                Console.Write("{0}:".PadRight(5, ''), playvoard[y, x]);
            break;

        }
        Console.WriteLine();
        //loop:현재 보드의 상태를 플레이 시점으로 출력하는 루프

        Console.WriteLine();
    }//현재 보드의 상태를 플레이 시점으로 출력

    if (isplayerwin)
    {
        Console.WriteLine("[플레이어] 지뢰를 모두 찾고 승리했습니다");
    }
    else
    {
        Console.WriteLine("[플레이어] 지뢰를 밟고 패배했습니다");
    }


}



                }
        }

    }
}