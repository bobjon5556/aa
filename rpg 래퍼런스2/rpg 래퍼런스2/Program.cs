using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5
{
    class MyClass
    {
        public int Year, Month, Day;
        public void Print()
        {
            Console.WriteLine("{0}년 {1}월 {2}일", Year, Month, Day);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass();  //생성
            MyTest.Year = 2018;
            MyTest.Month = 2;
            MyTest.Day = 24;
            MyTest.Print();
        }
    }
}