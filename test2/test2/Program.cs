using Microsoft.VisualBasic;
using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args
            )

        {
            Random rand = new Random();
            int[] v = new int[100];


            for (int i = 0; i < v.Length; i++)
            { v[i] = rand.Next(1, 100); }



            // 최대값
            int max = v[0];
            for (int i = 1; i < v.Length; i++)
                if (v[i] > max)
                    max = v[i];
            Console.WriteLine("최대값: {0}", max);

            int userInputNum = 0;
            int userInputNum1 = 0;
            int userInputNum2 = 0;
            int userInputNum3 = 0;
            int userInputNum4 = 0;


            for (; ; ) // 횟수 제한 없음
            {
                Console.Write("1번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum);
                Console.Write("2번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum1);
                Console.Write("3번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum2);
                Console.Write("4번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum3);
                Console.Write("5번 사람이 먹은 개수 : ");
                int.TryParse(Console.ReadLine(), out userInputNum4);

                int[] fiveman = new int[5] { userInputNum, userInputNum1, userInputNum2, userInputNum3, userInputNum4 };

                if (0 < userInputNum)//0이상의 정수를 입력하면 실행
                {

                    // 최대값
                    int max1 = fiveman[0];
                    for (int i = 1; i < fiveman.Length; i++)
                        if (fiveman[i] > max1)
                        { max1 = fiveman[i]; }

                    Console.WriteLine("최대값: {0}", max1);

                    // 최소값
                    int min1 = fiveman[0];
                    for (int i = 1; i < fiveman.Length; i++)
                        if (fiveman[i] < min1)
                        { min1 = fiveman[i]; }
                    Console.WriteLine("최소값: {0}", min1);


                    //정렬(함수사용)

                    Array.Sort(fiveman);
                    Console.WriteLine(string.Join(", ", fiveman));




                    //함수사용x

                    // 입력
                    int[] data = fiveman;
                    int N = data.Length;

                    //처리: 선택 정렬 알고리즘
                    for (int i = 0; i < N - 1; i++)   //i = 0 to N - 1
                    {
                        for (int j = i + 1; j < N; j++)  //j = i + 1 to N
                        {
                            if (data[i] > data[j])       //부등호 방향: 오름차순(>), 내림차순(<)
                            {
                                int temp = data[i]; data[i] = data[j]; data[j] = temp; //SWAP
                            }
                        }
                    }


                    for (int i = 0; i < N; i++)
                    {
                        Console.Write($"{data[i]}\t");
                    }
                    Console.WriteLine();



                    //난수 데이터

                    int[] fiveman1 = new int[5] { userInputNum, userInputNum1, userInputNum2, userInputNum3, userInputNum4 };

                    int[] qq = new int[20];


                    for (int i = 0; i < qq.Length; i++)
                    {
                        int Na = qq.Length;

                        bool[] selected = Enumerable.Repeat<bool>(false, Na).ToArray<bool>();
                        int selectedCnt = 0;

                        while (selectedCnt < Na)
                        {
                            int a = rand.Next(0, Na); // 1에서 N-1까지
                            while (selected[a] == true)
                            {
                                a = (a + 1) % Na;
                            }

                            Console.Write($"{a} ");
                            selected[a] = true;
                            selectedCnt++;
                        }
                    }


                    // 최대값
                    int[] data1 = qq;
                    int ee= data1.Length;


                    //처리: 선택 정렬 알고리즘
                    for (int i = 0; i < ee - 2; i++)   //i = 0 to N - 1
                    {
                        for (int j = i + 2; j < ee; j++)  //j = i + 1 to N
                        {
                            if (data1[i] > data1[j])       //부등호 방향: 오름차순(>), 내림차순(<)
                            {
                                int temp = data1[i]; data1[i] = data1[j]; data1[j] = temp; //SWAP
                            }
                        }
                    }

                    


                    for (int i = 0; i < ee; i++)
                    {
                        Console.Write($"{data1[i]}\t");
                    }
                    Console.WriteLine();


                    break;
                
                }
                else
            
                Console.WriteLine("잘못 입력하셨습니다.");//문자열 입력시 프로그램 종료
                break;

            }
        }

     }
}
