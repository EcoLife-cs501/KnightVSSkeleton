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
            ((System.ComponentModel.ISupportInitialize)(this.skeletonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // skeletonPictureBox
            // 
            this.skeletonPictureBox.Image = global::KnightVSSkeleton.Properties.Resources.Skeleton_Idle;
            this.skeletonPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("skeletonPictureBox.InitialImage")));
            this.skeletonPictureBox.Location = new System.Drawing.Point(208, 7);
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
            this.knightPictureBox.Location = new System.Drawing.Point(14, 7);
            this.knightPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.knightPictureBox.Name = "knightPictureBox";
            this.knightPictureBox.Size = new System.Drawing.Size(164, 162);
            this.knightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knightPictureBox.TabIndex = 0;
            this.knightPictureBox.TabStop = false;
            // 
            // knightAttacks
            // 
            this.knightAttacks.Location = new System.Drawing.Point(14, 210);
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
            this.skeletonAttacks.Location = new System.Drawing.Point(208, 210);
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
            this.knightsHealth.Location = new System.Drawing.Point(14, 180);
            this.knightsHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.knightsHealth.Name = "knightsHealth";
            this.knightsHealth.Size = new System.Drawing.Size(167, 20);
            this.knightsHealth.TabIndex = 4;
            this.knightsHealth.Text = "Knights Health: 100";
            this.knightsHealth.Click += new System.EventHandler(this.knightsHealth_Click);
            // 
            // skeletonsHealth
            // 
            this.skeletonsHealth.AutoSize = true;
            this.skeletonsHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skeletonsHealth.Location = new System.Drawing.Point(205, 180);
            this.skeletonsHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skeletonsHealth.Name = "skeletonsHealth";
            this.skeletonsHealth.Size = new System.Drawing.Size(178, 20);
            this.skeletonsHealth.TabIndex = 5;
            this.skeletonsHealth.Text = "Skeleton Health: 100";
            this.skeletonsHealth.Click += new System.EventHandler(this.skeletonsHealth_Click);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Knight VS Skeleton";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skeletonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightPictureBox)).EndInit();
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
    }
}

