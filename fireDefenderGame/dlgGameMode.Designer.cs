namespace fireDefenderGame
{
    partial class dlgGameMode
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
            this.buttonEasy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonCustomize = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEasy
            // 
            this.buttonEasy.Location = new System.Drawing.Point(78, 52);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(133, 30);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Mode";
            // 
            // buttonMedium
            // 
            this.buttonMedium.Location = new System.Drawing.Point(78, 88);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(133, 30);
            this.buttonMedium.TabIndex = 2;
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.Location = new System.Drawing.Point(79, 124);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(133, 30);
            this.buttonHard.TabIndex = 3;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonCustomize
            // 
            this.buttonCustomize.Location = new System.Drawing.Point(79, 160);
            this.buttonCustomize.Name = "buttonCustomize";
            this.buttonCustomize.Size = new System.Drawing.Size(133, 30);
            this.buttonCustomize.TabIndex = 4;
            this.buttonCustomize.Text = "Customize";
            this.buttonCustomize.UseVisualStyleBackColor = true;
            this.buttonCustomize.Click += new System.EventHandler(this.buttonCustomize_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(110, 219);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(72, 30);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dlgGameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCustomize);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEasy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgGameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonCustomize;
        private System.Windows.Forms.Button buttonBack;
    }
}