namespace _2022_12_23_과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Hello, World!");

                //1.사용자로 부터 2개의 문자열을 읽어서 비교

                Console.WriteLine("첫번째 문자를 입력하세요");
                string input1 = Console.ReadLine();

                Console.WriteLine("두번째 문자를 입력하세요");
                string input2 = Console.ReadLine();


                if (input1 != input2)
                { Console.WriteLine("일치 하지 않습니다."); }

                if (input1 == input2)
                { Console.WriteLine("동일한 문자입니다."); }

            }

            //2.5개의 음료를 판매하는 자판기 머신을 구현해보기

            Console.WriteLine("좋아하시는 음료와 번호를 선택하세요.");
           
            Console.WriteLine("1번:콜라,2번:물,3번:스프라이트, 4번:주스, 5번:커피");
            
            string input3 = Console.ReadLine();
            int choice = Convert.ToInt32(input3);

            for (; ; )
            {
                if (choice <= 5)
                {
                    switch (input3)
                    {
                        case "1":
                            Console.WriteLine("콜라입니다");
                            break;
                        case "2":
                            Console.WriteLine("물입니다");
                            break;
                        case "3":
                            Console.WriteLine("스프라이트입니다");
                            break;
                        case "4":
                            Console.WriteLine("주스입니다");
                            break;
                        case "5":
                            Console.WriteLine("커피입니다");
                            break;
                    }

                }
                else
                { Console.WriteLine("잘못된 입력입니다"); }

                break;
            }

            //배열 days[]를 다음과 같이 초기화 하고 배열요소의 값을 다음과 같이 출력하는 프로그램 작성

            
            int[] days = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int[] month1 = new int[12] {1,2,3,4,5,6,7,8,9,10,11,12 };

            for (int i=0;i<13 ;i++ )
            {

                Console.WriteLine("{0}월은"+"{1}까지입니다.",month1[i], days[i]);

                
            }
            
            Console.ReadKey();

        }

    }
}