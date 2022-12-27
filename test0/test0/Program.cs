using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Program1
    {

        static void Main()
        {
            string[,] stringArray = new string[3, 3];

            stringArray[0, 0] = "1";
            stringArray[0, 1] = "2";
            stringArray[0, 2] = "3";
            stringArray[1, 0] = "4";
            stringArray[1, 1] = "5";
            stringArray[1, 2] = "6";
            stringArray[2, 0] = "7";
            stringArray[2, 1] = "8";
            stringArray[2, 2] = "X";

            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("{0}", stringArray[0, i]);
                }
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("{0}", stringArray[1, i]);
                }
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("{0}", stringArray[2, i]);
                }
                Console.WriteLine();

                break;

                
                
            }
            Console.WriteLine("키를 입력해주세요");



            
        }


        

    }
}

