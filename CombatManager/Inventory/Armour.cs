using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager.Inventory
{
    public class Armour : CreatureInventoryDecorator
    {
        public enum ArmourClass { Nic, Skorznia, Cwiekowana, Kolcza, Luskowa, Plyta};

        public Armour (ICreature aCreature) : base (aCreature)
        {

        }

        public override void TakeDamage(int damageTaken)
        {
            base.TakeDamage(damageTaken - (int)ArmourClass.Kolcza);
        }
    }
}
