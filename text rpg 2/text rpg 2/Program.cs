using System;
using text_rpg_2;

namespace CSharp
{
    class Program
    {

        static Poketmon ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 이상해씨");
            Console.WriteLine("[2] 파이리");
            Console.WriteLine("[3] 꼬부기");

            Poketmon choice = Poketmon.None;
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    choice = Poketmon.이상해씨;
                    break;
                case "2":
                    choice = Poketmon.파이리;
                    break;
                case "3":
                    choice = Poketmon.꼬부기;
                    break;
            }

            return choice;
        }

        static void CreatePlayer(Poketmon choice)
        {
            Poketmon001 이상해씨 = new Poketmon001();
            Poketmon004 파이리 = new Poketmon004();
            Poketmon007 꼬부기 = new Poketmon007();

            
            switch (choice)
            {

                case Poketmon.이상해씨:
                    이상해씨.hp = 45;
                    이상해씨.Damage = 49;
                    이상해씨.defence = 49;
                    이상해씨.specealDamage = 65;
                    이상해씨.specealDefence = 65;
                    이상해씨.speed = 45;
                    break;
                case Poketmon.파이리:
                    파이리.hp = 45;
                    파이리.Damage = 49;
                    파이리.defence = 49;
                    파이리.specealDamage = 65;
                    파이리.specealDefence = 65;
                    파이리.speed = 45;
                    break;
                case Poketmon.꼬부기:
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

        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4); // 1 ~ 3 중 랜덤 정수 리턴

            switch(randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰 되었습니다!");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰 되었습니다!");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰 되었습니다!");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }

        static void Fight(ref Player player, ref Monster monster)
        {
            Poketmon004 Poketmon004 = new Poketmon004();
            
            while (true)
            {
                // 플레이어가 몬스터 공격
                monster.hp -= player.Damage;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine($"남은 체력 : {player.hp}");
                    break;
                }

                // 몬스터 반격
                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다!");
                    break;
                }
            }
        }

        static void EnterField(ref Player player)
        {
            Console.WriteLine("필드에 접속했습니다.");

            // 랜덤으로 1~3 몬스터 중 하나를 리스폰
            Monster monster;
            CreateRandomMonster(out monster);

            Console.WriteLine("[1] 전투 모드 돌입");
            Console.WriteLine("[2] 일정 확률로 마을로 도망");

            string input = Console.ReadLine();
            if (input == "1")
            {
                Fight(ref player, ref monster);
            }
            else if (input == "2")
            {
                // 33 %
                Random rand = new Random();
                int randValue = rand.Next(0, 101);
                if (randValue <= 33)
                {
                    Console.WriteLine("도망치는데 성공했습니다!");
                }
                else
                {
                    Fight(ref player, ref monster);
                }
            }

        }

        static void EnterGame(ref Player player)
        {
            while(true)
            {
                Console.WriteLine("마을에 접속했습니다.");
                Console.WriteLine("[1] 월드로 간다.");
                Console.WriteLine("[2] 로비로 돌아가기.");

                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        EnterField(ref player);
                        break;
                    case "2":
                        return;
                }
            }
        }

        static void Main(string[] args)
        {
            Poketmon001 이상해씨 = new Poketmon001();
            이상해씨.hp = 45;
            이상해씨.Damage = 49;
            이상해씨.defence = 49;
            이상해씨.specealDamage = 65;
            이상해씨.specealDefence = 65;
            이상해씨.speed = 45;
            



            while (true)
            {
                // 직업 고르기
                Poketmon choice;
                choice = ChooseClass(); // Program.ChooseClass();
                if (choice == Poketmon.None)
                    continue;

                // 플레이어 캐릭터 생성
                
                CreatePlayer(choice, out );
                Console.WriteLine($"HP{player.hp}, Attack{player.attack}");

                // 게임 시작! 몬스터 생성 및 전투
                EnterGame(ref player);
            }
        }
    }


}

