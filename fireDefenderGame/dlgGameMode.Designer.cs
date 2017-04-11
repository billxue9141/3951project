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
            this.difficulty = new System.Windows.Forms.HScrollBar();
            this.clValue = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panelCustomize = new System.Windows.Forms.Panel();
            this.panelCustomize.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEasy
            // 
            this.buttonEasy.Location = new System.Drawing.Point(117, 71);
            this.buttonEasy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(200, 51);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.Text = "Small";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map Size";
            // 
            // buttonMedium
            // 
            this.buttonMedium.Location = new System.Drawing.Point(117, 131);
            this.buttonMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(200, 51);
            this.buttonMedium.TabIndex = 2;
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.Location = new System.Drawing.Point(118, 191);
            this.buttonHard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(200, 51);
            this.buttonHard.TabIndex = 3;
            this.buttonHard.Text = "Large";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonCustomize
            // 
            this.buttonCustomize.Location = new System.Drawing.Point(118, 251);
            this.buttonCustomize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCustomize.Name = "buttonCustomize";
            this.buttonCustomize.Size = new System.Drawing.Size(200, 51);
            this.buttonCustomize.TabIndex = 4;
            this.buttonCustomize.Text = "Customize Map Size";
            this.buttonCustomize.UseVisualStyleBackColor = true;
            this.buttonCustomize.Click += new System.EventHandler(this.buttonCustomize_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(166, 417);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 51);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // difficulty
            // 
            this.difficulty.LargeChange = 1;
            this.difficulty.Location = new System.Drawing.Point(0, 2);
            this.difficulty.Maximum = 25;
            this.difficulty.Minimum = 10;
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(291, 23);
            this.difficulty.TabIndex = 6;
            this.difficulty.Value = 10;
            this.difficulty.Scroll += new System.Windows.Forms.ScrollEventHandler(this.difficulty_Scroll);
            // 
            // clValue
            // 
            this.clValue.AutoSize = true;
            this.clValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clValue.Location = new System.Drawing.Point(36, 42);
            this.clValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clValue.Name = "clValue";
            this.clValue.Size = new System.Drawing.Size(59, 40);
            this.clValue.TabIndex = 7;
            this.clValue.Text = "10";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(130, 42);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(112, 55);
            this.buttonEnter.TabIndex = 8;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // panelCustomize
            // 
            this.panelCustomize.Controls.Add(this.buttonEnter);
            this.panelCustomize.Controls.Add(this.difficulty);
            this.panelCustomize.Controls.Add(this.clValue);
            this.panelCustomize.Location = new System.Drawing.Point(75, 311);
            this.panelCustomize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCustomize.Name = "panelCustomize";
            this.panelCustomize.Size = new System.Drawing.Size(291, 95);
            this.panelCustomize.TabIndex = 9;
            // 
            // dlgGameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 509);
            this.ControlBox = false;
            this.Controls.Add(this.panelCustomize);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCustomize);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEasy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgGameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Mode";
            this.panelCustomize.ResumeLayout(false);
            this.panelCustomize.PerformLayout();
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
        private System.Windows.Forms.HScrollBar difficulty;
        private System.Windows.Forms.Label clValue;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Panel panelCustomize;
    }
}