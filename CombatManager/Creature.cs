using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager
{
    public class Creature : Skills, ICreature
    {
        private string Name;
        private int WW;
        private int US;
        private int Wt;
        private int St;
        private int Zyw;
        private int Dex;
        private int ActZyw;
        private RollingDie Hit;
        private RollingDie Damage;
        private int WeaponStrength; //wydzielic jako klase
        private int RangedWeaponStrength; //Wydzielić jako klase

        public int St1 { get => St; set => St = value; }
        public int Dex1 { get => Dex; set => Dex = value; }
        internal RollingDie Damage1 { get => Damage; set => Damage = value; }
        public int WW1 { get => WW; set => WW = value; }
        public int US1 { get => US; set => US = value; }
        public int WeaponStrength1 { get => WeaponStrength; set => WeaponStrength = value; }

        public Creature(string Name, int WW, int US, int Wt, int St, int Zyw, int Dex, RollingDie Hit, RollingDie Damage)
        {
            this.Name = Name;
            WW1 = WW;
            US1 = US;
            this.Wt = Wt;
            St1 = St;
            this.Zyw = Zyw;
            ActZyw = Zyw;
            Dex1 = Dex;
            this.Hit = Hit;
            Damage1 = Damage;
            WeaponStrength1 = WeaponStrength;
        }

        public override string ToString()
        {
            return Name;
        }

        public bool CriticalHit()
        {
            return (ActZyw > 0);
        }

        public string PrintZyw()
        {
            string s = "[";
            int total = 20;
            double count = Math.Round(((double)ActZyw/Zyw)*total);
            if (CriticalHit() && count == 0)
                count = 1;

            for (int i=0; i<count; i++)
                s += "#";
            s = s.PadRight(total + 1);
            s += "]";
            return (s+ ActZyw);
        }

        public int Attack()
        {
            if (WW1 >= Hit.Roll())
            {
                int x = Damage.Roll();
                int sum = 0;
                while (Damage.Roll() == 10)
                {
                    sum += 10;
                }
                return sum +St1+ x;

            }
            else
            {
                Console.WriteLine("Smok chybia: ");
                return -100;
            }
               
        }

        public int RangedAttack()
        {
            if (US1 >= Hit.Roll())
            {
                int Injury = St1 + Damage1.Roll();
                return Injury;
            }
            else
                return 0;
        }

        public int CrushingBlow(RollingDie die)
        {
            return 0;
        }

        public void Attack(int DamageFromDruzgoczący)
        {
            int HitRoll = Hit.Roll();
            if (WW1 >= HitRoll)
            {
                int Injury = St1 + DamageFromDruzgoczący;
                Console.WriteLine(Name + " zadaje obrazeń za " + Injury);
            }
            else
                Console.WriteLine(Name + " pudłuje");
        }

        public void TakeDamage(int damageTaken)
        {
            //int toughness = Wt;
            if (damageTaken>Wt)
            {
                int injuryTaken = Math.Abs(damageTaken - Wt);
                ActZyw -= injuryTaken;
                Console.WriteLine(ActZyw);
                //Console.WriteLine(PrintZyw());
            }
        }

        public void PowerfulBlow()
        {

        }

        public bool Parry()
        {
            int roll = Hit.Roll();
            if (WW1 >= roll)
            {
                TakeDamage(0);
                Console.WriteLine(Name + " sparował");
                return true;
            }
            else
            {
                Console.WriteLine(Name + " nie sparował ");
                return false;
            }
        }
    }
}
