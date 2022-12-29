namespace whatiscalss1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*값 형식과 참조형식
             * 클래스나 구조체 같은 데이터 형식을 말할 때 값 형식(Value type)과 참조형식(Referece type)으로 구분 짓기도 한다.
             * 
             * 값형식
             * 개체에 값 자체를 담고있는 구조이다. 지금까지 다룬 int, double 등은 내부족으로 구조체로 된 전형적인 값 형식의 구조이다.
             * 
             * 참조형식
             * 개체가 값을 담고 있는 또 다른 개체를 포인터로 바라보는 구조이다. 여러값이 동일한 개체를 기리킬 수 있다.
             * 
             * 어렵게 생각하지 말고 간단하게 생각하면 편하다. 
             * 실제 금붙이로 물물교환이 가능하면 값형식 실물을 사용하지 않고 어음 같은 종이조각으로 거래하면  참조값이다.
             * 값형식에 비해 참조형식은 가볍고 다루기가 쉽다.
             * 다만 값형식을 복사하면 실물을 복사하는 거라 원본실물에는 타격이 가지 않지만
             * 참조타입은 실질적으로 원본을 불러오는거라 수정하면 원본에 직접적인 타격이 간다.
             */

            /*
             * 박싱과 언박싱
             * 프로그래밍을 하다보면 뎅터의 형식 변환이 필요하다. 이러한 변환 과정에서 값형식의 데이터를 참조형식의 데이터로 변경하는 것을 박싱(Boxing)이라고 한다.
             * 반대로 참조형식의 데이터를 값형식의 데이터로 변경하는 것을 (Unboxing)이라고 한다.
             * 
             * 박싱
             * 박싱이란 말 그대로 박스에 포장을 하는 것이다. C#에서 박싱은 값 형식의 데이터를 참조 형식의 데이터로 변환하는 작업을 의미한다.
             * 예를 들어 다음 코드처럼 정수 형식의 데이터를 오브젝트 형식의 데이터에 담는 형태를 박싱이라고 한다.
             * 좀 더 어렵게 설명하자면 스택 메모리 영역에 저장된 값 형식의 데이터를 힙 메모리 영역에 저장하는 단계를 거치기 때문에 시간과 공간이 소비되는 비용이 발생.
             * 
             * 언박싱
             * 다음 코드는 object 변수에 저장된 1234fmf 실제 정수 형식의 데이터로 변환하는 모습은 보여준다.
             * 참조 형식의 데이터를 값형식의 데이터로 변환하는 과정이 포장을 부는 것과 비슷하게 보여 언박싱이라고 한다.
             * 언박싱을 캐스트cast) 또는 캐스팅Casting)으로 표현한다.
             * 
             * 오브젝트 형 변수에 들어있는 데이터 중에서 숫자 형식의 데이터는 바로 int형 변수에 대입할 수 없다. object 형 변수에 대입하려면
             * 형식 변환을 해야한다. 형식 변환은 캐스팅이나 Convert 클래스 같은 변환 API를 사용하면된다.
             * 즉, (int) 또는 Convert,To32()같은 형식 변환 기능을 명시적으로 지정해 주어야 한다.
             */

            /*참조형식 예제
            int number = 10;
            Console.WriteLine("number에 저장된 값은 {0}이고, 주소는{1}입니다.",number);
            */

            /*박싱과 언박싱의 예제
             * int number = 1234;
             * object objectvalue = number;
             * Console.WriteLine("{0}", objectvalue);
             */

            /*object objectvalue = number;
             * char charvalue='a'<-인트값으론 97로 저장됨
             * int intvalue=97
             * 여기서 인트 97과 a를 어떻게 구분할 것인가?
             * 이부분에서 형변환이 필요해진다. 같은 97값이지만 하나는 a로 하나는 97로 변화시킨다.
             * 
             * Console.WriteLine("{0}", objectvalue);
             * charvalue2 = (char)objectvalue;
             * Console.WriteLine("{0}", charvalue2);
             * 
             */

            /*필드
             * 필드(Feild)는 클래스의 부품 역할을 하는 클래스의 내부 상태 값을 저장해 놓는 그릇을 의미한다.
             * 예를들어 필드는 자동차 클래스에 선언된 변수로 자동차 부품에 해당한다고 할 수 있다.
             * 
             * 필드
             * 클래스 내에서 선언된 변수 또는 배열 등을 C#에서는 필드라고한다. 
             * 필드는 일반적으로 클래스의 부품 역할을 하며, 대부분 private 엑세스 한정자(Access modfier)가 붙고 클래스 내에서 데이터를 담는 그릇 역할을 한다.
             * 이러한 필드는 개체 상태를 보관한다.
             * 필드는 선언한 후 초기화 하지 않아도 자동으로 초기화한다.
             * 예를들어 int 형 필드는 0으로, string형 필드는 String Empty,즉 공백으로 초기화된다.
             * (그래도 왠만하면 초기화는 직접 하는것이 좋다)
             */


            /*지역변수와 전역변수
             * C#에서 변수를 선언할 때는 main() 메서드와 같은 메서드 내에서 선언하거나 메서드 밖에서, 즉 메서드와 동등한 레벨에서 변수를 선언할 수 있다.
             * 메서드 내에서 선언된 변수 또는 배열을 지역변수(Local variable)이라고 하며 메서드 밖에서 선언된 변수를 전역변수(Global variable)라고 한다.
             * 다만 C#에서는 전역변수라는 용어를 사용하지 않고 메서드와 동일하게 엑세스 한정자를 붙여 필드라고 한다.
             * 
             * 지역변수
             * 변수는 Main() 메서드가 종료되면 자동으로 소멸된다. 변수가 살아있는 영역은 Main()메서드의 중괄호 시작({)과 끝(})사이 이다.
             * 특정 지역의 범위로 하기에 변수를 일반적으로 지역 변수라고 표현한다.
             * 
             * 전역변수
             * Main()메서드가 아닌 클래스 내에 선언된 변수를 필드라고 한다.
             * C#에서 필드는 변수와 마찬가지로 주로 소문자 또는 언더스코어(__)로 시작한다.
             * 이러한 필드는 메서드 내에 선언된 지역변수와 달리 전역변수라고 한다.
             * 
             */

            /*C#에서 생성자는 클래스 맨 먼저 호출되는 메서드로, 클래스 기본값 등을 성정한다.
             * 자동차 클래스를 예로들면 자동차의 시동걸기에 해당되는 것이 바로 생성자이다.
             * 
             * 생성자
             * 클래스의 구성 료소중애서 생성자라는 매서드가 숨어 있다. 단어 그대로 개체를 생성하면서 우엇인가를 하고자 할 때 사용되는 메서드이다.
             * 일반적으로 생성자는 개체를 초기화(주로 클래스 내 필드를 초기화)하는데 사용된다.
             * 생성자는 생성자 메서드라고 한다. 
             * 이러한 생성자 메서드는 독특한 규칙이 있는데, 바로 생성자의 이름이 클래스 이름과 동일 하다는 것이다.
             * 클래스 내에서 클래스 이름과 동일한 이름을 갖는 메서드는 모두 생성자인다.
             * 생성자는 매개변수가 없는 기본(DEfault)생성자가 있고, 매개변수를 원하는 만큼 정의해서 사용할 수 도 있다.
             * 이때 리턴값은 가지지 않는다. 또 생성자도 static생성자(정적생산자)와 public생성자(인스턴스 생성자)로 구분된다.
             * 일반적으로 public키워드를 사용하는 인스턴스 생성자를 많이 사용한다.
             * 
             */


            /*소멸자
             * 소멸자는 생성자와 반대 개념으로 클래스에서 인스턴스화된 개체가 메모리상에서 없어질 때 실행되는 메서드이다.
             * 자동차 클래스를  예로들면 자동차 주차 대행, 시동 끄기 등으로 볼 수 있다.
             * 
             * 종료자
             * 종료자(Finalizer)라고도 하는 소멸자(Destructor)는 닷넷의 가비지 수집기(Garbage collector, GC)에서 클래스의 인스턴스를 사용한 후
             * 최종 정리할 떄 실행되는 가장 늦게 호출하는 메서드이다.
             * C#에서는 닷넷 가비지 수집기(GC)가 개체를 소멸할 때 메모리를 해제하는 등의 역할을 대신 해주기 때문에 이 책에서 소멸자에 접근할 일은 없다.
             * 
             * -자동차 시동을 끄는 것에 비유할 수 있으며 운전수가 주차하고 시동을 끄는 것이 아니라 주차요원(GC)이 대신 주차하고 시동을 끄는 것과 의미가 비슷하다.
             * -소멸자는 클래스 이름과 동일한 메서드로 앞에 물결 기호인~(틸드)를 붙여 만든다.
             * -소멸자도 특별한 형태의 메서드이다. 소멸자 또한 소멸자 메서드라고도 한다. 생성자와 달리 매개변수를 받을 수 없다.
             * -소멸자는 오버로딩을 지원하지 않으며 직접 호출할 수도 없다.
             */

            /*상속(Inheritance)
             * 클래스 간에는 부모와 자식 관계를 설정할 수 있다. 이러한 내용을 개체관계 프로그래밍(Object relationship programming)이라고도 한다.
             * 상속은 부모 클래스에 정의된 기능을 다시 사용하거나 확장 또는 수정하여 자식 클래스로 만드는 것이다.
             * 특정 클래스에서 만든 기능을 다른 클래스에 상속으로 물려주면 장점이 많이 있다.
             * 
             * 클래스 상속하기
             * 개체지향 프로그래밍의 장점 중 하나는 이미 만든 클래스를 재사용 하는 것이다. 이 재사용의 핵심개념이 상속이다.
             * 부모재산을 자식에게 상속하듯이 부모 클래스(기본클래스)의 모든 멤버를 자식클래스(파생클래스)가 재사용 하도록 허가하는 기능이다.
             * 여러 클래스 간의 관계를 설정할 때 수평관계가 아닌 부모와 자식 간 관계처럼 계층적인 관계를 표현할 때 사용하는 개념을 상속이라고 한다.
             * 클래스 상속은 단일 상속(Single Inheritance)과 다중상속(Multiple Inheritance)으로 구분할 수 있다.
             * 단,C#의 클래스 상속은 단일 상속만 지원한다. 다중상속은 나중에 배울 인터페이스로 지원 받을 수 있다.
             * 
             * 클래스 상속 구문
             * C#에서는 다음과 같이 클래스 이름 뒤에 콜론(;)기호와 부모가 되는 클래스 이름을 붙인다.
             * public class[기본 클래스 이름]
             * {
             *   //기본 클래스 멤버를 정의
             * }
             * public class[파생 클래스 이름] : [기본 클래스 이름]
             * {
             *  기본 클래스의 멤버를 포함한 자식 클래스의 멤버를 정의
             * }
             * 
             * -System.Object 클래스:System.Object 클래스는 모든 클래스의 부모 클래스이다.
             * 닷넷에서 가장 높은 계층에 속하는 시조(조상)클래스라고 할 수 있다. 
             * 새롭게 만드는 C#의 모든 클래스는 자동으로 Object 클래스에서 상속받기에 Object 클래스를 상속하는 모든 코드는 생략 가능하다.
             * 
             * -기본(Base)클래스:다른 클래스의 부모 클래스가 되는 클래스로 기본 클래스라고 한다.
             * 기본 클래스를 다른말로 Base클래스, Super클래스, 부모 클래스 라고도 한다.
             * 
             * -파생(Derived)클래스:다른 클래스의 자식 클래스가 되는 클래스를 파생 클래스라고 한다.
             * 파생 클래스는 다른 클래스에서 멤버를 물려받은 것으로, Dereved클래스, Sub클래스, 자식 클래스로 표현한다.
             * 
             * 부모클래스와 자식 클래스
             * 프로그래밍에서 상속을 표현할때 상속을 주는 클래스를 부모 클래스라고 하며 상속을 받는 클래스를 자식 클래스라고 한다.
             * 콜론(;)기호로 상속 관계를 지정하면 부모 클래스의 부모 클래스의 public멤버들을 자식 클래스에서 그래도 물려받아 사용할 수 있다.
             * public, protected로 선언된 멤버들도 자식 클래스에서 사용 가능하다.(private로 선언한 멤버는 상속이 안됨)
             * 
             * 
             */

            child child = new child();
            child.print();

            Dog Dog = new Dog();
            Dog.Turn();

            Zombie zombie = new Zombie();
            zombie.Turn();

            Cow cow = new Cow();
            cow.Turn();

            



            Poketmon001 Poketmon001 = new Poketmon001();
            Poketmon001.Skill1();


            Poketmon004 Poketmon004 = new Poketmon004();
            Poketmon004.Skill1();




        }//ValueTypeAndRefferenceType()
        public void WhatIsContructor()
        { }

    }//class

    class parent
    {
        public string stringValue = "stringValue ->부모 클래스의 멤버 변수";
        protected int intValue = 1234;
        private float floatValue = 3.14f;
        public void print()
        {
            Console.WriteLine("부모클래스의 멤버 호출");
        }
    }

    class child : parent
    {
        public void print()
        {
            Console.WriteLine("자식클래스의 멤버 호출");
            Console.WriteLine("부모클래스의 멤버 변수 호출:{0},{1}", base.stringValue, base.intValue);//private는 상속이 안됨

        }
    }

    class Monster
    {

        protected string name;
        protected int hp;
        protected int Damage;
        protected int defence;

        protected void Move() 
        {
            Console.WriteLine("{0}이/가 이동했다",name);
        }
        protected void Attack() 
        {
            Console.WriteLine("{0}이/가 {1}만큼의 타격을 줬다", this.name, (this.Damage-this.defence));
        }
        protected void MoveAndAttack()
        {
            this.Move();
            this.Attack();
        }


    }

    class Dog : Monster
    {
        public Dog()
        {
            this.name = "개";
            this.hp = 100;
            this.Damage = 100;
            this.defence = 10;
        }
    public void Turn()
        { 
        base.Move();
        base.Attack();
        }
    }

    class Zombie : Monster
    {
        public Zombie()
        {
            this.name = "좀비";
            this.hp = 200;
            this.Damage = 100;
            this.defence = 20;
        }
        public void Turn()
        {
            base.Move();
            base.Attack();
        }
    }

    class Cow : Monster
    {
        public Cow()
        {
            this.name = "소";
            this.hp = 300;
            this.Damage = 100;
            this.defence = 30;
        }
        public void Turn()
        {
            base.Move();
            base.Attack();
        }
    }
    class Poketmon
    {

        protected string name;
        protected int hp;
        protected int Damage;
        protected int defence;
        protected int specealDamage;
        protected int specealDefence;
        protected int speed;
        protected int gold;

        protected void Skill11()
        {
            Console.WriteLine("{0}의 공격{1}의 데미지를 입혔다", this.name, (this.Damage - this.defence));
        }
        protected void Skill22()
        {
            Console.WriteLine("{0}의 방어 {1}의 데미지를 입었다", this.name, (this.Damage - this.defence*2));
        }
        protected void Skill3()
        {
            this.Skill11();
        }
        protected void Skill4()
        {
            this.Skill22();
        }

    }
    class Poketmon001 : Poketmon
    {
        public Poketmon001()
        {
            this.name = "이상해씨";
            this.hp = 45;
            this.Damage = 49;
            this.defence = 49;
            this.specealDamage = 65;
            this.specealDefence = 65;
            this.speed= 45;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill2()
        {
            this.Skill4();
        }
    }
    class Poketmon004 : Poketmon
    {
        public Poketmon004()
        {
            this.name = "파이리";
            this.hp = 39;
            this.Damage = 52;
            this.defence = 43;
            this.specealDamage = 60;
            this.specealDefence = 50;
            this.speed = 65;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill2()
        {
            this.Skill4();
        }
    }

    class Poketmon007 : Poketmon
    {
        public Poketmon007()
        {
            this.name = "꼬부기";
            this.hp = 44;
            this.Damage = 48;
            this.defence = 65;
            this.specealDamage = 50;
            this.specealDefence = 64;
            this.speed = 43;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill2()
        {
            this.Skill4();
        }
    }

}