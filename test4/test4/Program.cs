using System;
using System.Collections;

namespace test4
{
    internal class Program
    {
        private static int swichnumber;

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");


            /*
             * 선택문인 switch 문은 값에 따라 다양한 제어를 처리할 수 있다.
             * 조건을 처리할 내용이 많은 경우 유용하다.
             * switch, case, default 키워드를 사용하여 조건을 처리한다.
             */

            /*
            Console.Write("정수 1, 2, 3 중에 하나를 입력하시오:");
            int.swichnumber = 0;
            int.TryParse(Console.ReadLine(), out swichnumber);
            
            switch (swichnumber)
            {
                case 1:
                    Console.WriteLine("1을 입력 했습니다.");
                    break;
                case 2:
                    Console.WriteLine("2을 입력 했습니다.");
                    break;
                case 3:
                    Console.WriteLine("3을 입력 했습니다.");
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외 입력입니다..");
                    break;

            */

            /*
            switch (swichnumber)
            {
                case 1:
                    Console.WriteLine("1을 입력 했습니다.");
                    goto case 3;
                case 2:
                case 3:
                    Console.WriteLine("3을 입력 했습니다.");
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외 입력입니다..");
                    break;

            02.5 중간점검
            1. case 절에서 break 문을 생략하면 어떻게 되는가?

            */

            /*

            Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            Console.Write("1. C \t");
            Console.Write("2.C++ \t");
            Console.Write("3.C# \t");
            Console.Write("4.java \t");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (swichnumber)
            {
                case 1:
                    Console.WriteLine("1. C 선택");
                    break;
                case 2:
                    Console.WriteLine("2.C++ 선택");
                    break;
                case 3:
                    Console.WriteLine("3.C# 선택");
                    break;
                case 4:
                    Console.WriteLine("4.java 선택");
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외 입력입니다..");
                    break;


            }


            while 문은 조건식이 참일 동안 문장을 반복 실행한다.


            */
            //while 문은 반복문인데 5번 실행할 예정
            /*

            int loopCounter = 0;
            while(loopCounter <5)
            {
                Console.WriteLine("{0} 반복문이 정말로 5번만 실행되나?", loopCounter + 1);
                loopCounter++;
                // loop 5만 도는 루프
            }

            //10 ~ 1 카운트 후 발사 출력하는 프로그램 작성

            loopCounter = 10;
            while (loopCounter > 0)

            {
                Console.Write("{0} ", loopCounter);
                loopCounter -= 1;
                //loop;
            }
            Console.WriteLine("발사");

            */

            /*
            Console.WriteLine("숫자를 입력하세요:");
            int userinput = int.Parse(Console.ReadLine());

            int loopCounter = 0;

            while (loopCounter < userinput)
            {
                if (userinput < 0) break;
                Console.WriteLine("{0} hello world", loopCounter + 1);
                loopCounter++;
                
            }
            Console.WriteLine("음의 정수를 입력하셨습니다:");

            */

            /*
            Console.WriteLine("숫자를 입력하세요:");
            int userinput = int.Parse(Console.ReadLine());

            int loopCounter = 1;

            while (loopCounter < userinput)
            {
                if (userinput < 0) break;
                Console.WriteLine("{0} hello world", loopCounter*3);
                loopCounter++;

            }
            Console.WriteLine("음의 정수를 입력하셨습니다");
            */

            /*
            {
                int sum = 0;

                while (true)
                {
                    Console.Write("수를 입력하세요: ");
                    string line = Console.ReadLine();
                    if (line == "0") break;
                    sum += int.Parse(line);
                }

                Console.WriteLine("지금까지 입력된 수의 합: " + sum);
            }

            */
            /*

            {
                Console.WriteLine("숫자를 입력하세요:");
                int userinput = int.Parse(Console.ReadLine());

                int loopCounter = 1;

                while (loopCounter < userinput)
                {
                    if (userinput < 0) break;
                    Console.WriteLine(loopCounter * 3);
                    loopCounter++;

                }
                Console.WriteLine("음의 정수를 입력하셨습니다");
            }

            */
            /*
            {
                Console.WriteLine("숫자를 입력하세요:");
                int userinput = int.Parse(Console.ReadLine());

                int loopCounter = 9;

                while (loopCounter > 0)
                {
                    if (userinput < 0) break;
                    Console.WriteLine(loopCounter * userinput);
                    loopCounter--;

                }
                Console.WriteLine("음의 정수를 입력하셨습니다");
            }
            */

            /*
            int sum = 0;

            
            {
                Console.WriteLine("입력할 갯수:");
                double userinput = double.Parse(Console.ReadLine());
                

                while (true)
                {
                    Console.Write("수를 입력하세요: ");
                    string line = Console.ReadLine();
                    if (line=="100") break;
                    sum += int.Parse(line);
                }

                Console.WriteLine("평균값 " + sum / userinput);

            }

            */

            /*
             * 
             * for 문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 한번 반복이 끝날때마다 증감식이 실행된다.
             * 
             * */

            //1~10 까지 정수의 합
            /*
            int sumNumber = 0;
            for(int index =1; index <=10; index++)
            {
                sumNumber += index;
            }
            Console.WriteLine($"1부터 10까지의 정수의 합={sumNumber}");
            Console.WriteLine("1부터 10까지의 정수의 합= {0}", sumNumber);

            */
            int sumNumber = 1;


            for (int index = 1; index <= 100; index++)

            {
                sumNumber += index;
            }
            Console.WriteLine($"1부터 10까지의 정수의 합={sumNumber}");
            Console.WriteLine("1부터 10까지의 정수의 합= {0}", sumNumber);

        }






    }
}
            
 