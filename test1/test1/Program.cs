using Microsoft.VisualBasic;
using System;
using System.Diagnostics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int[] puzzle = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };



            

            int input = 0;

            for (int i = puzzle.Length - 1; i > 0; i--)
            {
                int randomIndex = rand.Next(0, i + 1);

                int temp = puzzle[i];
                puzzle[i] = puzzle[randomIndex];
                puzzle[randomIndex] = temp;

                Console.WriteLine(temp);
            }
;

            int[] puzzle2= { 8, 7, 5, 1, -1, 4, 6, 2, 3 };
            int emptyTile = -1;
            int numberInverions = 0;
            for (int i = 0; i < puzzle2.Length - 1; i++)
            {
                if (puzzle[i] == emptyTile)
                    continue;

                for (int j = i + 1;  puzzle[j]) && (puzzle[j] != emptyTile))
            numberInverions++;
        }
    }





}
    
