

namespace whatisstricture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            /*Public struct BusinessCard
        { 
        
        }

            */
            /*

            struct BusinessCard
        { 
        
        
        }
           
        
        /*
        enum weekday
        {
            SUNDAY, MONDAY, TUESDAY, wEDNESDAY, THURSDAY
        }





        /*
         * 구조체란?
         * 구조체는 이름하나로 데이터를 ㅁㄲ어 고ㅓㅏㄴ리하는 역할을 한다.
         * 앞에서 배운 변수는 이름 하나로 공간을 하나 갖고 배열은 이름 하나로 데이터 형식이 동일 한 공간을 여러개 갖는다. 
         * 변수와 배열은 확장하여 이름 하나로 데이터 형식을 1개 또는 여러게 보관하는 그릇역할을 하는것이 구조체이다.
         * 
         * 
         * 
         * 
         * 
         * 
         * 구조체를 선언할 떄는 strurct 키워드를 사용한다 여기에서는 struct point() 형태로 
         * 이름이 point구저체를 만들었다,. 만든 구조체는 int string 형식의 변수선언과 동일한 방법으로 선언한 후사용할 수 있다.
         * 변수는 값을 하나만 저장하지만 구조체는 점(,)으로 구분하여 구조체를 선언할 때 사용한 변수 여러개를 이름하나(point)로 묶어ㅓ 쓸 수 있다.
         */


            /*
            Business myCard;

            myCard.age = 123;
            myCard.adress = "korea";
            myCard.name = "Me";
            */


            /*내장형 구조체
             * 닷넷 프레임워크에서 이미 내장(Built-in)된 구조체 중에서 날짜 처리를 전담하는 Datetimme과 TimeSpan궂체
             * 문자관련 처리를 담당하는 char구조체를 자주 사용한다.
             * -DateTime 구조체:시간/날짜 관련 모든 정보 제고
             * -TimeSpan 구조체:시간 날짜 간격에 대한 모든 정보제공
             * -char구조체:문자관련 모든 정보를 제공. 예를들어 특정 문자가 숫자형식인지 기호문자인지 공백문자인지등을 판단하는 기능을 제공
             */


            Console.WriteLine("DateTime.Now 하면 뭐가 나오나?->{0}", DateTime.Now);
            Console.WriteLine("DateTime.Now 하면 뭐가 나오나?->{0}", DateTime.Now.Year);
            Console.WriteLine("DateTime.Now 하면 뭐가 나오나?->{0}", DateTime.Now.Month);
            Console.WriteLine("DateTime.Now 하면 뭐가 나오나?->{0}", DateTime.Now.Day);
            Console.WriteLine("DateTime.Now 하면 뭐가 나오나?->{0}", DateTime.Now.Hour);
            Console.WriteLine("DateTime.Now 하면 뭐가 나오나?->{0}", DateTime.Now.Minute);
            Console.WriteLine("DateTime.Now 하면 뭐가 나오나?->{0}", DateTime.Now.Second);


            /*열거형 형식 사용하기
             * C#에서 열거형(Enumeration)형식은 기억하기 어려운 상수들을 기억하기 쉬운 이름 하나로 묶어 관리하는 표현 방식이다.
             * 일반적으로 열거형을 줄여 말한다. 열거형을 사용하면 값 리스트 여러개를 이름 하나로 관리할 수 있는 장점이 있다
             * 열거형은 enum 키워드를 사용하고, 이늄 또는 이넘으로 읽는다.
             */

            /*
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green");
            Console.WriteLine("Green");
            Console.WriteLine("Green");
            Console.WriteLine("Green");
            Console.ResetColor();
            */


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bule- 글자색이 파랗게 글자 뒤 배경이 흰색으로 변경");
            Console.ResetColor();
            Console.WriteLine();

            /*
            weekday ,weekday;
            myweekday = weekday.WEDNESDAY;
            */


            //열거형 예제 실습

            /*
            Animal animal = Animal.DoG;
            switch (anmal)
            {

                case Animal.CHICKEN;
                    Console.WriteLine("닭울음");
                    break;
                default:
                    Console.WriteLine("처리되지 않은 예외입력입니다");
                    break;
            }


            */

            /*C#의 모든 코드에 반드시 들어가는 클래스Class)를 알아보자.
             * 
             * 클래스 소개하기
             * 클래스는 지금까지 작성한 모든 예제에서 기본이 되는 C#의 핵심 코드 이다.
             * public class[클래스 이름]
             * {
             * -어떤 내용
             * }
             * 같은 코드 블록을 사용하여 정의할 수 있다. 클래스를 정의하는 전반적인 내용과 클래스 내부 또는 외부에 올 수 있는 올 수 있는 구성요소는 다음장에서 살펴본다.
             * 클래스의 구성 요소는 많지만, 그중에서 그 중에서 속성과 메서드를 가장 많이 사용한다.
             * 속성은 데이터를 다루고 메서드는 로직을 다룬다.
             * -클래스
             * -속성:데이터
             * -메서드:로직
             * 
             * 클래스는 그 의미에 따라, 이미 닷넷 플임워크에서 미리 만들어 놓은 내장형식(Built-in type)과사용자가 직접 클래스 구조를 만드는
             * 사용자 정의 형식(user defined type)으로 구분할 수 있다.
             * 예를들어  Console,string, Math 등 클래스는 내장형식이다. 그리고 class키워드로 product, Note, User, Group처럼 새로운 형식(기존에 제공되지 않는)
             * 을 정의할 수 있는데, 이를 사용자 데이터 형식이라고 한다.
             * 
             * 
             * 클래스 만들기
             * 클래스를 정의하면 다음과 같다.
             * -클래스는 개체를 생성하는 틀(템플릿)이다.
             * -클래스는 무엇인가를 만들어 내는 설계도 이다.
             * 
             * 클래스는 C# 프로그래밍의 기본 단위로 새로운 개체(실체)를 생성하는 설계도(청사진)역할을 한다.
             * 예를들어 자동차라는 개케(Object)를 만들려면 자동차 설계도가 필요하다. 이와 마찬가지로 프로그래밍에서도 설계도가 필요한데
             * 이 역할을 하는것이 클래스 이다. 즉 클래스는 개체를 생성하는 틀(템플릿)이며 더 간단히 말하자면 무엇인가를 만들어내는 설계도이다.
             * 
             * 클래스 선언하기
             * -클래스는 반드시 대문자로 시작한다.
             * 
             * public class [클래스이름]
             * {
             *     //클래스 내용을 구현
             *     -속성->변수
             *     -메서드->함수
             *     }
             *     
             *     
             */

            ClassNote classNote = new ClassNote();
            ClassNote.Run();
            //ClassNote.Run1();
            /*
             * 클래스를 여러개 사용할때는 public 키워드를 써야한다. public 키워드가 붙은 클래스는 클래스 외부에서 해당클래스를
             * 바로 호출해서 사용할수 있도록 공개되었다는 의미이다.
             * 반대의미는 private 키워드를 사용한다.
             * 
             * static과 정적 메서드
             * ㅊ#에서는 static을 정적으로 표현한다. 의미가 같은 다른 말로 표현하면 공유(shared)이다.
             * static이 붙는 클래스의 모든 멤버는 해당 클래스 내에서 누구나 공유해서 접근할 수 있다.
             * 메서드에 static이 붙은 메서드를 정적 메서드라고 하는데, 이를 공유메서도(shared method)라고도 한다.
             * 
             * 
             * 정적 메서드와 인스턴스 메서드
             * 
             * 닷넷의 많은 API처럼 우리가 새롭게 만드는 클래스는 메서드를 포함한 각 멤버에 static키워드 유무에 따라 정적 또는 인스턴스 멤버가 될 수 있다.
             * (static이 붙으면 정적 안붙으면 인스턴스)
             * 
             * 인스턴스화란?
             * 하드에 있는 파일이 실행되어 RAM에 올라와 실행 영역에 올라간것 처럼
             * 실행영역으로 들어간 코드를 가리킨다.
             * 
             * 
             * 클래스 시그니쳐
             * 클래스는 다음 시그니처를 가진다.
             * 
             * public class Car {}
             * 
             * public 엑서스 한정자를 사용하면 기본값인 internal을 갖는데 internal은 해당 프로그램 내에서 언제든지 접근 가능하다.
             * 하지만 학습 단계에서는 클래스에 public만 사용해도 괜찮다. 그리고 class키워드 다음에 클래스 이름이 오는데
             * 클래스 이름은 대문자로 시작하는 명사를 사용한다.
             * 클래스 본문 또는 클래스 몸통(class body)을 표현하는 중괄호 안에는 지금까지 배운 메서드와 앞으로 다룰 필드,속성,생성자,소멸자(변수와 함수) 등이 올 수 있는데
             * 이 모두를 가리켜 클래스 멤버라고 한다.
             * 
             * 
             * 클래스 이름 짓기
             * 
             * 클래스 이름은 의미있는 이름을 사용하면 좋다.
             * 이름은 명사를 사용하며 첫 글자는 꼭 대문자 여야 한다. 또한 클래스 이름을 지을 때는 축약형이나 특정접두사, 언더스코어 같은 특수 문자는 쓰지 않는다.
             * -클래스 이름은 누구나 알기 쉽게 그리고 간단하고 명확해야 한다.
             * 
             * 클래스의 주요 구성 요소
             * 클래스의 시작과 끝, 즉 클래스 블록 내에는 다음용어(개념)이 포함 될 수 있다. 클래스 구성요소를 가리킬때 클래스 맴버라는 용어와 혼용해서 사용한다.
             * 
             * -필드(Field):클래스의 부품역할을 한다. 클래스 애에 선언된 변수나 데이터를 담는 그릇으로 개체 상태를 저장한다.
             *-메서드(method):개체 동작이나 기능을 정의한다. 
             * -생성자(comstruchor):개체 필드를 초기화한다. 즉 개체를 생성할 때 미리 수행해야할 기능을 정의한다.
             * -소멸자(destructor):개체를 모두 사용한 후 메모리에서 소멸될 떄 실행한다.
             * -속성(Property):개체의 색상,크기,형태등을 정의한다.
             * 
             * 
             * 엑세스한정자
             * 클래스를 생성할 떄 public, private, internal, absteact, sealed 같은 키워드를 붙일 수 있다.
             * 이를 엑세스 한정자라고 한다. 엑세스 한정자는 클래스에 접근할 수 있는 범위를 결정하는데 도움이 된다.
             * 특별히 지정하지 않는 한 기본적으로 public 엑세스 한전자를 사용하면 된다.
             * 
             * 
             */

            ClassNote classNote1 = new ClassNote();  //인스턴스 화 되었음
            classNote.InstanceMethod();

            TrumpCard trumpCard = new TrumpCard();

            TrumpCard SetupTrumpCards;
            Console.WriteLine();
            Console.WriteLine();

            trumpCard.SetupTrumpCards();
            trumpCard.ShuffleCards(200);
            trumpCard.printcheck();
            trumpCard.RollCard();
            trumpCard.reroll();


            Random random = new Random();//인스턴스 메서드
            int randomnumber = random.Next(1, 100 + 1);//인스턴스화

            int randomnumber1 = random.Next(1, 45);
            int randomnumber2 = random.Next(1, 45);
            int randomnumber3 = random.Next(1, 45);
            int randomnumber4 = random.Next(1, 45);
            int randomnumber5 = random.Next(1, 45);
            int randomnumber6 = random.Next(1, 45);

            int[] lottoarr = new int[] { randomnumber1, randomnumber2, randomnumber3, randomnumber4, randomnumber5, randomnumber6, };

            if (lottoarr.Length == randomnumber1)
            {
                int randomnumber7 = random.Next(1, 45);

            }


            bool check=true;
            

            Console.WriteLine("가위바위보를 시작합시다.");
            string input=Console.ReadLine();


           
            

                switch (input)
                {
                    case "가위":
                        Console.WriteLine($"비겼다");
                        break;
                    case "바위":
                        Console.WriteLine($"졌다");
                        break;
                    case "보":
                        Console.WriteLine($"이겼다");
                        break;
                        
                        
                }


            int Random1 = 0;                      
            int com1 = 0;                   
            string[] choice = { "가위", "바위", "보" };

            int 가위;
            int 바위 = 2;
            int 보 = 3;

            Random1 = (new Random()).Next(0, 3);   

            Console.Write("가위,바위 보 입력");
            string input1 = Console.ReadLine();

            Console.WriteLine(" 유저 : {0}", choice[com1]);
            Console.WriteLine(" 컴퓨터 : {0}\n", choice[Random1]);

            if (com1 == Random1) //결과 출력
            {
                Console.WriteLine("비김");
            }
            else
            {
                switch (com1)
                {
                    case 1: Console.WriteLine((Random1 == 3) ? "승" : "패"); break;
                    case 2: Console.WriteLine((Random1 == 1) ? "승" : "패"); break;
                    case 3: Console.WriteLine((Random1 == 2) ? "승" : "패"); break;
                }
            }




            



        }//main()

    }// class program1

    public class ClassNote
    {
        public static void Run() //공개된 권한
        {
            Console.WriteLine("ClassNote 클래스의 run메서드");

        }
        private static void Run1() //비공개된 권한
        {
            Console.WriteLine("ClassNote 클래스의 run메서드");

        }

        public void InstanceMethod()
        {
            Console.WriteLine("ClassNote 클래스의 InstanceMethod");
        }

        public int[] swap(int[] randomnumber)
        {
            Random random = new Random();

            int sourIndex = random.Next(0, randomnumber.Length);
            int destIndex = random.Next(0, randomnumber.Length);

            int temp = randomnumber[sourIndex];

            return randomnumber;
        }

        public static void rock()
        {


            string 가위;
            string 바위;
            string 보;


            
        } 
    }

}


    


