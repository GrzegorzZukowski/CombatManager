using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager.Inventory
{
    public abstract class CreatureInventoryDecorator : ICreature
    {
        private ICreature _creature;

        public CreatureInventoryDecorator(ICreature aCreature)
        {
            this._creature = aCreature;
        }

        public virtual int Attack()
        {
            return this._creature.Attack();
        }

        public virtual void Attack(int DamageFromDruzgoczący)
        {
            this._creature.Attack(DamageFromDruzgoczący);
        }

        public virtual bool CriticalHit()
        {
            return this._creature.CriticalHit();
        }

        public virtual string PrintZyw()
        {
            return this._creature.PrintZyw();
        }

        public virtual int RangedAttack()
        {
            return this._creature.RangedAttack();
        }

        public virtual void TakeDamage(int damageTaken)
        {
            this._creature.TakeDamage(damageTaken);
        }
        public virtual int CrushingBlow(RollingDie die)
        {
            return this._creature.CrushingBlow(die);
        }
    }
}
