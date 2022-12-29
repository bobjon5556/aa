using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_rpg_2
{
    internal class Class1
    {


    }

    class Poketmon
    {

        public string name;
        public int hp;
        public int Damage;
        public int defence;
        public int specealDamage;
        public int specealDefence;
        public int speed;
        public int gold;

        protected void Skill11()
        {
            Console.WriteLine("{0}의 공격{1}의 데미지를 입혔다", this.name, (this.Damage - this.defence));
        }
        protected void Skill22()
        {
            Console.WriteLine("{0}의 방어 {1}의 데미지를 입었다", this.name, (this.Damage - this.defence * 2));
        }
        protected void Skill3()
        {
            this.Skill11();
        }
        protected void Skill4()
        {
            this.Skill22();
        }

    }
    class Poketmon001 : Poketmon
    {
        public Poketmon001()
        {
            this.name = "이상해씨";
            this.hp = 45;
            this.Damage = 49;
            this.defence = 49;
            this.specealDamage = 65;
            this.specealDefence = 65;
            this.speed = 45;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill2()
        {
            this.Skill4();
        }

    }
    class Poketmon004 : Poketmon
    {
        public Poketmon004()
        {
            this.name = "파이리";
            this.hp = 39;
            this.Damage = 52;
            this.defence = 43;
            this.specealDamage = 60;
            this.specealDefence = 50;
            this.speed = 65;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill2()
        {
            this.Skill4();
        }
    }
    class Poketmon007 : Poketmon
    {
        public Poketmon007()
        {
            this.name = "꼬부기";
            this.hp = 44;
            this.Damage = 48;
            this.defence = 65;
            this.specealDamage = 50;
            this.specealDefence = 64;
            this.speed = 43;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill2()
        {
            this.Skill4();
        }
    }
    class Poketmon010 : Poketmon
    {
        public Poketmon010()
        {
            this.name = "캐터피";
            this.hp = 45;
            this.Damage = 30;
            this.defence = 35;
            this.specealDamage = 20;
            this.specealDefence = 20;
            this.speed = 45;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill2()
        {
            this.Skill4();
        }
    }
    class Poketmon013 : Poketmon
    {
        public Poketmon013()
        {
            this.name = "뿔충이";
            this.hp = 40;
            this.Damage = 35;
            this.defence = 30;
            this.specealDamage = 20;
            this.specealDefence = 20;
            this.speed = 50;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill4()
        {
            this.Skill4();
        }
    }

    class Poketmon016 : Poketmon
    {
        public Poketmon016()
        {
            this.name = "구구";
            this.hp = 40;
            this.Damage = 45;
            this.defence = 40;
            this.specealDamage = 35;
            this.specealDefence = 35;
            this.speed = 56;
        }
        public void Skill1()
        {
            this.Skill3();
        }
        public void Skill2()
        {
            this.Skill4();
        }
    }
}


