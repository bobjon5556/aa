using Microsoft.VisualBasic;
using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int N = Convert.ToInt32(Console.ReadLine());

            bool[] selected = Enumerable.Repeat<bool>(false, N).ToArray<bool>();
            int selectedCnt = 0;

            while (selectedCnt < N)
            {
                int a = random.Next(0, N); // 1에서 N-1까지
                if (selected[a] == true)
                {
                    continue;
                }

                Console.Write($"{a} ");
                selected[a] = true;
                selectedCnt++;
            }
        }

    }
            
        
}
           
    

       

    
