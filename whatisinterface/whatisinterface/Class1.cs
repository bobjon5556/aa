using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatisinterface
{
    internal class Class1
    {

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
    }


}
