using System;

namespace Warrior
{
    public class Warrior
    {
        public double hp = 100;
        public double damage;
        public virtual void Damage()
        {
            double ResHp = hp - damage;
            hp = ResHp;
            Console.WriteLine(ResHp + "\n");
        }
    }

    class EasyWarrior : Warrior
    {
        public override void Damage()
        {
            double ResHp = hp - damage;
            hp = ResHp;
            Console.WriteLine(ResHp + "\n");
        }
    }

    class BasicWarrior : Warrior
    {
        public override void Damage()
        {
            double ResHp = hp - (damage / 1.5);
            hp = ResHp;
            Console.WriteLine(ResHp + "\n");
        }
    }

    class HardWarrior : Warrior
    {
        public override void Damage()
        {
            double ResHp = hp - (damage / 2);
            hp = ResHp;
            Console.WriteLine(ResHp + "\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            EasyWarrior EW = new EasyWarrior();
            BasicWarrior BW = new BasicWarrior();
            HardWarrior HW = new HardWarrior();
        re:
            int vblbor = Convert.ToInt32(Console.ReadLine());
            if (vblbor == 1)
            {
                int Damage = Convert.ToInt32(Console.ReadLine());
                EW.damage = Damage;
                EW.Damage();
               
            }
            if (vblbor == 2)
            {
                int Damage = Convert.ToInt32(Console.ReadLine());
                BW.damage = Damage;
                BW.Damage();
            }
            if (vblbor == 3)
            {
                int Damage = Convert.ToInt32(Console.ReadLine());
                HW.damage = Damage;
                HW.Damage();
            }
            goto re;
        }
    }
}