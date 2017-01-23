using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void Die ()
        {

            PictureBox spriteBackup;
            spriteBackup = mySprite;

            try
            {                
                mySprite.Image = Image.FromFile(@"C:\GitHub\KnightVSSkeleton\Assets\Skeleton_Death.gif");
            }
            catch (System.IO.FileNotFoundException)
            {
                mySprite = spriteBackup;
            }
        }


    }
}
