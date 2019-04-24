using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager
{
    public interface ICreature
    {
        bool CriticalHit();
        string PrintZyw();
        int Attack();
        int RangedAttack();
        void Attack(int DamageFromDruzgoczący);
        void TakeDamage(int damageTaken);
        int CrushingBlow(RollingDie die);
        void PowerfulBlow();
        bool Parry();

    }
}
