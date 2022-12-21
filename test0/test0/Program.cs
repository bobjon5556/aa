namespace test0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                int a = 0;
                int b = 0;
                int userinput= 0;


                userinput = int.Parse(Console.ReadLine());

                for (int c = 0; c < userinput; c++)

                {
                    for (int d = 0; d <= c; d++)
                    {
                        Console.Write("*");


                    }
                    Console.WriteLine();
                }

               
            }

        }
        
    }
}