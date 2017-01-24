using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightVSSkeleton
{
    public class Weapon
    {

        public Weapon()
        {
            this.MinDamage = 10;
            this.MaxDamage = 25;
        }

        virtual public int MinDamage { get; private set; }
        virtual public int MaxDamage { get; private set; }


    }
}
