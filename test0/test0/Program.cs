namespace test0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                {
                    Random rand = new Random();//랜덤클래스 메서드

                    int secretNumber1;// 랜덤값을 위해 만들어둔 변수
                    int secretNumber2;// 랜덤값을 위해 만들어둔 변수
                    int secretNumber3;// 랜덤값을 위해 만들어둔 변수

                    int strike1 = 0;
                    int strike2 = 0;
                    int strike3 = 0;

                    int[] Lottery = new int[3];

                    for (int i = 0; i < 3; i++)

                    {

                        secretNumber1 = rand.Next(0, 9);//0~9 사이의 정수를 랜덤으로 결정
                        secretNumber2 = rand.Next(0, 9);//0~9 사이의 정수를 랜덤으로 결정
                        secretNumber3 = rand.Next(0, 9);//0~9 사이의 정수를 랜덤으로 결정




                        for (int j = 0; j <= i; j++) //현재 발생시킨 지점까지 검색해서 같은수 비교

                        {

                            if (secretNumber1 == secretNumber2 && j != i)

                            {

                                i = i - 1; // 같은수 있으면 i하나 감소해서 다시 발생

                            }
                            if (secretNumber2 == secretNumber3 && j != i)

                            {

                                i = i - 1; // 같은수 있으면 i하나 감소해서 다시 발생

                            }
                            if (secretNumber1 == secretNumber3 && j != i)

                            {

                                i = i - 1; // 같은수 있으면 i하나 감소해서 다시 발생

                            }

                        }

                    }





                }

                }

            }
        }
    }
