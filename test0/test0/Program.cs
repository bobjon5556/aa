namespace test0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                int userinput = 0;


                userinput = int.Parse(Console.ReadLine());

                for (int a = 0; a < userinput; a++)

                {
                    for (int b = 0; b < (userinput - a - 1); b++)
                    {
                        Console.Write(" ");
                    }
                    for (int e = 0; e <= a; e++)
                    {

                        Console.Write("*");

                    }
                        for (int f = 0; f < a; f++)
                        {

                            Console.Write("*");

                        }
                        Console.WriteLine();


                    


                }

            }

        }
    }
}