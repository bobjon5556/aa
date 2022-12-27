namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int get_directionkey()//방향키를 입력받는 함수
            {
                int key;
                key = _getch();
                if (key == 224)//방향키
                {
                    return _getch(); //어떤 방향 키인지 반환
                }
                return 0;    //방향키가 아님
            }
            void print_puzzle(int puzzle[][3])
{
                int r, c;
                system("cls"); //콘솔 화면을 지우기
                for (r = 0; r < 3; r++)//열 반복
                {
                    for (c = 0; c < 3; c++)//행 반복
                    {
                        if (puzzle[r][c])//참이면(0이 아니면)
                        {
                            printf("%3d", puzzle[r][c]);//퍼즐의 수를 출력
                        }
                        else//거짓(0)이면
                        {
                            printf("   ");//공백 출력
                        }

                    }
                    printf("\n");//개행
                }
            }
            int is_ending(int puzzle[][3])
{
                int r, c;

                for (r = 0; r < 3; r++)//열 반복
                {
                    for (c = 0; c < 3; c++)//행 반복
                    {
                        if (puzzle[r][c] != r * 3 + c + 1)
                        {
                            return (r == 2) && (c == 2);
                        }
                    }
                }
                return 0;
            }
            int main()
            {
                int puzzle[3][3] = { { 1,3,2 },{ 7,8,4 },{ 6,5,0 } };
                int row = 2;
                int col = 2;
                int key = 0;

                while (!is_ending(puzzle))
                {
                    print_puzzle(puzzle);
                    printf(">> 방향키 선택 \n");
                    key = get_directionkey();

                    switch (key)
                    {
                        case RIGHT:
                            if (col > 0)
                            {
                                puzzle[row][col] = puzzle[row][col - 1];
                                puzzle[row][col - 1] = 0;
                                col--;
                            }

                            break;
                        case LEFT:
                            if (col < 3 - 1)
                            {
                                puzzle[row][col] = puzzle[row][col + 1];
                                puzzle[row][col + 1] = 0;
                                col++;
                            }
                            break;
                        case UP:
                            if (row < 3 - 1)
                            {
                                puzzle[row][col] = puzzle[row + 1][col];
                                puzzle[row + 1][col] = 0;
                                row++;
                            }
                            break;
                        case DOWN:
                            if (row > 0)
                            {
                                puzzle[row][col] = puzzle[row - 1][col];
                                puzzle[row - 1][col] = 0;
                                row--;
                            }
                            break;
                    }
                }
                return 0;
            }

      

# 
            typedef struct Puzzle
        {
            char base[3][3];
    int row;
            int col;
        }
        Puzzle;

void print_puzzle(Puzzle* puzzle)
        {
            int r, c;
            system("cls");
            for (r = 0; r < 3; r++)
            {
                for (c = 0; c < 3; c++)
                {
                    if (puzzle->base[r][c])
            {
                printf("%3d", puzzle->base[r][c]);
            }
            else
            {
                printf("   ");
            }
        }
        printf("\n");
    }
}

int is_ending(Puzzle* puzzle)
{
    int r, c;

    for (r = 0; r < 3; r++)
    {
        for (c = 0; c < 3; c++)
        {
            if (puzzle->base[r][c] == r * 3 + c + 1)
            {
    break;
}
        }
    }
    return (r == 2) && (c == 2);
}

void init_puzzle(Puzzle* puzzle)
{
    srand((unsigned)time(0));
    int rvalues[8] = { 1, 2, 3, 4, 5, 6, 7, 8 };
    int rindex;
    for (int i = 0; i < 8; i++)
    {
        while (1)
        {
            rindex = rand() % 8;
            if (rvalues[rindex] != -1)
            {
                break;
            }
        }
        puzzle->base[i / 3][i % 3] = rvalues[rindex];
        rvalues[rindex] = -1;
    }
    puzzle->base[2][2] = 0;
    puzzle->row = 2;
    puzzle->col = 2;
}
int get_directionkey()
{
    int key = 0;
    key = _getch();
    if (key == 224)
    {
        return _getch();
    }
    return 0;
}
void move_puzzle(Puzzle* puzzle)
{
    int key;
    printf(">> 방향키 선택\n");
    key = get_directionkey();

    char(*base)[3] = puzzle->base;
    switch (key)
    {
        case RIGHT:
            if (puzzle->col > 0)
            {
                SWAP(base[puzzle->row][puzzle->col], base[puzzle->row][puzzle->col - 1]);
                puzzle->col--;
            }
            return;
        case LEFT:
            if (puzzle->col < 2)
            {
                SWAP(base[puzzle->row][puzzle->col], base[puzzle->row][puzzle->col + 1]);
                puzzle->col++;
            }
            return;
        case UP:
            if (puzzle->row < 2)
            {
                SWAP(base[puzzle->row][puzzle->col], base[puzzle->row + 1][puzzle->col]);
                puzzle->row++;
            }
            return;
        case DOWN:
            if (puzzle->row > 0)
            {
                SWAP(base[puzzle->row][puzzle->col], base[puzzle->row - 1][puzzle->col]);
                puzzle->row--;
            }
            return;
    }
}
int main()
{
    Puzzle puzzle;
    Puzzle* ppuz = &puzzle;
    init_puzzle(ppuz);
    while (!is_ending(ppuz))
    {
        print_puzzle(ppuz);
        move_puzzle(ppuz);
    }
    print_puzzle(ppuz);

    system("pause");
    return 0;
}
        }

    }
}