using System.Drawing;
using System.Xml.Linq;
using System;


public class Monster 
{
    public void main()
    {
        int i, j, k;
        int num;
        num = int.Parse(Console.ReadLine());

        for (i = 0; i < num; i++)
        {
            for (j = 0; j < (num - i - 1); j++)
            {
                Console.Write(" ");
            }
            for (k = 0; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
}

