using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg게임레퍼런스
{
    class Program
    {
        enum Forest1_MonsterType
        {
            Fox = 0,
            Rabbit = 1,
            Bully = 2
        }

        struct Monster
        {
            // 몬스터 이름
            public string NAME;
            // 몬스터 레벨
            public int LV;
            // 몬스터 타입(0 : 동물형 , 1 : 인간형)
            public byte TYPE;
            // 몬스터 공격력
            public int ATT;
            // 몬스터 방어력
            public int DEF;
            // 몬스터 근력
            public int STR;
            // 몬스터 민첩
            public int DEX;
            // 몬스터 체력
            public int MAX_HP;
            public int HP;
            // 몬스터 내공
            public int MAX_MP;
            public int MP;
            // 몬스터 사망시 경험치
            public int EXP;

        }

        static Monster CreateMonster() {

            Random rand = new Random();
            int SpawnMonster = rand.Next(10001);
            Monster mon;
            switch (SpawnMonster / 4500)
            {
                case (int)Forest1_MonsterType.Rabbit:
                    mon.NAME = "토끼";
                    mon.LV = 2 + rand.Next(-1, 2);
                    mon.TYPE = 0;
                    mon.ATT = 11 + (mon.LV * 2);
                    mon.DEF = 9 + (mon.LV * 2);
                    mon.STR = 3 + (mon.LV * 2);
                    mon.DEX = 8 + (mon.LV * 2);
                    mon.MAX_HP = 70 + (rand.Next(11) * mon.LV);
                    mon.HP = mon.MAX_HP;
                    mon.MAX_MP = 0;
                    mon.MP = 0;
                    mon.EXP = 125 + (10 * mon.LV);
                    Console.WriteLine("야생의 토끼가 나타났다...! LV: " + mon.LV);
                    break;

                case (int)Forest1_MonsterType.Bully:
                    mon.NAME = "양아치";
                    mon.LV = 4 + rand.Next(-1, 2);
                    mon.TYPE = 1;
                    mon.ATT = 16 + (mon.LV * 2);
                    mon.DEF = 16 + (mon.LV * 2);
                    mon.STR = 11 + mon.LV;
                    mon.DEX = 8 + mon.LV;
                    mon.MAX_HP = 150 + (rand.Next(11) * mon.LV);
                    mon.HP = mon.MAX_HP;
                    mon.MAX_MP = 0;
                    mon.MP = 0;
                    mon.EXP = 330 + (10 * mon.LV);
                    Console.WriteLine("뭔가 허접해 보이는 양아치가 나타났다...! LV: " + mon.LV);
                    break;
                
                default:
                    mon.NAME = "여우";
                    mon.LV = 2 + rand.Next(-1, 2);
                    mon.TYPE = 0;
                    mon.ATT = 8 + (mon.LV * 2);
                    mon.DEF = 13 + (mon.LV * 2);
                    mon.STR = 4 + (mon.LV * 2);
                    mon.DEX = 7 + (mon.LV * 2);
                    mon.MAX_HP = 80 + (rand.Next(11) * mon.LV);
                    mon.HP = mon.MAX_HP;
                    mon.MAX_MP = 0;
                    mon.MP = 0;
                    mon.EXP = 130 + (10 * mon.LV);
                    Console.WriteLine("야생의 여우가 나타났다...! LV: " + mon.LV);

                    break;

            }
            return mon;
        }
        struct Player
        {
            //플레이어 이름
            public string NAME;
            //플레이어 레벨
            public byte LV;
            //플레이어 체력
            public int MAX_HP;
            public int HP;
            // 플레이어 내공
            public int MAX_MP;
            public int MP;
            // 플레이어 근력
            public int STR;
            // 플레이어 민첩
            public int DEX;
            // 플레이어 오성(레벨 업 포인트로 부여 불가)
            public int INT;
            // 플레이어 행운(레벨 업 포인트로 부여 불가)
            public int LUK;
            // 플레이어 공격력
            public int ATT;
            // 플레이어 방어력
            public int DEF;
            // 추가 능력치
            public int STAT;
            // 레벨업 필요 경험치
            public int EXP;

        }

        static void ShowStatus(ref Player user)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("* 이름 : " + user.NAME);
            Console.WriteLine("* 레벨 : " + user.LV);
            Console.WriteLine("* 체력 : " + user.HP + "/" + user.MAX_HP);
            Console.WriteLine("* 내공 : " + user.MP + "/" + user.MAX_MP);
            Console.WriteLine("* 근력 : " + user.STR);
            Console.WriteLine("* 민첩 : " + user.DEX);
            Console.WriteLine("* 오성 : " + user.INT);
            Console.WriteLine("* 행운 : " + user.LUK);
            Console.WriteLine("* 공격력 : " + user.ATT);
            Console.WriteLine("* 방어력 : " + user.DEF);
            Console.WriteLine("* 잔여 능력치 : " + user.STAT);
            Console.WriteLine("* 다음 레벨 필요 경험치 : " + user.EXP);
            Console.WriteLine("-----------------------------\n");
            if (user.STAT > 0)
            {
                Console.WriteLine("*능력치를 부여 할 수 있습니다*");
                Console.WriteLine("[1]. 능력치부여");

                // sel1 능력치 부여 선택
                string sel1 = "0";
                // sel2 능력치 부여 종료 선택
                string sel2 = "0";
                // sel3 능력치 투자 선택
                int sel3 = 0;

                sel1 = Console.ReadLine();
                if (sel1 == "1")
                {
                    while (sel2 == "0")
                    {
                        Console.WriteLine("현재 " + user.STAT + "개의 능력치가 있습니다.");

                        int Plus_Status;
                        do
                        {
                            Console.WriteLine("얼마나 투자하시겠습니까?");
                            Plus_Status = int.Parse(Console.ReadLine());
                        } while (Plus_Status <= 0 || Plus_Status > user.STAT);


                        Console.WriteLine(Plus_Status + "개의 능력치를 어디에 추가하시겠습니까?");
                        Console.WriteLine("[1]. 근력에 추가");
                        Console.WriteLine("[2]. 민첩에 추가");
                        Console.WriteLine("[3]. 체력에 추가");
                        Console.WriteLine("[4]. 내공에 추가");
                        Console.WriteLine("[-]. 다시");

                        sel3 = int.Parse(Console.ReadLine());

                        switch (sel3)
                        {
                            case 1:
                                user.STR += Plus_Status;
                                user.ATT += Plus_Status;
                                user.DEF += (Plus_Status/3);
                                user.STAT -= Plus_Status;
                                break;
                            case 2:
                                user.DEX += Plus_Status;
                                user.STAT -= Plus_Status;
                                break;
                            case 3:
                                user.MAX_HP += Plus_Status;
                                user.STAT -= Plus_Status;
                                break;
                            case 4:
                                user.MAX_MP += Plus_Status;
                                user.STAT -= Plus_Status;
                                break;
                            default:
                                Console.WriteLine("잘못된 입력. 능력치 부여로 돌아갑니다.");
                                break;
                        }
                        Console.WriteLine("능력치 부여를 그만하시겠습니까?");
                        Console.WriteLine("[1]. 네");
                        Console.WriteLine("[2]. 아니요 (계속)"); ;

                        int sel4 = int.Parse(Console.ReadLine());

                        while (sel4 != 1 && sel4 != 2)
                        {
                            Console.WriteLine("다시 입력해주세요...");
                            sel4 = Console.Read();
                        }

                        if (sel4 == 1)
                            break;
                        if (sel4 == 2 && user.STAT == 0)
                        {
                            Console.WriteLine("남은 스테이터스가 없습니다...");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("상태창을 종료합니다.");
                }
            }
        }

        static Player CreatePlayer()
        {
            Random rand = new Random();
            Boolean end_sig = false;
            byte cnt = 4;

            Player user;
            Console.WriteLine("무협 온라인에 온 것을 환영합니다.");
            
            Console.WriteLine("당신의 이름은?");
            user.NAME = Console.ReadLine();

            Console.Write(user.NAME);
            Console.WriteLine("... 좋은 이름이네요.\n 당신의 육체를 구성합니다...");
            user.STAT = 0;
            user.EXP = 1000;

            do
            {
                user.LV = 1;
                user.MAX_HP = 100 + rand.Next(-50, 51);
                user.HP = user.MAX_HP;
                user.MAX_MP = 100 + rand.Next(-50, 51);
                user.MP = user.MAX_MP;
                user.STR = 10 + rand.Next(-5, 6);
                user.DEX = 10 + rand.Next(-5, 6);
                user.INT = 10 + rand.Next(-9, 10);
                user.LUK = 10 + rand.Next(-10, 11);
                user.ATT = 10 + user.STR;
                user.DEF = 0 + (user.STR / 5);

                Console.WriteLine("완료되었습니다.\n 당신의 육체는 아래와 같습니다...");
                ShowStatus(ref user);
                while (cnt > 0)
                {
                    Console.WriteLine(cnt + "번의 재구성 기회가 남아있습니다. \n[1]. 이대로 하겠습니다.\n[2]. 뭐야, 내 육체 돌려줘요");
                    string temp = Console.ReadLine();
                    if(temp == "1")
                    {
                        end_sig = true;
                        break;
                    }
                    else if(temp == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                    }
                }
                
            } while (end_sig == false && cnt-- > 0);

            user.STAT = 10;
            Console.WriteLine("육체 구성이 완료되었습니다... 게임을 시작합니다.");


            return user;
        }
        static void PlayerHome(ref Player user)
        {
            Console.WriteLine("----------------집----------------");
            Console.WriteLine("|깔끔하게 정돈되어 있는 방이다...|");
            Console.WriteLine("|무엇을 하시겠습니까?            |");
            Console.WriteLine("|[1]. 휴식 (체력/내공 전회복)    |");
            Console.WriteLine("|[2]. 이동 (숲 초입)             |");
            Console.WriteLine("|[3]. 상태창 확인                |");
            Console.WriteLine("----------------------------------");

            string sel = "0";
            while(sel == "0")
            {
                sel = Console.ReadLine();
                if(sel == "1")
                {
                    user.HP = user.MAX_HP;
                    user.MP = user.MAX_MP;
                    Console.WriteLine("... 몸의 피로가 모두 회복되었다!");
                    PlayerHome(ref user);
                }
                else if(sel == "2")
                {
                    Console.WriteLine("숲 초입으로 이동합니다...");
                    Forest1(ref user);
                    break;
                }
                else if (sel == "3")
                {
                    ShowStatus(ref user);
                    PlayerHome(ref user);
                    break;
                }
                Console.WriteLine("잘못된 입력입니다.");
            }

        }

        static void Forest1(ref Player user)
        {
            Console.WriteLine("--------------숲 초입--------------");
            Console.WriteLine("|곳곳에 여우와 토끼가 보인다...   |");
            Console.WriteLine("|가끔 양아치가 나타난다고 한다... |");
            Console.WriteLine("|[1]. 사냥하기                    |");
            Console.WriteLine("|[2]. 이동(집)                    |");
            Console.WriteLine("----------------------------------|");

            int sel = 0;

            while (sel == 0)
            {
                sel = int.Parse(Console.ReadLine());
                if (sel == 1)
                {
                    Monster mon = CreateMonster();
                    user.EXP -= Fight(ref user, mon);
                    if(user.EXP < 0)
                    {
                        Console.WriteLine("\n\n\n...! 몸이 간질간질한 기분이 든다...!");
                        Console.WriteLine("축하합니다! 레벨업하셨습니다! 스테이터스 5개가 주어집니다!");
                        user.STAT += 5;
                        user.EXP = 1000;

                    }
                    Forest1(ref user);

                }
                else if (sel == 2)
                {
                    Console.WriteLine("집으로 이동합니다...");
                    PlayerHome(ref user);
                    break;
                }
                Console.WriteLine("잘못된 입력입니다.");
            }
            Forest1(ref user);

        }
        static void Cal_Critical(Player user, Monster mon, out int UserCri, out int MonCri) {

            if ((user.DEX - mon.DEX) > 0)
            {
                UserCri = (((user.DEX - mon.DEX) * 70) / mon.DEX) + 5 + (user.DEX / (user.LV * 10));
                MonCri = 5 + (mon.DEX / (mon.LV * 10));

            }
            else
            {
                MonCri = (((mon.DEX - user.DEX) * 70) / user.DEX) + 5 + (mon.DEX / (mon.LV * 10));
                UserCri = 5 + (user.DEX / (user.LV * 10));
            }
        }
        static void Cal_Dodge(Player user, Monster mon, out int UserDodge, out int MonDodge)
        {

            if ((user.DEX - mon.DEX) > 0)
            {
                UserDodge = (((user.DEX - mon.DEX) * 50) / mon.DEX) + 3 + (user.DEX / (user.LV * 10));
                MonDodge = 3 + (mon.DEX / (mon.LV * 10));

            }
            else
            {
                MonDodge = (((mon.DEX - user.DEX) * 50) / user.DEX) + 3 + (mon.DEX / (mon.LV * 10));
                UserDodge = 3 + (user.DEX / (user.LV * 10));
            }
        }



        static int Fight(ref Player user, Monster mon) {
            Random rand = new Random();

            // 공격자 정하기 false = 몬스터 공격 , true = 유저 공격
            Boolean Order_ATTACK = false;
            // 유저 방어 선택시 1턴 방어력 증가
            Boolean DEF_TURN = false;
            // 유저 회피 선택시 1턴 회피 증가
            Boolean DODGE_TURN = false;


            //크리티컬율
            int UserCRI;
            int MonCRI;

            //회피율
            int UserDODGE;
            int MonDODGE;

            Cal_Critical(user, mon, out UserCRI, out MonCRI);
            Cal_Dodge(user, mon, out UserDODGE, out MonDODGE);

            //Start Fight

            //선공 (민첩이 높은 쪽이 우선공)
            Order_ATTACK = user.DEX > mon.DEX;

            while (true)
            {
                int PUC = rand.Next(1, 101); //유저 크리티컬 확률
                int PUD = rand.Next(1, 101); //유저 회피 확률
                int PMC = rand.Next(1, 101); //몬스터 크리티컬 확률
                int PMD = rand.Next(1, 101); //몬스터 회피 확률

                Console.WriteLine("\n\n사용자 체력 "+user.HP + "/" + user.MAX_HP);
                Console.WriteLine("몬스터 체력 "+mon.HP + "/" + mon.MAX_HP);
                //유저 공격
                if (Order_ATTACK)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("|내 차례다... 어떻게 할까?       |");
                    Console.WriteLine("|[1]. 공격                       |");
                    Console.WriteLine("|[2]. 수비                       |");
                    Console.WriteLine("|[3]. 회피                       |");
                    Console.WriteLine("|[4]. 도망                       |");
                    Console.WriteLine("----------------------------------");

                    int sel = 0;
                    do
                    {
                        sel = int.Parse(Console.ReadLine());
                    } while (sel < 1 && sel > 4);

                    switch (sel)
                    {
                        case 1:
                            //공격
                            Console.WriteLine("\n\n공격을 시작한다... (공격력 : "+user.ATT+")");
                            // 몬스터가 회피에 성공했을시
                            if (PMD < MonDODGE)
                            {
                                Console.WriteLine("이런! " + mon.NAME + "이(가) 내 공격을 피해버렸다!");
                            }
                            else if (PUC < UserCRI)
                            {
                                Console.WriteLine("빈틈이다! " + mon.NAME + "는(은) " + (user.ATT * 2 - mon.DEF) + "의 피해를 입었다.");
                                mon.HP -= (user.ATT * 2 - mon.DEF);
                            }
                            else
                            {
                                Console.WriteLine(mon.NAME + "는(은) " + (user.ATT - mon.DEF) + "의 피해를 입었다.");
                                mon.HP -= (user.ATT - mon.DEF);
                            }
                            break;
                        case 2:
                            //수비
                            Console.WriteLine("\n\n방어 자세를 잡는다...(다음턴 방어력 2배)");
                            DEF_TURN = true;
                            user.DEF *= 2;
                            break;
                        case 3:
                            //회피
                            Console.WriteLine("\n\n회피 자세를 잡는다...(다음턴 회피력 2배)");
                            DODGE_TURN = true;
                            UserDODGE *= 2;
                            break;
                        case 4:
                            //도망
                            if(PUD < UserDODGE)
                            {
                                Console.WriteLine("\n\n전투에서 도망치는것에 성공했다!!");
                                return 0;
                            }
                            else
                            {
                                Console.WriteLine("\n\n...도망치는것에 실패했다...!");
                            }
                            break;
                    }
                }//몬스터 공격
                else
                {
                    Console.WriteLine("\n\n"+mon.NAME+"이(가) 공격해온다...!");
                    if (PUD < UserDODGE)
                    {
                        Console.WriteLine("... 느려. (공격을 피했다!)");
                    }
                    else if (PUC < UserCRI)
                    {
                        Console.WriteLine("!!! 방심했다..." + (mon.ATT * 2 - user.DEF) + "의 피해를 입었다.");
                        user.HP -= (mon.ATT * 2 - user.DEF);
                    }
                    else
                    {
                        Console.WriteLine("간지럽다... " + (mon.ATT - user.DEF) + "의 피해를 입었다.");
                        user.HP -= (mon.ATT - user.DEF);
                    }

                    if (DEF_TURN)
                    {
                        DEF_TURN = false;
                        user.DEF /= 2;
                    }
                    if (DODGE_TURN)
                    {
                        DODGE_TURN = false;
                        UserDODGE /= 2;
                    }
                }
                if (Order_ATTACK)
                    Order_ATTACK = false;
                else
                    Order_ATTACK = true;

                if(mon.HP <= 0)
                {
                    Console.WriteLine("... 해치웠나...?");
                    Console.WriteLine(mon.NAME+"와(과)의 전투에서 승리했습니다! 경험치 "+mon.EXP+"을(를) 획득했습니다!");
                    return mon.EXP;
                }
                else if(user.HP <= 0)
                {
                    Console.WriteLine("좋은... 인생이었다...");
                    Console.WriteLine(mon.NAME+"와(과)의 전투에서 패배했다... 집으로 돌아갑니다...");
                    user.HP = 5;
                    PlayerHome(ref user);
                }
            }
            
            
        
        }
        static void Main(string[] args)
        {
            //캐릭터 생성
            Player User = CreatePlayer();
            PlayerHome(ref User);

        }
    }
}