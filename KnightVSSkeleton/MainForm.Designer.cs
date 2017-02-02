namespace KnightVSSkeleton
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.skeletonPictureBox = new System.Windows.Forms.PictureBox();
            this.knightPictureBox = new System.Windows.Forms.PictureBox();
            this.knightAttacks = new System.Windows.Forms.Button();
            this.skeletonAttacks = new System.Windows.Forms.Button();
            this.knightsHealth = new System.Windows.Forms.Label();
            this.skeletonsHealth = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseForSavedGames = new System.Windows.Forms.FolderBrowserDialog();
            this.saveGameDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.skeletonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightPictureBox)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // skeletonPictureBox
            // 
            this.skeletonPictureBox.Image = global::KnightVSSkeleton.Properties.Resources.Skeleton_Idle;
            this.skeletonPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("skeletonPictureBox.InitialImage")));
            this.skeletonPictureBox.Location = new System.Drawing.Point(205, 26);
            this.skeletonPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.skeletonPictureBox.Name = "skeletonPictureBox";
            this.skeletonPictureBox.Size = new System.Drawing.Size(164, 162);
            this.skeletonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skeletonPictureBox.TabIndex = 1;
            this.skeletonPictureBox.TabStop = false;
            // 
            // knightPictureBox
            // 
            this.knightPictureBox.Image = global::KnightVSSkeleton.Properties.Resources.Knight_Idle;
            this.knightPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("knightPictureBox.InitialImage")));
            this.knightPictureBox.Location = new System.Drawing.Point(11, 26);
            this.knightPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.knightPictureBox.Name = "knightPictureBox";
            this.knightPictureBox.Size = new System.Drawing.Size(164, 162);
            this.knightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knightPictureBox.TabIndex = 0;
            this.knightPictureBox.TabStop = false;
            // 
            // knightAttacks
            // 
            this.knightAttacks.Location = new System.Drawing.Point(11, 229);
            this.knightAttacks.Margin = new System.Windows.Forms.Padding(2);
            this.knightAttacks.Name = "knightAttacks";
            this.knightAttacks.Size = new System.Drawing.Size(178, 36);
            this.knightAttacks.TabIndex = 2;
            this.knightAttacks.Text = "Knight Attacks Skeleton";
            this.knightAttacks.UseVisualStyleBackColor = true;
            this.knightAttacks.Click += new System.EventHandler(this.knightAttacks_Click);
            // 
            // skeletonAttacks
            // 
            this.skeletonAttacks.Location = new System.Drawing.Point(205, 229);
            this.skeletonAttacks.Margin = new System.Windows.Forms.Padding(2);
            this.skeletonAttacks.Name = "skeletonAttacks";
            this.skeletonAttacks.Size = new System.Drawing.Size(172, 36);
            this.skeletonAttacks.TabIndex = 3;
            this.skeletonAttacks.Text = "Skeleton Attacks Knight";
            this.skeletonAttacks.UseVisualStyleBackColor = true;
            this.skeletonAttacks.Click += new System.EventHandler(this.skeletonAttacks_Click);
            // 
            // knightsHealth
            // 
            this.knightsHealth.AutoSize = true;
            this.knightsHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knightsHealth.Location = new System.Drawing.Point(11, 199);
            this.knightsHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.knightsHealth.Name = "knightsHealth";
            this.knightsHealth.Size = new System.Drawing.Size(167, 20);
            this.knightsHealth.TabIndex = 4;
            this.knightsHealth.Text = "Knights Health: 100";
            // 
            // skeletonsHealth
            // 
            this.skeletonsHealth.AutoSize = true;
            this.skeletonsHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skeletonsHealth.Location = new System.Drawing.Point(202, 199);
            this.skeletonsHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skeletonsHealth.Name = "skeletonsHealth";
            this.skeletonsHealth.Size = new System.Drawing.Size(178, 20);
            this.skeletonsHealth.TabIndex = 5;
            this.skeletonsHealth.Text = "Skeleton Health: 100";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(397, 24);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 303);
            this.Controls.Add(this.skeletonsHealth);
            this.Controls.Add(this.knightsHealth);
            this.Controls.Add(this.skeletonAttacks);
            this.Controls.Add(this.knightAttacks);
            this.Controls.Add(this.skeletonPictureBox);
            this.Controls.Add(this.knightPictureBox);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Knight VS Skeleton";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skeletonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightPictureBox)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox knightPictureBox;
        private System.Windows.Forms.PictureBox skeletonPictureBox;
        private System.Windows.Forms.Button knightAttacks;
        private System.Windows.Forms.Button skeletonAttacks;
        private System.Windows.Forms.Label knightsHealth;
        private System.Windows.Forms.Label skeletonsHealth;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog browseForSavedGames;
        private System.Windows.Forms.SaveFileDialog saveGameDialog;
    }
}

