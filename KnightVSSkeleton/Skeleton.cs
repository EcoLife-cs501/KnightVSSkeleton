using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    [Serializable]
    public class Skeleton : Fighter
    {
        public Skeleton (PictureBox sprite, Weapon weapon): base(sprite, weapon)          
        {

            // TODO: Skeleton has its own constructor
        }
    }
}
