using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        List<Fighter> allGameObjects;
        string currentFolder;



        public MainForm()
        {
            InitializeComponent();

            shortSword = new Weapon(10, 50);
            longSword = new Weapon(30, 40);
            currentFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KnightVSSkeleton";
            skeleton = new Skeleton(skeletonPictureBox, longSword, skeletonsHealth);           
            knight = new Knight(knightPictureBox, shortSword, knightsHealth);

            allGameObjects = new List<Fighter>();
            Fighter dummy = knight as Fighter;
            allGameObjects.Add(dummy);
            dummy = skeleton as Fighter;
            allGameObjects.Add(dummy);

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
                Reset_Fighters();
                knight = new Knight(knightPictureBox, shortSword, knightsHealth);
                skeleton = new Skeleton(skeletonPictureBox, longSword, skeletonsHealth);
                skeletonPictureBox.Enabled = true;
                knightPictureBox.Enabled = true;
                skeletonAttacks.Enabled = true;
                knightAttacks.Enabled = true;
                
            }
            foreach (Fighter dummy in allGameObjects)
            {
                dummy.Health.ToString();
            }


        }

        private void Reset_Fighters()
        {
            knight = new Knight(knightPictureBox, shortSword);
            skeleton = new Skeleton(skeletonPictureBox, longSword);
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

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset_Fighters();
            Update_All();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveGameDialog.Title = "Save game:";
            saveGameDialog.Filter = "Game files | *.gam";
            saveGameDialog.DefaultExt = "gam";
            saveGameDialog.InitialDirectory = currentFolder;
            if (saveGameDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream outputStream = File.OpenWrite(saveGameDialog.FileName))
                {
                    formatter.Serialize(outputStream, knight);
                    formatter.Serialize(outputStream, skeleton);
                    MessageBox.Show("Successfully saved game to " + saveGameDialog.FileName, "Game Saved!");
                }
            }

        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openGameDialog.Title = "Load game:";
            openGameDialog.Filter = "Game files | *.gam";
            openGameDialog.InitialDirectory = currentFolder;
            openGameDialog.CheckFileExists = true;
            if (openGameDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream inputStream = File.OpenRead(openGameDialog.FileName))
                {                   
                    knight = (Knight)formatter.Deserialize(inputStream);
                    skeleton = (Skeleton)formatter.Deserialize(inputStream);
                    knight.mySprite = knightPictureBox;
                    skeleton.mySprite = skeletonPictureBox;                               
                    Update_All();
                }
            }

        }
    }
}
