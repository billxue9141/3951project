namespace fireDefenderGame
{
    partial class FormMain
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
            this.mapPanel = new System.Windows.Forms.Panel();
            this.labelTicksPerSec = new System.Windows.Forms.Label();
            this.labelTickPerSec = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelTotalTicks = new System.Windows.Forms.Label();
            this.labelTotalTicksDisplay = new System.Windows.Forms.Label();
            this.labelMouseY = new System.Windows.Forms.Label();
            this.labelMouseYDisplay = new System.Windows.Forms.Label();
            this.labelMouseX = new System.Windows.Forms.Label();
            this.labelmouseXDisplay = new System.Windows.Forms.Label();
            this.panelUpgrade = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.richTextBoxDescriptions = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelInfo.SuspendLayout();
            this.panelUpgrade.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPanel
            // 
            this.mapPanel.Location = new System.Drawing.Point(24, 21);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(790, 781);
            this.mapPanel.TabIndex = 0;
            this.mapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mapPanel_paint);
            // 
            // labelTicksPerSec
            // 
            this.labelTicksPerSec.AutoSize = true;
            this.labelTicksPerSec.Location = new System.Drawing.Point(158, 21);
            this.labelTicksPerSec.Name = "labelTicksPerSec";
            this.labelTicksPerSec.Size = new System.Drawing.Size(31, 20);
            this.labelTicksPerSec.TabIndex = 2;
            this.labelTicksPerSec.Text = "tps";
            // 
            // labelTickPerSec
            // 
            this.labelTickPerSec.AutoSize = true;
            this.labelTickPerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTickPerSec.Location = new System.Drawing.Point(17, 21);
            this.labelTickPerSec.Name = "labelTickPerSec";
            this.labelTickPerSec.Size = new System.Drawing.Size(119, 20);
            this.labelTickPerSec.TabIndex = 3;
            this.labelTickPerSec.Text = "Ticks per sec:";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelTotalTicks);
            this.panelInfo.Controls.Add(this.labelTotalTicksDisplay);
            this.panelInfo.Controls.Add(this.labelMouseY);
            this.panelInfo.Controls.Add(this.labelMouseYDisplay);
            this.panelInfo.Controls.Add(this.labelMouseX);
            this.panelInfo.Controls.Add(this.labelmouseXDisplay);
            this.panelInfo.Controls.Add(this.labelTickPerSec);
            this.panelInfo.Controls.Add(this.labelTicksPerSec);
            this.panelInfo.Location = new System.Drawing.Point(820, 76);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(326, 254);
            this.panelInfo.TabIndex = 4;
            // 
            // labelTotalTicks
            // 
            this.labelTotalTicks.AutoSize = true;
            this.labelTotalTicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTicks.Location = new System.Drawing.Point(17, 50);
            this.labelTotalTicks.Name = "labelTotalTicks";
            this.labelTotalTicks.Size = new System.Drawing.Size(100, 20);
            this.labelTotalTicks.TabIndex = 9;
            this.labelTotalTicks.Text = "Total Ticks:";
            // 
            // labelTotalTicksDisplay
            // 
            this.labelTotalTicksDisplay.AutoSize = true;
            this.labelTotalTicksDisplay.Location = new System.Drawing.Point(158, 50);
            this.labelTotalTicksDisplay.Name = "labelTotalTicksDisplay";
            this.labelTotalTicksDisplay.Size = new System.Drawing.Size(76, 20);
            this.labelTotalTicksDisplay.TabIndex = 8;
            this.labelTotalTicksDisplay.Text = "total ticks";
            // 
            // labelMouseY
            // 
            this.labelMouseY.AutoSize = true;
            this.labelMouseY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMouseY.Location = new System.Drawing.Point(17, 131);
            this.labelMouseY.Name = "labelMouseY";
            this.labelMouseY.Size = new System.Drawing.Size(84, 20);
            this.labelMouseY.TabIndex = 7;
            this.labelMouseY.Text = "Mouse Y:";
            // 
            // labelMouseYDisplay
            // 
            this.labelMouseYDisplay.AutoSize = true;
            this.labelMouseYDisplay.Location = new System.Drawing.Point(115, 131);
            this.labelMouseYDisplay.Name = "labelMouseYDisplay";
            this.labelMouseYDisplay.Size = new System.Drawing.Size(68, 20);
            this.labelMouseYDisplay.TabIndex = 6;
            this.labelMouseYDisplay.Text = "mouse y";
            // 
            // labelMouseX
            // 
            this.labelMouseX.AutoSize = true;
            this.labelMouseX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMouseX.Location = new System.Drawing.Point(17, 94);
            this.labelMouseX.Name = "labelMouseX";
            this.labelMouseX.Size = new System.Drawing.Size(84, 20);
            this.labelMouseX.TabIndex = 5;
            this.labelMouseX.Text = "Mouse X:";
            // 
            // labelmouseXDisplay
            // 
            this.labelmouseXDisplay.AutoSize = true;
            this.labelmouseXDisplay.Location = new System.Drawing.Point(115, 94);
            this.labelmouseXDisplay.Name = "labelmouseXDisplay";
            this.labelmouseXDisplay.Size = new System.Drawing.Size(68, 20);
            this.labelmouseXDisplay.TabIndex = 4;
            this.labelmouseXDisplay.Text = "mouse x";
            // 
            // panelUpgrade
            // 
            this.panelUpgrade.Controls.Add(this.richTextBox1);
            this.panelUpgrade.Controls.Add(this.richTextBoxDescriptions);
            this.panelUpgrade.Controls.Add(this.buttonAttack);
            this.panelUpgrade.Controls.Add(this.buttonMove);
            this.panelUpgrade.Location = new System.Drawing.Point(820, 336);
            this.panelUpgrade.Name = "panelUpgrade";
            this.panelUpgrade.Size = new System.Drawing.Size(326, 466);
            this.panelUpgrade.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonHelp);
            this.panelMenu.Controls.Add(this.buttonPause);
            this.panelMenu.Controls.Add(this.buttonNewGame);
            this.panelMenu.Location = new System.Drawing.Point(820, 21);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(326, 49);
            this.panelMenu.TabIndex = 6;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(227, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(96, 40);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(125, 3);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(96, 40);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(3, 3);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(116, 40);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(20, 28);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(116, 40);
            this.buttonMove.TabIndex = 1;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(174, 28);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(116, 40);
            this.buttonAttack.TabIndex = 2;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDescriptions
            // 
            this.richTextBoxDescriptions.Location = new System.Drawing.Point(21, 234);
            this.richTextBoxDescriptions.Name = "richTextBoxDescriptions";
            this.richTextBoxDescriptions.Size = new System.Drawing.Size(269, 202);
            this.richTextBoxDescriptions.TabIndex = 4;
            this.richTextBoxDescriptions.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 128);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Select unit/building";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 842);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUpgrade);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.mapPanel);
            this.Name = "FormMain";
            this.Text = "Fire Defender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelUpgrade.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.Label labelTicksPerSec;
        private System.Windows.Forms.Label labelTickPerSec;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelUpgrade;
        private System.Windows.Forms.Label labelMouseY;
        private System.Windows.Forms.Label labelMouseYDisplay;
        private System.Windows.Forms.Label labelMouseX;
        private System.Windows.Forms.Label labelmouseXDisplay;
        private System.Windows.Forms.Label labelTotalTicks;
        private System.Windows.Forms.Label labelTotalTicksDisplay;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptions;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

