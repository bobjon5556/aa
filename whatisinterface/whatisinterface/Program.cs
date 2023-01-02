namespace whatisinterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car mycar = new Car();

            Class3 disc= new Class3();

            Console.WriteLine(disc);






        }//main
       
    }
    /*
     *-인터페이스는 인스터스화 되지 않는다. 클래스를 사용해서 인스턴스화 한다.
     *-인터페이스는 계약 의미가 강하며 속성, 메서드, 이벤트 인덱서 등 구조를 미리 정의한다.
     */


    /*
     * 인터 페이스를 사용한 다중 상속 구현하기
     * 다중 상속은 클래스 하나를 콤마로 구분해서 인터페이스 하나 이상을 상속하는 것을 의미한다.
     * C#에서 클래스는 클래스에 대한 단일 상속만 지원하는 대신 인터 페이스는 클래스에 인터페이스 하나 이상 상속할 수 있다.
     * 
     * */

    /*
     * 인터페이스와 추상 클래스 비교하기
     * 
     * 추상클래스
     * -구현된 코드가 들어온다 즉, 메서드 시그니처만 있는 것이 아니라 사용가능한 실제로 구현된 메서드가 들어온다.
     * -단일 상속:기본 클래스에서 상속될 수 있다.
     * -각 멤버는 엑세스 한정자를 갖는다.
     * -핑드, 속성, 생성자,소멸자,메서드,인벤트,인덱서 등을 갖는다.
     * 
     * 인터페이스
     * -인터페이스는 규약이다.
     * -구현된 코드가 없다.
     * -다중상속:여러가지 인터페이스에서 상속 가능하다.
     * -모든 멤버는 자동으로 public 이다.
     * -속성, 메서드, 이벤트와 대리자(함수를 변수에 담은것)를 멤버로 갖는다.
     * 
     * 
     */

    interface ICar
    {
        public void Go();
    }

    class Car : ICar
    {
        public virtual void Go()
        {
            Console.WriteLine("자동차가 앞으로 간다");
            Console.WriteLine("{0}", "인터페이스를 사용할 떄는 정의된 모든 멤버를 반드시 구현해야 한다.");
        }
    }//car Icar
    class Sotnta : Car
    {
        public override void Go()
        {
            Console.WriteLine("소나타가 앞으로 간다.");
        }
    }

    interface IAnimal
    {
        void Eat();
    }

    interface IDog
    {
        void Yelp();
    }

    class Dog : IAnimal, IDog
    { 
    public void Eat() 
        {
            Console.WriteLine("먹다");
        }

        public void Yelp()
        {
            Console.WriteLine("짖다");
        }
    }

}//namespace





    