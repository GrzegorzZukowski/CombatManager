using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatManager.Inventory;

namespace CombatManager.Decorator.Inventory.Armour
{
    class Kolcza : CreatureDecorator
    {
        public Kolcza(ICreature aCreature) : base(aCreature)
        {

        }

        public override void TakeDamage(int damageTaken)
        {
            base.TakeDamage(damageTaken - 3);
        }
    }
}
