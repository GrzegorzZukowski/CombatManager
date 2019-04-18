using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager
{
    class Battle
    {
        private Creature creature;
        private RollingDie die;

        public Battle(Creature creature, RollingDie Hit, RollingDie Damage)
        {
            this.creature = creature;
            this.die = Hit;
            this.die = Damage;
        }


    }
}
