namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.Write("원의 반지름 : ");
                int i = int.Parse(Console.ReadLine());
                double d = i * 3.14;
                Console.WriteLine(i + 1 * Math.PI * d*d );

            }
        }
    }
}