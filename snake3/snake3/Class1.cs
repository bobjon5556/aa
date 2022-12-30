using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake3
{
    internal class Class1
    {


    }


    public class CreateCoin
    {

        static void coin()
        {
            Random rand = new Random();

            int x1 = rand.Next(1, 5);
            int x2 = rand.Next(1, 5);

            int[] x3 = new int[5];
            int[] y3 = new int[5];
            int[,] zy3 = new int[x1, x2];
            int[,] gameBoard1 = new int[x1, x2];
        }
    }
}
