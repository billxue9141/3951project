namespace fireDefenderGame
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNewgame = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNewgame
            // 
            this.buttonNewgame.Location = new System.Drawing.Point(305, 185);
            this.buttonNewgame.Name = "buttonNewgame";
            this.buttonNewgame.Size = new System.Drawing.Size(183, 50);
            this.buttonNewgame.TabIndex = 1;
            this.buttonNewgame.Text = "New Game";
            this.buttonNewgame.UseVisualStyleBackColor = true;
            this.buttonNewgame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(305, 263);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(183, 50);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.Location = new System.Drawing.Point(305, 339);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(183, 50);
            this.buttonCredits.TabIndex = 3;
            this.buttonCredits.Text = "Credits";
            this.buttonCredits.UseVisualStyleBackColor = true;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(305, 416);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(183, 50);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit Game";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 505);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonNewgame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Fire Defenders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNewgame;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Button buttonExit;
    }
}