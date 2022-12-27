using System.Runtime.CompilerServices;

namespace itfunction
{
    internal class Program
    {
        //전역변수
        static int number3 = 5;
        static int number4 = 6;
        static void Main(string[] args)
        {
            int somevalue = 100;
            int number3 = 3;
            int number4 = 4;



            Console.WriteLine("Hello, World!");
            Console.WriteLine(somevalue);
            int a = somevalue;


            string returnvalue = Getstring();
            Console.WriteLine(returnvalue);



            Console.WriteLine();

            Console.WriteLine(Min(10, 20));
            Console.WriteLine(max(10, 20));
            Console.WriteLine(sum1(10, 20));

            int num = -21;
            int num2 = value1(num);

            int userInputNum = 0;

            int.TryParse(Console.ReadLine(), out userInputNum);

            int userInputNum1 = value1(userInputNum);

            Console.WriteLine($"{userInputNum}의 절댓값 : {userInputNum1}");


            Console.WriteLine($"{num}의 절댓값 : {num2}");

            Console.WriteLine(maximum(6, 7, 8));//3개의 정수중 최대값을 차례대로 구하기




            {
                Multi();
                Multi("반갑습니다.");
                Multi("또만나요", 3);

            }


            Factorial(2);

            Swap(number3, number4);

            HIHI();
            Multiply(5, 4);
            Console.WriteLine(Hypot(5, 4));//다른 두 변이 주어졌을 떄 직각 삼각형의 빗변을 계산하는 함수 Hypot()을 정의
            Console.WriteLine(Hypot(4, 6));//다른 두 변이 주어졌을 떄 직각 삼각형의 빗변을 계산하는 함수 Hypot()을 정의

            Console.WriteLine(prime(100));//100까지의 소수 모두 구하기

            sayHello(5);//int타입 매개변수 받아서 그 횟수만큼 "Hello"를 반복해서 출력
            
            Console.WriteLine("전화번호를 입력하세요");
            Console.WriteLine(call(""));


            Console.WriteLine("원하는 문자를 입력하세요");
            Console.WriteLine(back(""));








            /*
             * 함수 또는 메서드는 재사용을 목적으로 만든 특정 작업을 수행하는 코드 블록이다ㅓ.
             * 함수를 부르는 다양한 명칭
             * 함수(function)
             * 메서드(method)
             * 프로시저(PROCEDURE)
             * 서브루틴(subroutine)
             * 서브모듈(submodule)
             * 
             * 프로그래밍을 하다보면 같은 유형의 코드를 반복할 떄가 많다.
             * 이 ㅋ드들을 매번 입력하게되면 불편하고 입력하다 실수 할 수도 있다
             * 이떄 함수를 사용한다.
             * 
             * 프로그래밍 언어에서 어떤 동작 및 행위를 표현한다. 함수의 사용 목적은 코드 재사용에 있다.
             * 한번 만들어 놓은 함수는 프로그램에서 한번 이상 사용할 수 있다.
             * 지금까지 사용한 main()메서드는 c#의 시작 지점을 나타내는 특수한 목적의 함수로 볼 수 있다.
             * 또 Console class의 riteLine() 메서드도 함수로 볼 수 있다.
             * 
             * 함수란 어떤 값을 받아서 그 값을 가지고 가공을 거쳐 어떤 결과 값을 반환시켜주는 코드이다
             * 그리고 함수는 프로그램 코드 내에서 특정한 기능을 처리하는 독립적인 하나의 단위 또는 모듈을 가리킨다.
             * 함수는 다음 처리를 담당하는 부분을 따로 이름 있는 코드 블록으로 지정하는 것을 의미합니다.
             * 입력-처리-출력
             * 
             *함수는 내장 함수와 사용자 정의 함수가 있다. 내장 함수는 c#이 자주 사용하는 기능을 미리 만들어서 제공하는 함수로 특정 클래스의 함수로 표현된다.
             *내장함수도 그 용도에 따라 문자열관련 함수, 날짜 및 시간 관련 함수, 수학관련함수, 형식변환 관련 함수 등으로 나눌 수 있다.
             *이러한 내장함수를 API(Application Programming Interface)로 표현한다.
             *사용자 정의 함수는 내장 함수와 달리 프로그래머가 필요할떄마다 새롭게 기능을 추가하여 사용하는 함수이다.
             *
             *함수 정의하고 사용하기
             *함수 정의는(Define)이라고 하는데 함수를 만드는 작업이다. 함수 호출은 (call)은 함수를 사용하는 작업이다.
             *함수생성 및 호출은 반드시 소괄호가 들어간다.
             *함수를 정의하는 형태는 지금까지 사용한 main()와 유사하다.
             *다음 코드는 함수를 만드는 가장 기본적인 형태를 보여준다.
             *
             *static void [함수이름]()
             *{함수내용}
             *
             *만든 함수를 호출하는 형태는 다음 3가지가 있다.
             *[함수이름[():
             *[함수이름](매개변수):
             *변수(결과값)=함수이름(매개변수);
             */


            Console.WriteLine();
            //main()


            show();
        }


        //Hello, World!를 출력하는 사용자 정의 함수
        static void show()
        { Console.WriteLine("Hello, World!1"); }
        //class

        /*이 함수는 가장 간단한 형태의 함수로 매개변수(parametet)도 없고 반환값(return value)도 없는 형태이다.
         */


        /*함수를 반들고 반복해서 사용하기
         * 함수를 만드는 목적 중 하나는 반복 사용에 있다. 함수를 만들고 여러번 호출해서 사용하는 방법을 알아보자
         */



        static int HI1(string text)
        {
            Console.WriteLine("Hello world!");

            return 0;
        }
        /*함수를 만들어 놓고 기능이 동일한 함수만 사용하지는 않는다. 호출할떄마다 조금씩 다른 기능을 적용할 때는
         * 함수의 매개변수를 달리하여 호출할 수 있다. 매개변수(인자, 파라미터)는 함수에 어떤 정보를 넘겨주는 데이터를 나타낸다.
         * 이러한 매개변수는 콤마를 기준으로 여러개 설정할 수 있으며, 문자열과 숫자등 모든 데이터 형식을사용할 수 있다.
         * 
         * 매개변수 (인자, 파라미터)가 없는 함수: 매개변수도 없고 반환값도 없는 함수는 가장 단순한 형태의 함수이다.
         * 앞에서 사용한 함수 중에서 모든 변수에 있는 값을 문자열로 변환시키는 ToString 메서드 처럼 빈 괄호만 있는 함수형식을 나타낸다.
         * 
         * 매개변수가 있는 함수:특정 함수에 인자 값을 1개 이상 전달하는 방식이다. 
         * 정수형, 실수형, 문자형, 문자열형, 개체형등 여러가지 형식을 인자 값으로 전달할 수 있다.
         * 반환값이 있는 함수(결과값이 있는 함수):함수의 처리 결과를 
         * 함수를 호출한 쪽으로 반환할 떄는 return키워드를 사용하여 데이터를 돌려줄 수 있다.
         * 
         * 매개변수가 여러개(가변)인 함수: C#에서는 클래스 하나에 매개변수의 형식과 개수를 달리하여 이름이 동일한 함수를 여러개 만들 수 있다.
         * 이를 가리켜 함수 중복 또는 함수 오버로드(over load)라고 한다.
         */


        static void Showmessage(string message)
        {
            Console.WriteLine(message);
        }
        static string Getstring()
        {
            return "반환값";
        }



        static int Min(int x, int y)
        {


            if (x < y)
            {
                return x;
            }

            else
                return y;
        }

        static int max(int x, int y)
        {


            if (x < y)
            {
                return y;
            }

            else
                return x;
        }
        static int sum1(int x, int y)
        {


            if (x < y)
            {
                return x + y;
            }

            else
                return x + y;
        }
        static int value1(int num)
        {
            return (num < 0) ? -num : num;
        }


        //함수를 이용하여 큰값과 작은 값, 절댓값 구하기

        static void ComValuesAndAbsolut(int firstvalue, int secondValue)
        {
            int bigvalue = int.MinValue;
            int smallValue = int.MaxValue;
        }

        static void FunctionOverloading()
        {
            /*함수 오버로드:다중정의
             * 클래스 하나에 매개변수를 달리해서 이름이 동일한 함수여러개를 정의할 수 있는데 이를 함수 오버로드라고 한다.
             * 우리말로 여러번 정의한다는 의미이다.
             */
        }

        /* ! 숫자를 받아서 출력하는 함수
         * 
         * @param number int number ofr print
         */

        static void GetNumber(int number)
        {
            Console.WriteLine($"Int32:{number}");
            Console.WriteLine($"8바이트 정수:{number}");
        }

        static void Multi()
        {
            Console.WriteLine("안녕하세요.");
        }
        static void Multi(string message)
        {
            Console.WriteLine(message);
        }

        static void Multi(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}", message);

            }
        }

        static void RecursionFunction()
        {
            /*재귀함수
             * 함수에서 함수 자신을 호출하는 것을 재귀(Recursion)또는 재귀함수라고 한다.
             */
        }

        static int Factorial(int n)
        {//여기서 탈출

            if (n == 0 || n == 1)
            {
                return 1;
            }

            Console.WriteLine("n의 값은 {0}", n);
            return n * Factorial(n - 1);

        }

        static void FunctionScope()
        {
            /*함수 범위:전역변수와 지역변수
             * 클래스와 같은 레벨에서 선언된 변수를 전역변수(Global variable) 또는 필드(filed)라고 하며
             * 함수 레벨에서 선언된 변수를 지역변수(loclal variable)라고 한다 이때 동일한 이름으로 변수를 전역변수와 함수내의 지역 변수로 선언할 수 있다.
             * 함수 내에서는 함수 범위에 있는 지역변수를 사용하고 함수 범위 내에 선언된 변수가 없으면 전역변수 내에 선언된 변수를 사용한다.
             * 단, C#에서는 전역 변수ㅡ가 아닌 필드라는 단어를 주로 사용하며, 전역변수는 언더스코어(__) 또는 m_접두사를 붙이는 경향이 있다.
             */

        }



        static void Swap(int intvalie1, int intvalie2)
        {

            Console.WriteLine("바뀌기 전의 값 {0}, {1}", intvalie1, intvalie2);

            int temp;
            temp = intvalie1;
            intvalie1 = intvalie2;
            intvalie2 = temp;

            Console.WriteLine("바뀐후의 값 {0}, {1}", intvalie1, intvalie2);

        }

        static void ArrowFunction()
        {
            /*화살표 함수
             * 화살표 모양의 연산자인 화살표 연산자(=>)를 사용함 메서드 코드를 줄일 수 있다.
             * 이를 화살표 함수(Arrow Function)이라고 한다. 프로그래밍에서 화살표 함수 또는 화살표 메서드는 람다 식(Lamda express) 의 또다른 이름이다.
             * 
             *화ㅓ살표 함수를 사용하면 함수를 줄여서 표현할 수 있다. 함수 고유의 표현을 줄여서 사용하면 처음에는 어색할 수 있다.
             *하지만 이 방식에 익숙해지면 차후에는 코드의 간결함을 유지할 수 있다.
             */
        }

        static void HIHI() => Console.WriteLine("안녕하세요");
        static void Multiply(int a, int b) => Console.WriteLine(a * b);
        static double Hypot(double a, double b) => Math.Sqrt((a * a) + (b * b));

        static bool prime(int num)
        {
            bool flag = true;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    Console.Write("{0} ", i);
                }
                flag = true;
            }
            Console.WriteLine();
            return true;
        }

        static int maximum(int a, int b, int c)
        {

            if (a > b)//조건 (a>b)
            {
                if (a > c)//조건 (a>c)
                {

                    if (b > c)//조건 (b>c)
                    {
                        Console.WriteLine("{0},{1},{2}", a, b, c);
                    }
                    else//아닐 때
                    {
                        Console.WriteLine("{0},{1},{2}", a, c, b);
                    }
                }
                else//아닐 때
                {
                    Console.WriteLine("{0},{1},{2}", c, a, b);
                }
            }
            else//(a>b)아닐 때 (b>=a)
            {
                if (b > c)//조건 (b>c)
                {
                    if (a > c)//조건(a>c)
                    {
                        Console.WriteLine("{0},{1},{2}", b, a, c);
                    }
                    else//아닐 때
                    {
                        Console.WriteLine("{0},{1},{2}", b, c, a);
                    }
                }
                else//아닐 때
                {
                    Console.WriteLine("{0},{1},{2}", c, b, a);
                }
            }
            return 0;

            static void Hypot(double a, double b)
            {
                if (a > 0)
                {
                    Math.Sqrt((a * a) + (b * b));

                }

            }



        }

        static void sayHello(int count)
        {
            for (int i = 2; i < count; i++)
            {
                Console.WriteLine("hello");

            }
        }

        static string call(string a)
        {
            bool check = true;

            

            while (check)
            {

                Console.WriteLine("전화번호를 입력하세요. (quit 를 입력할 경우 종료 됩니다.");
                string phone =Console.ReadLine();

                string remove1 = phone.Replace("(", " ");

                string remove2 = remove1.Replace(")", " ");

                Console.WriteLine(remove2);


                if (phone == "quit")
                {

                    check = false;
                    Console.WriteLine("종료되었습니다");
                }

                

            }

            return " ";



        }

        static string back(string a)
        {
            String text = Console.ReadLine();
            String text1 = new String(text.ToCharArray().Reverse().ToArray());

            return text1;
        }

            


            
        
        
    }
    
}





    



    


   

        
    



   
            

        
    

    



