using CombatManager.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager.Decorator.Inventory.Armour
{
    class Plyta : CreatureDecorator
    {
        public Plyta(ICreature aCreature) : base(aCreature)
        {

        }

        public override void TakeDamage(int damageTaken)
        {
            base.TakeDamage(damageTaken - 5);
        }
    }
}
