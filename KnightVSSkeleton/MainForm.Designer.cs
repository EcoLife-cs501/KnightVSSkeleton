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
            this.button1 = new System.Windows.Forms.Button();
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
            this.skeletonPictureBox.Location = new System.Drawing.Point(382, 13);
            this.skeletonPictureBox.Name = "skeletonPictureBox";
            this.skeletonPictureBox.Size = new System.Drawing.Size(300, 300);
            this.skeletonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skeletonPictureBox.TabIndex = 1;
            this.skeletonPictureBox.TabStop = false;
            // 
            // knightPictureBox
            // 
            this.knightPictureBox.Image = global::KnightVSSkeleton.Properties.Resources.Knight_Idle;
            this.knightPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("knightPictureBox.InitialImage")));
            this.knightPictureBox.Location = new System.Drawing.Point(26, 13);
            this.knightPictureBox.Name = "knightPictureBox";
            this.knightPictureBox.Size = new System.Drawing.Size(300, 300);
            this.knightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knightPictureBox.TabIndex = 0;
            this.knightPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Knight Attacks Skeleton";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // skeletonAttacks
            // 
            this.skeletonAttacks.Location = new System.Drawing.Point(382, 388);
            this.skeletonAttacks.Name = "skeletonAttacks";
            this.skeletonAttacks.Size = new System.Drawing.Size(315, 66);
            this.skeletonAttacks.TabIndex = 3;
            this.skeletonAttacks.Text = "Skeleton Attacks Knight";
            this.skeletonAttacks.UseVisualStyleBackColor = true;
            // 
            // knightsHealth
            // 
            this.knightsHealth.AutoSize = true;
            this.knightsHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knightsHealth.Location = new System.Drawing.Point(26, 331);
            this.knightsHealth.Name = "knightsHealth";
            this.knightsHealth.Size = new System.Drawing.Size(283, 32);
            this.knightsHealth.TabIndex = 4;
            this.knightsHealth.Text = "Knights Health: 100";
            // 
            // skeletonsHealth
            // 
            this.skeletonsHealth.AutoSize = true;
            this.skeletonsHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skeletonsHealth.Location = new System.Drawing.Point(376, 331);
            this.skeletonsHealth.Name = "skeletonsHealth";
            this.skeletonsHealth.Size = new System.Drawing.Size(300, 32);
            this.skeletonsHealth.TabIndex = 5;
            this.skeletonsHealth.Text = "Skeleton Health: 100";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 560);
            this.Controls.Add(this.skeletonsHealth);
            this.Controls.Add(this.knightsHealth);
            this.Controls.Add(this.skeletonAttacks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skeletonPictureBox);
            this.Controls.Add(this.knightPictureBox);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button skeletonAttacks;
        private System.Windows.Forms.Label knightsHealth;
        private System.Windows.Forms.Label skeletonsHealth;
    }
}

