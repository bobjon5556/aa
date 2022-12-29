using text_rpg_2;

namespace 모험가_이야기1
{





    internal class Program
    {
       

        static void CreatePlayer(int choice)
        {
            Poketmon001 이상해씨 = new Poketmon001();
            Poketmon004 파이리 = new Poketmon004();
            Poketmon007 꼬부기 = new Poketmon007();



            switch (choice)
            {

                case 1:Console.WriteLine("당신은 {0}를 선택하셨습니다.",이상해씨.name);
                    이상해씨.hp = 45;
                    이상해씨.Damage = 49;
                    이상해씨.defence = 49;
                    이상해씨.specealDamage = 65;
                    이상해씨.specealDefence = 65;
                    이상해씨.speed = 45;
                    break;
                case 2:Console.WriteLine("당신은 {0}를 선택하셨습니다.");
                    파이리.hp = 45;
                    파이리.Damage = 49;
                    파이리.defence = 49;
                    파이리.specealDamage = 65;
                    파이리.specealDefence = 65;
                    파이리.speed = 45;
                    break;
                case 3:Console.WriteLine("당신은 꼬부기를 선택하셨습니다.");
                    꼬부기.hp = 45;
                    꼬부기.Damage = 49;
                    꼬부기.defence = 49;
                    꼬부기.specealDamage = 65;
                    꼬부기.specealDefence = 65;
                    꼬부기.speed = 45;
                    break;
                default:

                    break;
            }
        }




        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            {
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("[1] 이상해씨");
                Console.WriteLine("[2] 파이리");
                Console.WriteLine("[3] 꼬부기");

                string input1 = Console.ReadLine();
                int choice = Convert.ToInt32(input1);
                
                CreatePlayer(choice);



                    while (true)
                    {

                        Console.WriteLine("기사입니다{0} 적의 체력{1}", 이상해씨.hp, 구구.hp);
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
