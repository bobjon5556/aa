//System 이라는 어셈블리에서 이것 저것 여러 기능을 가져와서 사용
using System;

namespace whatisarray//내 프로그램 이름
{
    internal class Program //클래스 c#에서는 모든 요소들이 클래스 안에 있어야 함
    {
        static void Main(string[] args)//무조건 1개는 있어야한다. C#콘솔 창을 사용할때
        {
            Console.WriteLine("Hello, World!"); //프로그램은 여기서 부터 읽기 시작한다.


            //3의 배수를 제외한 수
            //int sumOfnumver=0;
            //int variable = 100;
            //bool isrealmultipleofthree = (variable_%3==0);
            //(variable_%3 ==0)
            //어떤변수 = "남자"

            //if (/*여기서 조건문은*/)  //남자 입니까? //조건문 A
            {

                //조건문이 참이면 여기로 옴
                //조건문은 여기서 부터 읽기 시작한다
                //조건문은 여기서 끝난다.
            }
            //else if ()//여자 입니까?  //조건문 B
            //{ }
            // else
            {
                //위의 조건문이 거짓이면 여기로 옴
                //조건문은 여기서부터 읽기 시작한다
                //조건문은 여기서 끝난다.
            }



            // 조건문을 여기서 시작했으면 이제 여기서 다시 프로그램이 시작

            int somenumber = 100;
            bool ispositiveintger = (0 < somenumber);

            bool isnumberzero = (somenumber == 0);


            int useriputnumber = 3;
            for (int index = 1; index <= 9; index++)
            {
                Console.WriteLine("{0} x {1}={2}",
                useriputnumber, index, useriputnumber * index);



            }


            /*프로그램 사용자로부터 입력받은 정수의 평균을 출력하는 프로그램을 작성하되
             * 다음 두가지의 조건을 만족할 것
             * -먼저 몇개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다
             * 그리고 그 수만큼 정수를 입력 받는다
             * 평균값은 소수점 이하까지 계상해서 출력한다.
             * */

            /*
             * 1.비밀코드 맞추기
             * 컴퓨터가 숨긴 비밀코드를 추측하는 게임을 작성
             * 비밀코드는 a~z사이의 문자
             * 컴퓨터는 사용자의 추측을 읽고 앞에 있는지 뒤에 있는지 알려준다
             */
            char scretcode = 'y';
            char userInputAlphabet = 'c';
            bool isSmallAlphabet = ('a' <= userInputAlphabet && userInputAlphabet <= 'z');

            bool isApabetfore = (userInputAlphabet <= scretcode);
            bool isApabetBack = (scretcode <= userInputAlphabet);

            if (isApabetfore)
            {
                Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다");
            }
            else
            { //do nothing
                Console.WriteLine("{0},{1}", "당신의 입력을 처리할 수 없습니다", "알파벳 소문자만 입력 바랍니다");
            }

            if (isApabetBack)
            {
                Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다");
            }
            else
            { //do nothing
            }


            //1~100 숫자 중에서 3의 배수 이면서 4의 배수인 정수 합 구하기
            int sumnumber = 0;
            int somenumber1 = 100;
            bool ismulti3 = (somenumber1 % 3 == 0);
            bool ismulti4 = (somenumber1 % 4 == 0);

            bool isSatis = ismulti3 && ismulti4;

            if (isSatis)
            {

                sumnumber += somenumber;
            }

            //별을 100번 찍는 법
            Console.WriteLine("{0},{1},{2},{3},{4}", "**********");
            Console.WriteLine("{0},{1},{2},{3},{4}", "**********");

            for (int index = 1; index <= 100; index++)
            {
                Console.Write("{0}", "*");
            }
            for (int index2 = 1; index2 <= 10; index2++) //이건 10번 도는 루프
            {
                for (int index2 = 1; index2 <= 10; index2++)//이건 밖의 루프가 1번 도는 동안 10번 도는 루프
                {
                    Console.WriteLine("{0}", "*");
                }
                Console.WriteLine();
            }


            for (int index = 1; index <= 100; index++)//이건 100번 도는 루프
            {
                Console.Write("{0}", "*");
            }


            int hundredCount = 0;

            for (int index2 = 1; index2 <= 10; index2++) //이건 10번 도는 루프 총합 1000번
            {
                for (int index2 = 1; index2 <= 10; index2++)//이건 밖의 루프가 1번 도는 동안 10번 도는 루프
                {
                    for (int index3 = 1; index3 <= 10; index3++)//이건 밖의 루프가 1번 도는 동안 10번 도는 루프
                    {
                        hundredCount++;
                        if (100 < hundredCount) { break; }
                        else
                        { //do nothing
                        }
                        Console.Write("{0}", "*");//별을 찍는 지점

                        if(hundredCount % 10 ==0)
                        {
                            Console.WriteLine();
                        }
                    }

                }
                Console.WriteLine();
            }
            /*
             * 유저 입력 받아서 (1~20줄) 유저 입력은 줄 단의 개수임 등차수열로 한단이 내려갈떄마다 별 1개씩 추가로 증가하는 프로그램 작성*/

            
            int hundredCount1 = 0;
            int aaaa = 0;

            char userChar = Convert.ToChar(Console.ReadLine());

            for (int index2 = 1; index2 <= userChar; index2++)
            {
                if (100 < hundredCount1) { break; }



                else
                { 
                }


            }

            }//프로그램은 여기서 끝난다.
    }
}