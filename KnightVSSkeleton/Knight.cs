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
    public class Knight : Fighter
    {
        public Knight(PictureBox sprite, Weapon weapon) : base(sprite, weapon)

        {
            base.mySprite.Image = Image.FromFile(@"C:\GitHub\KnightVSSkeleton\Assets\Knight_Idle.GIF"); }

        /// <summary>
        /// Это пример того, как работает override, и как достучаться до базового класса
        /// </summary>
        /// <returns>Возвращает оригинальный damage + 10</returns>

        public override int MakeDamage()
        {
            return base.MakeDamage() + 10;
        }

        public override async void Die()
        {
            PictureBox spriteBackup; 
            spriteBackup = mySprite;

            try
            {
                mySprite.Image = Image.FromFile(@"C:\GitHub\KnightVSSkeleton\Assets\Knight_Death.gif");
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
