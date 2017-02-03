using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    [Serializable]
    public class Fighter
    {
        [NonSerialized] public PictureBox mySprite;
        private int health;
        Weapon myWeapon;


        // TODO: Both skeleton and knight have their respective weapons


        public Fighter(PictureBox sprite, Weapon weapon)
        {
            this.mySprite = sprite;
            this.health = 100;
            this.myWeapon = weapon;
        mySprite.Image = Image.FromFile(@"C:\GitHub\KnightVSSkeleton\Assets\Skeleton_Idle.gif");
            // TODO: In order to create instance you have to supply Weapon
}

    public virtual int MakeDamage()
        {
            Random random = new Random();

            // TODO: Make damage makes not less than minDamage, but no more than maxDamage of weapon this instancess possesses
            int damage = random.Next(myWeapon.MinDamage, myWeapon.MaxDamage);
            return damage;
        }

        public virtual void ReceiveDamage(int damage)
        {
            health = health - damage;
            if (health < 0)
            {
                Die();
                health = 0;
            }
        }


        public int TellHealth()
        {
            return health;
        }

        public string Health { get { return health.ToString(); } }

        public virtual async void Die()
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
        public bool IsDead()
        {
            if (health <= 0) return true;
            else return false;               
        }

    }
}
