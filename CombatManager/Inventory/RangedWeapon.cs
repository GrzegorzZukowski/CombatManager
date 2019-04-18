using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager.Inventory
{
    public class RangedWeapon : CreatureInventoryDecorator
    {
        public int EffectiveStrength = 15;

        public RangedWeapon(ICreature aCreature) : base(aCreature)
        {

        }

        public override int RangedAttack()
        {
            return base.RangedAttack() + EffectiveStrength;
        }

    }
}
