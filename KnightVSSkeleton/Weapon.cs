using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightVSSkeleton
{
    public class Weapon
    {

        public Weapon(int minDamage, int maxDamage)
        {
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
        }

        virtual public int MinDamage { get; private set; }
        virtual public int MaxDamage { get; private set; }


    }
}
