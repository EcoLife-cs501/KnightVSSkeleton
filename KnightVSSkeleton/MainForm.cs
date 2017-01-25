using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    public partial class MainForm : Form
    {
        Fighter skeleton;
        Fighter knight;
        Weapon mace;

        public MainForm()
        {
            InitializeComponent();
            skeleton = new Fighter(skeletonPictureBox);
            
            knight = new Fighter(knightPictureBox);
            mace = new Weapon(10, 25);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            skeletonPictureBox.Enabled = false;
            skeletonPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            skeletonPictureBox.Enabled = true;
        }

        /// <summary>
        /// После того, как рыцарь и скелет проивзаимодействовали, нужно обновить их здоровье и картинки
        /// </summary>
        public void Update_All()
        {
            throw new System.NotImplementedException();
        }

        private void knightAttacks_Click(object sender, EventArgs e)
        {
            skeleton.ReceiveDamage(knight.MakeDamage());
            skeletonsHealth.Text = skeleton.Health;
            
           


        }


    }
}
