using CombatManager.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager.Decorator.Inventory.MeleeWeapon
{
    class Rapier : CreatureDecorator
    {
        public Rapier(ICreature aCreature) : base(aCreature)
        {

        }

        public override int Attack()
        {
            return base.Attack() - 1;
        }
    }
}
