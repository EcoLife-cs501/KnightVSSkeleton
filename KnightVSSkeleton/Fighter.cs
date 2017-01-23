using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    public class Fighter
    {
        PictureBox mySprite;
        private int health;

        public Fighter(PictureBox sprite)
        {
            this.mySprite = sprite;
            this.health = 100;
        }



        public int TellHealth()
        {
            return health;
        }

    }
}
