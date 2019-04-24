using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager
{
    public class Skills
    {
        //SILNY CIOS
        public void PowerfulBlow(Creature creature)
        {
            creature.St1 = creature.St1 + 1;
        }
        //DRUZGOCZACY -> zastępuje metodę Attack - do poprawy!!!
        public int CrushingBlow(Creature creature, RollingDie die)
        {
            int damage1 = die.Roll();
            int damage2 = die.Roll();
            if (damage1 > damage2)
            {
                Console.WriteLine("DAMAGE => druzgoczacy1 za" + damage1);
                //creature.Attack(damage1);
                return damage1;
            }
            else if (damage2 > damage1)
            {
                Console.WriteLine("DAMAGE =>druzgoczacy2 za " + damage2);
                //creature.Attack(damage2);
                return damage2;
            }
            else
            {
                Console.WriteLine("DAMAGE =>EQUALS druzgoczacy za " + damage1);
                //creature.Attack(damage1);
                return damage1;
            }
        }
        //UNIKI
        public bool DodgeBlow(Creature creature, RollingDie die)
        {
            int roll = die.Roll();
            if (creature.Dex1 >= roll)
            {
                creature.TakeDamage(0);
                Console.WriteLine("smok uniknął");
                return true;
            }
            else
            {
                Console.WriteLine("smok nie uniknął");
                return false;
            }
        }
        //PAROWANIE
        public bool Parry(Creature creature, RollingDie die)
        {
            int roll = die.Roll();
            if (creature.WW1 >= roll)
            {
                creature.TakeDamage(0);
                Console.WriteLine("smok sparował");
                return true;
            }
            else
            {
                Console.WriteLine("smok nie sparował ");
                return false;
            }
        }
    }
}
