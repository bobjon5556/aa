namespace 모험가_이야기1
{





    internal class Program
    {


        class open
        { }
        class close
        { }


        class tron
        { }



        static void Main(string[] args)
        {

            int 체력 = 100;
            int 방어력 = 20;
            int 공격력 = 20;

            int 적체력 = 50;
            int 적방어력 = 10;
            int 적공격력 = 10;

            int 선택 = 0;
            int 임시 = 0;


            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            {
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 궁수");
                Console.WriteLine("[3] 전사");

                string input1 = Console.ReadLine();
                int choice = Convert.ToInt32(input1);

                for (; ; )
                {
                    if (choice > 0)
                    {
                        switch (input1)
                        {
                            case "1":
                                Console.WriteLine("기사입니다");
                                break;
                            case "2":
                                Console.WriteLine("궁수입니다");
                                break;
                            case "3":
                                Console.WriteLine("전사입니다");
                                break;
                        }

                    }



                    while (true)
                    {

                        Console.WriteLine("기사입니다{0} 적의 체력{1}", 체력, 적체력);
                        Console.WriteLine("1.공격합니다.");
                        Console.WriteLine("2.방어합니다.");

                        string input2 = Console.ReadLine();

                        switch (input2)
                        {
                            case "1":
                                Console.WriteLine("공격합니다");
                                Console.WriteLine("남은 적의 체력");
                                Console.WriteLine(적체력 -= (공격력 - (적방어력 / 2)));

                                break;

                            case "2":
                                Console.WriteLine("방어합니다.");
                                Console.WriteLine("남은 당신의 체력");
                                Console.WriteLine(체력 -= (적공격력 - (방어력 / 2)));

                                break;



                        }

                        if (적체력 < 1)
                        {
                            Console.WriteLine("전투에서 승리했습니다.");
                            break;
                        }
                        else if(체력<1)
                        {
                            Console.WriteLine("전투에서 패배했습니다.");
                            break;
                        }


                        break;
                    }
                    

                }
            }


        }

    }
}
