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

        public int MakeDamage()
        {
            Random random = new Random();
            int damage = random.Next(1, 10);
            return damage;
        }

        public void ReceiveDamage(int damage)
        {
            health = health - damage;
        }



        public int TellHealth()
        {
            return health;
        }

        public async void Die()
        {

            PictureBox spriteBackup;
            spriteBackup = mySprite;

            try
            {
                mySprite.Image = Image.FromFile(@"C:\GitHub\KnightVSSkeleton\Assets\Skeleton_Death.gif");
                mySprite.Enabled = true;
                await Task.Delay(900);
                mySprite.Enabled = false;

            }
            catch (System.IO.FileNotFoundException)
            {
                mySprite = spriteBackup;
                MessageBox.Show("Animation file not found!", "File Error!");
            }
        }


    }
}
