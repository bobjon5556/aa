using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int num1, num2;
            int num3, secretNumber;

            secretNumber = rand.Next(1,100);


            for (int i = 0; i < 7; ++i)
            {
                Console.Write("숫자를 입력하세요: ");
                int num4 = int.Parse(Console.ReadLine());


                if (num4 < secretNumber)

                { Console.Write("예상 숫자가 너무 작습니다"); }

                else if (num4 > secretNumber)

                { Console.Write("예상 숫자가 너무 큽니다"); }

                else

                break; 




                if (num4 == secretNumber)

                { Console.Write("예상한 숫자" + num4 + "는 정답입니다"); }
                else

                    Console.Write("컴퓨터가 생각한 숫자는" + secretNumber + "입니다");


            }
            
            
        }
    }




    


    
}
