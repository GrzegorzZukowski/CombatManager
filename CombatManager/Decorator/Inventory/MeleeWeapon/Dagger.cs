using CombatManager.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager.Decorator.Inventory.MeleeWeapon
{
    class Dagger : CreatureDecorator
    {
        public Dagger(ICreature aCreature) : base(aCreature)
        {

        }

        public override int Attack()
        {
            return base.Attack() - 3;
        }
    }
}
