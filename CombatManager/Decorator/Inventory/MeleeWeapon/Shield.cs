﻿using CombatManager.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager.Decorator.Inventory.MeleeWeapon
{
    class Shield : CreatureDecorator
    {
        public Shield(ICreature aCreature) : base(aCreature)
        {

        }

        public override bool Parry()
        {
            return true;
        }
    }
}
