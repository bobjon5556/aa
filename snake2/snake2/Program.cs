using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var sum = 0;
        {
            for (int i = 1; i <= 100; i++)

                if (i % 2 == 0 || i % 3== 0)
                    sum += i;

        }
        Console.WriteLine(sum);


        {
            for (int y = 1; y <= 9; y++)
            {
                for (int x = 2; x <= 9; x++)
                {
                    Console.Write("{0} X {1} = {2,2}  ", x, y, x * y);
                }
                Console.WriteLine();
            }
        }
    }


}


   