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
        Skeleton skeleton;
        Knight knight;
        Weapon shortSword;
        Weapon longSword;
        List<Fighter> allGameObject = new List<Fighter>();



        public MainForm()
        {
            InitializeComponent();
            shortSword = new Weapon(10, 50);
            longSword = new Weapon(30, 40);
            skeleton = new Skeleton(skeletonPictureBox, longSword);           
            knight = new Knight(knightPictureBox, shortSword);
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


            if (knight.IsDead() || skeleton.IsDead())
            {
                skeletonAttacks.Enabled = false;
                knightAttacks.Enabled = false;
                if ( knight.IsDead())
                    MessageBox.Show("Игра окончена победил skeleton");
                else
                    MessageBox.Show("Игра окончена победил knight");
                knight = new Knight(knightPictureBox, shortSword);
                skeleton = new Skeleton(skeletonPictureBox, longSword);
                skeletonPictureBox.Enabled = true;
                knightPictureBox.Enabled = true;
                skeletonAttacks.Enabled = true;
                knightAttacks.Enabled = true;
                
            }
            skeletonsHealth.Text = skeleton.Health;
            knightsHealth.Text = knight.Health;
        }
        private void knightAttacks_Click(object sender, EventArgs e)
        {
            skeleton.ReceiveDamage(knight.MakeDamage());
            Update_All();
                    }

        private void skeletonAttacks_Click(object sender, EventArgs e)
        {
            knight.ReceiveDamage(skeleton.MakeDamage());
            Update_All();

        }






        private void knightsHealth_Click(object sender, EventArgs e)
        {

        }

        private void skeletonsHealth_Click(object sender, EventArgs e)
        {

        }
    }
}
