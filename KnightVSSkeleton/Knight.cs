using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    public class Knight : Fighter
    {
        public Knight (PictureBox sprite):base(sprite)
        {

        }

        /// <summary>
        /// Это пример того, как работает override, и как достучаться до базового класса
        /// </summary>
        /// <returns>Возвращает оригинальный damage + 10</returns>

        public override int MakeDamage()
        {
            return base.MakeDamage() + 10;
        }

    }
}
