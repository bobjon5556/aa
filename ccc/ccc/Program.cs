using Microsoft.VisualBasic;
using System;

namespace ccc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int num;
            num = 5;
            int userInput = 0;

            string[] strings1 = new string[5] { "ㅁ","ㅁ","ㅁ", "ㅁ","ㅁ" };
            string[] strings2 = new string[5] { "ㅁ", "*", "*", "*", "ㅁ" };
            string[] strings3 = new string[5] { "ㅁ", "*", "옷", "*", "ㅁ"};
            string[] strings4 = new string[5] { "ㅁ", "*", "*", "*", "ㅁ" };
            string[] strings5 = new string[5] { "ㅁ","ㅁ","ㅁ", "ㅁ","ㅁ" };

            Console.WriteLine(strings1);
            Console.WriteLine(strings2);
            Console.WriteLine(strings3);
            Console.WriteLine(strings4);
            Console.WriteLine(strings5);



            for (i = 0; i < num; i++)
            {
                for (j = 0; j < (num - i - 1); j++)
                {
                    Console.Write("ㅁ");
                }
                for (k = 0; k <= i; k++)
                {
                    Console.Write("ㅁ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("이동방향을 입력하세요(wasd)");
            int.TryParse(Console.ReadLine(), out userInput);



            


        }
    }
}