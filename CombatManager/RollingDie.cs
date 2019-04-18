using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatManager
{
    public class RollingDie
    {
        private Random random;
        private int sideCount;

        public RollingDie(int aSideCount)
        {
            this.sideCount = aSideCount;
            random = new Random();
        }

        public int GetSideCount()
        {
            return sideCount;
        }

        public int Roll()
        {
            return random.Next(1, sideCount + 1);
        }
    }
}
