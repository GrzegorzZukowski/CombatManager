using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager.Inventory
{
    //public class MeleeWeapon : CreatureDecorator
    //{
    //    public int StrengthBonus = 15;

    //    public MeleeWeapon(ICreature aCreature) : base(aCreature)
    //    {

    //    }

    //    public override int Attack()
    //    {
    //        return base.Attack()+StrengthBonus;
    //    }



    //    public override int CrushingBlow(RollingDie die)
    //    {
    //        int damage1 = die.Roll();
    //        int damage2 = die.Roll();
    //        if (damage1 > damage2)
    //        {
    //            Console.WriteLine("DAMAGE => druzgoczacy1 za" + damage1);
    //            //creature.Attack(damage1);
    //            Console.WriteLine(base.Attack());
    //            return base.Attack()+damage1;
    //        }
    //        else if (damage2 > damage1)
    //        {
    //            Console.WriteLine("DAMAGE =>druzgoczacy2 za " + damage2);
    //            //creature.Attack(damage2);
    //            Console.WriteLine(base.Attack());
    //            return base.Attack() + damage2;
    //        }
    //        else
    //        {
    //            Console.WriteLine("DAMAGE =>EQUALS druzgoczacy za " + damage1);
    //            //creature.Attack(damage1);
    //            return damage1;
    //        }
    //    }
    //}
}
