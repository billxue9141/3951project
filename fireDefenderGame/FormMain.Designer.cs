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
            this.labelWaterUsageDisplay = new System.Windows.Forms.Label();
            this.labelWaterUsage = new System.Windows.Forms.Label();
            this.labelFireLevelDisplay = new System.Windows.Forms.Label();
            this.labelTreesLeftDisplay = new System.Windows.Forms.Label();
            this.labelFireLevel = new System.Windows.Forms.Label();
            this.labelTressLeft = new System.Windows.Forms.Label();
            this.labelSelectedLocationDisplay = new System.Windows.Forms.Label();
            this.labelTotalTicks = new System.Windows.Forms.Label();
            this.labelEnergyDisplay = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.panelUnit = new System.Windows.Forms.Panel();
            this.labelNextLevelUnitRangeDisplay = new System.Windows.Forms.Label();
            this.labelNextLevelUnitDamageDisplay = new System.Windows.Forms.Label();
            this.labelNextLevelUnitHpDisplay = new System.Windows.Forms.Label();
            this.labelNextLevelUnitHpRegenDisplay = new System.Windows.Forms.Label();
            this.labelNextLevelUnitHpRegen = new System.Windows.Forms.Label();
            this.labelUnitHpRegenDisplay = new System.Windows.Forms.Label();
            this.labelUnitHpRegen = new System.Windows.Forms.Label();
            this.labelUnitRangeDisplay = new System.Windows.Forms.Label();
            this.labelUnitDamageDisplay = new System.Windows.Forms.Label();
            this.labelUnitHpDisplay = new System.Windows.Forms.Label();
            this.buttonUnitUpgrade = new System.Windows.Forms.Button();
            this.labelNextLevelUnitRange = new System.Windows.Forms.Label();
            this.labelNextLevelUnitDamage = new System.Windows.Forms.Label();
            this.labelNextLevelUnitHp = new System.Windows.Forms.Label();
            this.labelNextLevelUnit = new System.Windows.Forms.Label();
            this.labelUnitRange = new System.Windows.Forms.Label();
            this.labelUnitDamage = new System.Windows.Forms.Label();
            this.labelUnitName = new System.Windows.Forms.Label();
            this.labelUnitHp = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonSlowDown = new System.Windows.Forms.Button();
            this.buttonSpeedUp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.panelBuilding = new System.Windows.Forms.Panel();
            this.labelNextLevelBuildingRangeDisplay = new System.Windows.Forms.Label();
            this.labelNextLevelBuildingProductionDisplay = new System.Windows.Forms.Label();
            this.labelNextLevelBuildingDamageDisplay = new System.Windows.Forms.Label();
            this.labelNextLevelBuildingHpDisplay = new System.Windows.Forms.Label();
            this.labelBuildingRangeDisplay = new System.Windows.Forms.Label();
            this.labelBuildingProductionDisplay = new System.Windows.Forms.Label();
            this.labelBuildingDamageDisplay = new System.Windows.Forms.Label();
            this.labelBuildingHpDisplay = new System.Windows.Forms.Label();
            this.labelNextLevelBuildingProduction = new System.Windows.Forms.Label();
            this.labelBuildingProduction = new System.Windows.Forms.Label();
            this.buttonBuildingUpgrade = new System.Windows.Forms.Button();
            this.labelNextLevelBuildingRange = new System.Windows.Forms.Label();
            this.labelNextLevelBuildingDamage = new System.Windows.Forms.Label();
            this.labelNextLevelBuildingHp = new System.Windows.Forms.Label();
            this.labelNextLevelBuilding = new System.Windows.Forms.Label();
            this.labelBuildingRange = new System.Windows.Forms.Label();
            this.labelBuildingDamage = new System.Windows.Forms.Label();
            this.labelBuildingName = new System.Windows.Forms.Label();
            this.labelBuildingHp = new System.Windows.Forms.Label();
            this.panelBuildNew = new System.Windows.Forms.Panel();
            this.buttonBuildPipe = new System.Windows.Forms.Button();
            this.buttonBuildPump = new System.Windows.Forms.Button();
            this.buttonBuildDefender = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.panelUnit.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBuilding.SuspendLayout();
            this.panelBuildNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPanel
            // 
            this.mapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPanel.AutoSize = true;
            this.mapPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mapPanel.Location = new System.Drawing.Point(24, 22);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(866, 782);
            this.mapPanel.TabIndex = 0;
            this.mapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mapPanel_paint);
            this.mapPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMapPanelMouseClick);
            // 
            // labelTicksPerSec
            // 
            this.labelTicksPerSec.AutoSize = true;
            this.labelTicksPerSec.Location = new System.Drawing.Point(75, 3);
            this.labelTicksPerSec.Name = "labelTicksPerSec";
            this.labelTicksPerSec.Size = new System.Drawing.Size(18, 20);
            this.labelTicksPerSec.TabIndex = 2;
            this.labelTicksPerSec.Text = "0";
            // 
            // labelTickPerSec
            // 
            this.labelTickPerSec.AutoSize = true;
            this.labelTickPerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTickPerSec.Location = new System.Drawing.Point(27, 3);
            this.labelTickPerSec.Name = "labelTickPerSec";
            this.labelTickPerSec.Size = new System.Drawing.Size(48, 20);
            this.labelTickPerSec.TabIndex = 3;
            this.labelTickPerSec.Text = "FPS:";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.AutoSize = true;
            this.panelInfo.Controls.Add(this.labelWaterUsageDisplay);
            this.panelInfo.Controls.Add(this.labelWaterUsage);
            this.panelInfo.Controls.Add(this.labelFireLevelDisplay);
            this.panelInfo.Controls.Add(this.labelTreesLeftDisplay);
            this.panelInfo.Controls.Add(this.labelFireLevel);
            this.panelInfo.Controls.Add(this.labelTressLeft);
            this.panelInfo.Controls.Add(this.labelSelectedLocationDisplay);
            this.panelInfo.Controls.Add(this.labelTotalTicks);
            this.panelInfo.Controls.Add(this.labelEnergyDisplay);
            this.panelInfo.Controls.Add(this.labelPosition);
            this.panelInfo.Location = new System.Drawing.Point(890, 132);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(326, 197);
            this.panelInfo.TabIndex = 4;
            this.panelInfo.Visible = false;
            // 
            // labelWaterUsageDisplay
            // 
            this.labelWaterUsageDisplay.AutoSize = true;
            this.labelWaterUsageDisplay.Location = new System.Drawing.Point(160, 48);
            this.labelWaterUsageDisplay.Name = "labelWaterUsageDisplay";
            this.labelWaterUsageDisplay.Size = new System.Drawing.Size(39, 20);
            this.labelWaterUsageDisplay.TabIndex = 15;
            this.labelWaterUsageDisplay.Text = "0 / 0";
            // 
            // labelWaterUsage
            // 
            this.labelWaterUsage.AutoSize = true;
            this.labelWaterUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterUsage.Location = new System.Drawing.Point(20, 48);
            this.labelWaterUsage.Name = "labelWaterUsage";
            this.labelWaterUsage.Size = new System.Drawing.Size(119, 20);
            this.labelWaterUsage.TabIndex = 14;
            this.labelWaterUsage.Text = "Water Usage:";
            // 
            // labelFireLevelDisplay
            // 
            this.labelFireLevelDisplay.AutoSize = true;
            this.labelFireLevelDisplay.Location = new System.Drawing.Point(122, 142);
            this.labelFireLevelDisplay.Name = "labelFireLevelDisplay";
            this.labelFireLevelDisplay.Size = new System.Drawing.Size(18, 20);
            this.labelFireLevelDisplay.TabIndex = 13;
            this.labelFireLevelDisplay.Text = "0";
            // 
            // labelTreesLeftDisplay
            // 
            this.labelTreesLeftDisplay.AutoSize = true;
            this.labelTreesLeftDisplay.Location = new System.Drawing.Point(122, 112);
            this.labelTreesLeftDisplay.Name = "labelTreesLeftDisplay";
            this.labelTreesLeftDisplay.Size = new System.Drawing.Size(18, 20);
            this.labelTreesLeftDisplay.TabIndex = 12;
            this.labelTreesLeftDisplay.Text = "0";
            // 
            // labelFireLevel
            // 
            this.labelFireLevel.AutoSize = true;
            this.labelFireLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFireLevel.Location = new System.Drawing.Point(20, 142);
            this.labelFireLevel.Name = "labelFireLevel";
            this.labelFireLevel.Size = new System.Drawing.Size(86, 20);
            this.labelFireLevel.TabIndex = 11;
            this.labelFireLevel.Text = "Fire level:";
            // 
            // labelTressLeft
            // 
            this.labelTressLeft.AutoSize = true;
            this.labelTressLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTressLeft.Location = new System.Drawing.Point(16, 112);
            this.labelTressLeft.Name = "labelTressLeft";
            this.labelTressLeft.Size = new System.Drawing.Size(90, 20);
            this.labelTressLeft.TabIndex = 10;
            this.labelTressLeft.Text = "Trees left:";
            // 
            // labelSelectedLocationDisplay
            // 
            this.labelSelectedLocationDisplay.AutoSize = true;
            this.labelSelectedLocationDisplay.Location = new System.Drawing.Point(177, 85);
            this.labelSelectedLocationDisplay.Name = "labelSelectedLocationDisplay";
            this.labelSelectedLocationDisplay.Size = new System.Drawing.Size(31, 20);
            this.labelSelectedLocationDisplay.TabIndex = 5;
            this.labelSelectedLocationDisplay.Text = "x, y";
            // 
            // labelTotalTicks
            // 
            this.labelTotalTicks.AutoSize = true;
            this.labelTotalTicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTicks.Location = new System.Drawing.Point(18, 16);
            this.labelTotalTicks.Name = "labelTotalTicks";
            this.labelTotalTicks.Size = new System.Drawing.Size(70, 20);
            this.labelTotalTicks.TabIndex = 9;
            this.labelTotalTicks.Text = "Energy:";
            // 
            // labelEnergyDisplay
            // 
            this.labelEnergyDisplay.AutoSize = true;
            this.labelEnergyDisplay.Location = new System.Drawing.Point(107, 16);
            this.labelEnergyDisplay.Name = "labelEnergyDisplay";
            this.labelEnergyDisplay.Size = new System.Drawing.Size(92, 20);
            this.labelEnergyDisplay.TabIndex = 8;
            this.labelEnergyDisplay.Text = "total energy";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(16, 85);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(154, 20);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "Selected Position:";
            // 
            // panelUnit
            // 
            this.panelUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUnit.AutoSize = true;
            this.panelUnit.Controls.Add(this.labelNextLevelUnitRangeDisplay);
            this.panelUnit.Controls.Add(this.labelNextLevelUnitDamageDisplay);
            this.panelUnit.Controls.Add(this.labelNextLevelUnitHpDisplay);
            this.panelUnit.Controls.Add(this.labelNextLevelUnitHpRegenDisplay);
            this.panelUnit.Controls.Add(this.labelNextLevelUnitHpRegen);
            this.panelUnit.Controls.Add(this.labelUnitHpRegenDisplay);
            this.panelUnit.Controls.Add(this.labelUnitHpRegen);
            this.panelUnit.Controls.Add(this.labelUnitRangeDisplay);
            this.panelUnit.Controls.Add(this.labelUnitDamageDisplay);
            this.panelUnit.Controls.Add(this.labelUnitHpDisplay);
            this.panelUnit.Controls.Add(this.buttonUnitUpgrade);
            this.panelUnit.Controls.Add(this.labelNextLevelUnitRange);
            this.panelUnit.Controls.Add(this.labelNextLevelUnitDamage);
            this.panelUnit.Controls.Add(this.labelNextLevelUnitHp);
            this.panelUnit.Controls.Add(this.labelNextLevelUnit);
            this.panelUnit.Controls.Add(this.labelUnitRange);
            this.panelUnit.Controls.Add(this.labelUnitDamage);
            this.panelUnit.Controls.Add(this.labelUnitName);
            this.panelUnit.Controls.Add(this.labelUnitHp);
            this.panelUnit.Controls.Add(this.buttonMove);
            this.panelUnit.Location = new System.Drawing.Point(890, 335);
            this.panelUnit.Name = "panelUnit";
            this.panelUnit.Size = new System.Drawing.Size(326, 466);
            this.panelUnit.TabIndex = 5;
            this.panelUnit.Visible = false;
            // 
            // labelNextLevelUnitRangeDisplay
            // 
            this.labelNextLevelUnitRangeDisplay.AutoSize = true;
            this.labelNextLevelUnitRangeDisplay.Location = new System.Drawing.Point(101, 334);
            this.labelNextLevelUnitRangeDisplay.Name = "labelNextLevelUnitRangeDisplay";
            this.labelNextLevelUnitRangeDisplay.Size = new System.Drawing.Size(148, 20);
            this.labelNextLevelUnitRangeDisplay.TabIndex = 22;
            this.labelNextLevelUnitRangeDisplay.Text = "nl unit range display";
            // 
            // labelNextLevelUnitDamageDisplay
            // 
            this.labelNextLevelUnitDamageDisplay.AutoSize = true;
            this.labelNextLevelUnitDamageDisplay.Location = new System.Drawing.Point(105, 300);
            this.labelNextLevelUnitDamageDisplay.Name = "labelNextLevelUnitDamageDisplay";
            this.labelNextLevelUnitDamageDisplay.Size = new System.Drawing.Size(138, 20);
            this.labelNextLevelUnitDamageDisplay.TabIndex = 21;
            this.labelNextLevelUnitDamageDisplay.Text = "nl unit dmg display";
            // 
            // labelNextLevelUnitHpDisplay
            // 
            this.labelNextLevelUnitHpDisplay.AutoSize = true;
            this.labelNextLevelUnitHpDisplay.Location = new System.Drawing.Point(74, 269);
            this.labelNextLevelUnitHpDisplay.Name = "labelNextLevelUnitHpDisplay";
            this.labelNextLevelUnitHpDisplay.Size = new System.Drawing.Size(125, 20);
            this.labelNextLevelUnitHpDisplay.TabIndex = 20;
            this.labelNextLevelUnitHpDisplay.Text = "nl unit hp display";
            // 
            // labelNextLevelUnitHpRegenDisplay
            // 
            this.labelNextLevelUnitHpRegenDisplay.AutoSize = true;
            this.labelNextLevelUnitHpRegenDisplay.Location = new System.Drawing.Point(129, 372);
            this.labelNextLevelUnitHpRegenDisplay.Name = "labelNextLevelUnitHpRegenDisplay";
            this.labelNextLevelUnitHpRegenDisplay.Size = new System.Drawing.Size(143, 20);
            this.labelNextLevelUnitHpRegenDisplay.TabIndex = 19;
            this.labelNextLevelUnitHpRegenDisplay.Text = "nl hpRegen display";
            // 
            // labelNextLevelUnitHpRegen
            // 
            this.labelNextLevelUnitHpRegen.AutoSize = true;
            this.labelNextLevelUnitHpRegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelUnitHpRegen.Location = new System.Drawing.Point(20, 372);
            this.labelNextLevelUnitHpRegen.Name = "labelNextLevelUnitHpRegen";
            this.labelNextLevelUnitHpRegen.Size = new System.Drawing.Size(87, 20);
            this.labelNextLevelUnitHpRegen.TabIndex = 18;
            this.labelNextLevelUnitHpRegen.Text = "HP Regen:";
            // 
            // labelUnitHpRegenDisplay
            // 
            this.labelUnitHpRegenDisplay.AutoSize = true;
            this.labelUnitHpRegenDisplay.Location = new System.Drawing.Point(129, 195);
            this.labelUnitHpRegenDisplay.Name = "labelUnitHpRegenDisplay";
            this.labelUnitHpRegenDisplay.Size = new System.Drawing.Size(127, 20);
            this.labelUnitHpRegenDisplay.TabIndex = 17;
            this.labelUnitHpRegenDisplay.Text = "hpRegen display";
            // 
            // labelUnitHpRegen
            // 
            this.labelUnitHpRegen.AutoSize = true;
            this.labelUnitHpRegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitHpRegen.Location = new System.Drawing.Point(20, 195);
            this.labelUnitHpRegen.Name = "labelUnitHpRegen";
            this.labelUnitHpRegen.Size = new System.Drawing.Size(87, 20);
            this.labelUnitHpRegen.TabIndex = 16;
            this.labelUnitHpRegen.Text = "HP Regen:";
            // 
            // labelUnitRangeDisplay
            // 
            this.labelUnitRangeDisplay.AutoSize = true;
            this.labelUnitRangeDisplay.Location = new System.Drawing.Point(92, 162);
            this.labelUnitRangeDisplay.Name = "labelUnitRangeDisplay";
            this.labelUnitRangeDisplay.Size = new System.Drawing.Size(149, 20);
            this.labelUnitRangeDisplay.TabIndex = 15;
            this.labelUnitRangeDisplay.Text = "unit damage display";
            // 
            // labelUnitDamageDisplay
            // 
            this.labelUnitDamageDisplay.AutoSize = true;
            this.labelUnitDamageDisplay.Location = new System.Drawing.Point(104, 128);
            this.labelUnitDamageDisplay.Name = "labelUnitDamageDisplay";
            this.labelUnitDamageDisplay.Size = new System.Drawing.Size(149, 20);
            this.labelUnitDamageDisplay.TabIndex = 14;
            this.labelUnitDamageDisplay.Text = "unit damage display";
            // 
            // labelUnitHpDisplay
            // 
            this.labelUnitHpDisplay.AutoSize = true;
            this.labelUnitHpDisplay.Location = new System.Drawing.Point(74, 98);
            this.labelUnitHpDisplay.Name = "labelUnitHpDisplay";
            this.labelUnitHpDisplay.Size = new System.Drawing.Size(109, 20);
            this.labelUnitHpDisplay.TabIndex = 13;
            this.labelUnitHpDisplay.Text = "unit hp display";
            // 
            // buttonUnitUpgrade
            // 
            this.buttonUnitUpgrade.Enabled = false;
            this.buttonUnitUpgrade.Location = new System.Drawing.Point(25, 412);
            this.buttonUnitUpgrade.Name = "buttonUnitUpgrade";
            this.buttonUnitUpgrade.Size = new System.Drawing.Size(272, 40);
            this.buttonUnitUpgrade.TabIndex = 12;
            this.buttonUnitUpgrade.Text = "Upgrade";
            this.buttonUnitUpgrade.UseVisualStyleBackColor = true;
            this.buttonUnitUpgrade.Click += new System.EventHandler(this.buttonUnitUpgrade_Click);
            // 
            // labelNextLevelUnitRange
            // 
            this.labelNextLevelUnitRange.AutoSize = true;
            this.labelNextLevelUnitRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelUnitRange.Location = new System.Drawing.Point(20, 334);
            this.labelNextLevelUnitRange.Name = "labelNextLevelUnitRange";
            this.labelNextLevelUnitRange.Size = new System.Drawing.Size(61, 20);
            this.labelNextLevelUnitRange.TabIndex = 11;
            this.labelNextLevelUnitRange.Text = "Range:";
            // 
            // labelNextLevelUnitDamage
            // 
            this.labelNextLevelUnitDamage.AutoSize = true;
            this.labelNextLevelUnitDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelUnitDamage.Location = new System.Drawing.Point(18, 300);
            this.labelNextLevelUnitDamage.Name = "labelNextLevelUnitDamage";
            this.labelNextLevelUnitDamage.Size = new System.Drawing.Size(74, 20);
            this.labelNextLevelUnitDamage.TabIndex = 10;
            this.labelNextLevelUnitDamage.Text = "Damage:";
            // 
            // labelNextLevelUnitHp
            // 
            this.labelNextLevelUnitHp.AutoSize = true;
            this.labelNextLevelUnitHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelUnitHp.Location = new System.Drawing.Point(20, 269);
            this.labelNextLevelUnitHp.Name = "labelNextLevelUnitHp";
            this.labelNextLevelUnitHp.Size = new System.Drawing.Size(35, 20);
            this.labelNextLevelUnitHp.TabIndex = 9;
            this.labelNextLevelUnitHp.Text = "HP:";
            // 
            // labelNextLevelUnit
            // 
            this.labelNextLevelUnit.AutoSize = true;
            this.labelNextLevelUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelUnit.Location = new System.Drawing.Point(20, 235);
            this.labelNextLevelUnit.Name = "labelNextLevelUnit";
            this.labelNextLevelUnit.Size = new System.Drawing.Size(121, 25);
            this.labelNextLevelUnit.TabIndex = 8;
            this.labelNextLevelUnit.Text = "Next Level:";
            // 
            // labelUnitRange
            // 
            this.labelUnitRange.AutoSize = true;
            this.labelUnitRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitRange.Location = new System.Drawing.Point(20, 162);
            this.labelUnitRange.Name = "labelUnitRange";
            this.labelUnitRange.Size = new System.Drawing.Size(61, 20);
            this.labelUnitRange.TabIndex = 7;
            this.labelUnitRange.Text = "Range:";
            // 
            // labelUnitDamage
            // 
            this.labelUnitDamage.AutoSize = true;
            this.labelUnitDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitDamage.Location = new System.Drawing.Point(18, 128);
            this.labelUnitDamage.Name = "labelUnitDamage";
            this.labelUnitDamage.Size = new System.Drawing.Size(74, 20);
            this.labelUnitDamage.TabIndex = 6;
            this.labelUnitDamage.Text = "Damage:";
            // 
            // labelUnitName
            // 
            this.labelUnitName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnitName.AutoSize = true;
            this.labelUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitName.Location = new System.Drawing.Point(20, 57);
            this.labelUnitName.Name = "labelUnitName";
            this.labelUnitName.Size = new System.Drawing.Size(155, 25);
            this.labelUnitName.TabIndex = 5;
            this.labelUnitName.Text = "unit name here";
            this.labelUnitName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnitHp
            // 
            this.labelUnitHp.AutoSize = true;
            this.labelUnitHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitHp.Location = new System.Drawing.Point(20, 98);
            this.labelUnitHp.Name = "labelUnitHp";
            this.labelUnitHp.Size = new System.Drawing.Size(35, 20);
            this.labelUnitHp.TabIndex = 4;
            this.labelUnitHp.Text = "HP:";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(181, 51);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(116, 40);
            this.buttonMove.TabIndex = 1;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.AutoSize = true;
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonPause);
            this.panelMenu.Controls.Add(this.buttonSlowDown);
            this.panelMenu.Controls.Add(this.buttonSpeedUp);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonNewGame);
            this.panelMenu.Location = new System.Drawing.Point(890, 22);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(326, 106);
            this.panelMenu.TabIndex = 6;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(226, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(90, 40);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "Setting";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(4, 3);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(96, 40);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Start";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonSlowDown
            // 
            this.buttonSlowDown.Enabled = false;
            this.buttonSlowDown.Location = new System.Drawing.Point(126, 49);
            this.buttonSlowDown.Name = "buttonSlowDown";
            this.buttonSlowDown.Size = new System.Drawing.Size(110, 40);
            this.buttonSlowDown.TabIndex = 3;
            this.buttonSlowDown.Text = "Slow Down";
            this.buttonSlowDown.UseVisualStyleBackColor = true;
            this.buttonSlowDown.Click += new System.EventHandler(this.buttonSlowDown_Click);
            // 
            // buttonSpeedUp
            // 
            this.buttonSpeedUp.Enabled = false;
            this.buttonSpeedUp.Location = new System.Drawing.Point(3, 49);
            this.buttonSpeedUp.Name = "buttonSpeedUp";
            this.buttonSpeedUp.Size = new System.Drawing.Size(116, 40);
            this.buttonSpeedUp.TabIndex = 2;
            this.buttonSpeedUp.Text = "Speed Up";
            this.buttonSpeedUp.UseVisualStyleBackColor = true;
            this.buttonSpeedUp.Click += new System.EventHandler(this.buttonSpeedUp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(242, 49);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 40);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(105, 3);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(116, 40);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // panelBuilding
            // 
            this.panelBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuilding.Controls.Add(this.labelNextLevelBuildingRangeDisplay);
            this.panelBuilding.Controls.Add(this.labelNextLevelBuildingProductionDisplay);
            this.panelBuilding.Controls.Add(this.labelNextLevelBuildingDamageDisplay);
            this.panelBuilding.Controls.Add(this.labelNextLevelBuildingHpDisplay);
            this.panelBuilding.Controls.Add(this.labelBuildingRangeDisplay);
            this.panelBuilding.Controls.Add(this.labelBuildingProductionDisplay);
            this.panelBuilding.Controls.Add(this.labelBuildingDamageDisplay);
            this.panelBuilding.Controls.Add(this.labelBuildingHpDisplay);
            this.panelBuilding.Controls.Add(this.labelNextLevelBuildingProduction);
            this.panelBuilding.Controls.Add(this.labelBuildingProduction);
            this.panelBuilding.Controls.Add(this.buttonBuildingUpgrade);
            this.panelBuilding.Controls.Add(this.labelNextLevelBuildingRange);
            this.panelBuilding.Controls.Add(this.labelNextLevelBuildingDamage);
            this.panelBuilding.Controls.Add(this.labelNextLevelBuildingHp);
            this.panelBuilding.Controls.Add(this.labelNextLevelBuilding);
            this.panelBuilding.Controls.Add(this.labelBuildingRange);
            this.panelBuilding.Controls.Add(this.labelBuildingDamage);
            this.panelBuilding.Controls.Add(this.labelBuildingName);
            this.panelBuilding.Controls.Add(this.labelBuildingHp);
            this.panelBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuilding.Location = new System.Drawing.Point(164, 3);
            this.panelBuilding.Name = "panelBuilding";
            this.panelBuilding.Size = new System.Drawing.Size(326, 466);
            this.panelBuilding.TabIndex = 7;
            this.panelBuilding.Visible = false;
            // 
            // labelNextLevelBuildingRangeDisplay
            // 
            this.labelNextLevelBuildingRangeDisplay.AutoSize = true;
            this.labelNextLevelBuildingRangeDisplay.Location = new System.Drawing.Point(93, 360);
            this.labelNextLevelBuildingRangeDisplay.Name = "labelNextLevelBuildingRangeDisplay";
            this.labelNextLevelBuildingRangeDisplay.Size = new System.Drawing.Size(176, 20);
            this.labelNextLevelBuildingRangeDisplay.TabIndex = 22;
            this.labelNextLevelBuildingRangeDisplay.Text = "nl building range display";
            // 
            // labelNextLevelBuildingProductionDisplay
            // 
            this.labelNextLevelBuildingProductionDisplay.AutoSize = true;
            this.labelNextLevelBuildingProductionDisplay.Location = new System.Drawing.Point(178, 322);
            this.labelNextLevelBuildingProductionDisplay.Name = "labelNextLevelBuildingProductionDisplay";
            this.labelNextLevelBuildingProductionDisplay.Size = new System.Drawing.Size(210, 20);
            this.labelNextLevelBuildingProductionDisplay.TabIndex = 21;
            this.labelNextLevelBuildingProductionDisplay.Text = "nl building production display";
            // 
            // labelNextLevelBuildingDamageDisplay
            // 
            this.labelNextLevelBuildingDamageDisplay.AutoSize = true;
            this.labelNextLevelBuildingDamageDisplay.Location = new System.Drawing.Point(107, 288);
            this.labelNextLevelBuildingDamageDisplay.Name = "labelNextLevelBuildingDamageDisplay";
            this.labelNextLevelBuildingDamageDisplay.Size = new System.Drawing.Size(166, 20);
            this.labelNextLevelBuildingDamageDisplay.TabIndex = 20;
            this.labelNextLevelBuildingDamageDisplay.Text = "nl building dmg display";
            // 
            // labelNextLevelBuildingHpDisplay
            // 
            this.labelNextLevelBuildingHpDisplay.AutoSize = true;
            this.labelNextLevelBuildingHpDisplay.Location = new System.Drawing.Point(74, 254);
            this.labelNextLevelBuildingHpDisplay.Name = "labelNextLevelBuildingHpDisplay";
            this.labelNextLevelBuildingHpDisplay.Size = new System.Drawing.Size(153, 20);
            this.labelNextLevelBuildingHpDisplay.TabIndex = 19;
            this.labelNextLevelBuildingHpDisplay.Text = "nl building hp display";
            // 
            // labelBuildingRangeDisplay
            // 
            this.labelBuildingRangeDisplay.AutoSize = true;
            this.labelBuildingRangeDisplay.Location = new System.Drawing.Point(93, 158);
            this.labelBuildingRangeDisplay.Name = "labelBuildingRangeDisplay";
            this.labelBuildingRangeDisplay.Size = new System.Drawing.Size(230, 20);
            this.labelBuildingRangeDisplay.TabIndex = 18;
            this.labelBuildingRangeDisplay.Text = "building range (water coverage)";
            // 
            // labelBuildingProductionDisplay
            // 
            this.labelBuildingProductionDisplay.AutoSize = true;
            this.labelBuildingProductionDisplay.Location = new System.Drawing.Point(178, 120);
            this.labelBuildingProductionDisplay.Name = "labelBuildingProductionDisplay";
            this.labelBuildingProductionDisplay.Size = new System.Drawing.Size(142, 20);
            this.labelBuildingProductionDisplay.TabIndex = 17;
            this.labelBuildingProductionDisplay.Text = "building production";
            // 
            // labelBuildingDamageDisplay
            // 
            this.labelBuildingDamageDisplay.AutoSize = true;
            this.labelBuildingDamageDisplay.Location = new System.Drawing.Point(107, 88);
            this.labelBuildingDamageDisplay.Name = "labelBuildingDamageDisplay";
            this.labelBuildingDamageDisplay.Size = new System.Drawing.Size(177, 20);
            this.labelBuildingDamageDisplay.TabIndex = 16;
            this.labelBuildingDamageDisplay.Text = "building damage display";
            // 
            // labelBuildingHpDisplay
            // 
            this.labelBuildingHpDisplay.AutoSize = true;
            this.labelBuildingHpDisplay.Location = new System.Drawing.Point(74, 52);
            this.labelBuildingHpDisplay.Name = "labelBuildingHpDisplay";
            this.labelBuildingHpDisplay.Size = new System.Drawing.Size(137, 20);
            this.labelBuildingHpDisplay.TabIndex = 15;
            this.labelBuildingHpDisplay.Text = "building hp display";
            // 
            // labelNextLevelBuildingProduction
            // 
            this.labelNextLevelBuildingProduction.AutoSize = true;
            this.labelNextLevelBuildingProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelBuildingProduction.Location = new System.Drawing.Point(20, 322);
            this.labelNextLevelBuildingProduction.Name = "labelNextLevelBuildingProduction";
            this.labelNextLevelBuildingProduction.Size = new System.Drawing.Size(136, 20);
            this.labelNextLevelBuildingProduction.TabIndex = 14;
            this.labelNextLevelBuildingProduction.Text = "Water Production:";
            // 
            // labelBuildingProduction
            // 
            this.labelBuildingProduction.AutoSize = true;
            this.labelBuildingProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuildingProduction.Location = new System.Drawing.Point(20, 120);
            this.labelBuildingProduction.Name = "labelBuildingProduction";
            this.labelBuildingProduction.Size = new System.Drawing.Size(135, 20);
            this.labelBuildingProduction.TabIndex = 13;
            this.labelBuildingProduction.Text = "Water production:";
            // 
            // buttonBuildingUpgrade
            // 
            this.buttonBuildingUpgrade.Enabled = false;
            this.buttonBuildingUpgrade.Location = new System.Drawing.Point(25, 403);
            this.buttonBuildingUpgrade.Name = "buttonBuildingUpgrade";
            this.buttonBuildingUpgrade.Size = new System.Drawing.Size(259, 40);
            this.buttonBuildingUpgrade.TabIndex = 12;
            this.buttonBuildingUpgrade.Text = "Upgrade";
            this.buttonBuildingUpgrade.UseVisualStyleBackColor = true;
            this.buttonBuildingUpgrade.Click += new System.EventHandler(this.buttonBuildingUpgrade_Click);
            // 
            // labelNextLevelBuildingRange
            // 
            this.labelNextLevelBuildingRange.AutoSize = true;
            this.labelNextLevelBuildingRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelBuildingRange.Location = new System.Drawing.Point(20, 360);
            this.labelNextLevelBuildingRange.Name = "labelNextLevelBuildingRange";
            this.labelNextLevelBuildingRange.Size = new System.Drawing.Size(61, 20);
            this.labelNextLevelBuildingRange.TabIndex = 11;
            this.labelNextLevelBuildingRange.Text = "Range:";
            // 
            // labelNextLevelBuildingDamage
            // 
            this.labelNextLevelBuildingDamage.AutoSize = true;
            this.labelNextLevelBuildingDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelBuildingDamage.Location = new System.Drawing.Point(20, 288);
            this.labelNextLevelBuildingDamage.Name = "labelNextLevelBuildingDamage";
            this.labelNextLevelBuildingDamage.Size = new System.Drawing.Size(74, 20);
            this.labelNextLevelBuildingDamage.TabIndex = 10;
            this.labelNextLevelBuildingDamage.Text = "Damage:";
            // 
            // labelNextLevelBuildingHp
            // 
            this.labelNextLevelBuildingHp.AutoSize = true;
            this.labelNextLevelBuildingHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelBuildingHp.Location = new System.Drawing.Point(20, 254);
            this.labelNextLevelBuildingHp.Name = "labelNextLevelBuildingHp";
            this.labelNextLevelBuildingHp.Size = new System.Drawing.Size(35, 20);
            this.labelNextLevelBuildingHp.TabIndex = 9;
            this.labelNextLevelBuildingHp.Text = "HP:";
            // 
            // labelNextLevelBuilding
            // 
            this.labelNextLevelBuilding.AutoSize = true;
            this.labelNextLevelBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextLevelBuilding.Location = new System.Drawing.Point(20, 214);
            this.labelNextLevelBuilding.Name = "labelNextLevelBuilding";
            this.labelNextLevelBuilding.Size = new System.Drawing.Size(121, 25);
            this.labelNextLevelBuilding.TabIndex = 8;
            this.labelNextLevelBuilding.Text = "Next Level:";
            // 
            // labelBuildingRange
            // 
            this.labelBuildingRange.AutoSize = true;
            this.labelBuildingRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuildingRange.Location = new System.Drawing.Point(20, 158);
            this.labelBuildingRange.Name = "labelBuildingRange";
            this.labelBuildingRange.Size = new System.Drawing.Size(61, 20);
            this.labelBuildingRange.TabIndex = 7;
            this.labelBuildingRange.Text = "Range:";
            // 
            // labelBuildingDamage
            // 
            this.labelBuildingDamage.AutoSize = true;
            this.labelBuildingDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuildingDamage.Location = new System.Drawing.Point(20, 88);
            this.labelBuildingDamage.Name = "labelBuildingDamage";
            this.labelBuildingDamage.Size = new System.Drawing.Size(74, 20);
            this.labelBuildingDamage.TabIndex = 6;
            this.labelBuildingDamage.Text = "Damage:";
            // 
            // labelBuildingName
            // 
            this.labelBuildingName.AutoSize = true;
            this.labelBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuildingName.Location = new System.Drawing.Point(19, 14);
            this.labelBuildingName.Name = "labelBuildingName";
            this.labelBuildingName.Size = new System.Drawing.Size(195, 25);
            this.labelBuildingName.TabIndex = 5;
            this.labelBuildingName.Text = "building name here";
            this.labelBuildingName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBuildingHp
            // 
            this.labelBuildingHp.AutoSize = true;
            this.labelBuildingHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuildingHp.Location = new System.Drawing.Point(20, 52);
            this.labelBuildingHp.Name = "labelBuildingHp";
            this.labelBuildingHp.Size = new System.Drawing.Size(35, 20);
            this.labelBuildingHp.TabIndex = 4;
            this.labelBuildingHp.Text = "HP:";
            // 
            // panelBuildNew
            // 
            this.panelBuildNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuildNew.Controls.Add(this.buttonBuildPipe);
            this.panelBuildNew.Controls.Add(this.buttonBuildPump);
            this.panelBuildNew.Controls.Add(this.buttonBuildDefender);
            this.panelBuildNew.Location = new System.Drawing.Point(518, 17);
            this.panelBuildNew.Name = "panelBuildNew";
            this.panelBuildNew.Size = new System.Drawing.Size(326, 217);
            this.panelBuildNew.TabIndex = 8;
            this.panelBuildNew.Visible = false;
            // 
            // buttonBuildPipe
            // 
            this.buttonBuildPipe.Location = new System.Drawing.Point(3, 143);
            this.buttonBuildPipe.Name = "buttonBuildPipe";
            this.buttonBuildPipe.Size = new System.Drawing.Size(320, 40);
            this.buttonBuildPipe.TabIndex = 14;
            this.buttonBuildPipe.Text = "Build Pipe";
            this.buttonBuildPipe.UseVisualStyleBackColor = true;
            this.buttonBuildPipe.Click += new System.EventHandler(this.buttonBuildPipe_Click);
            // 
            // buttonBuildPump
            // 
            this.buttonBuildPump.Enabled = false;
            this.buttonBuildPump.Location = new System.Drawing.Point(3, 80);
            this.buttonBuildPump.Name = "buttonBuildPump";
            this.buttonBuildPump.Size = new System.Drawing.Size(320, 40);
            this.buttonBuildPump.TabIndex = 13;
            this.buttonBuildPump.Text = "Build Pump";
            this.buttonBuildPump.UseVisualStyleBackColor = true;
            this.buttonBuildPump.Click += new System.EventHandler(this.buttonBuildPump_Click);
            // 
            // buttonBuildDefender
            // 
            this.buttonBuildDefender.Enabled = false;
            this.buttonBuildDefender.Location = new System.Drawing.Point(3, 15);
            this.buttonBuildDefender.Name = "buttonBuildDefender";
            this.buttonBuildDefender.Size = new System.Drawing.Size(320, 40);
            this.buttonBuildDefender.TabIndex = 12;
            this.buttonBuildDefender.Text = "Build Defender";
            this.buttonBuildDefender.UseVisualStyleBackColor = true;
            this.buttonBuildDefender.Click += new System.EventHandler(this.buttonBuildDefender_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 842);
            this.Controls.Add(this.panelBuilding);
            this.Controls.Add(this.panelBuildNew);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUnit);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.labelTicksPerSec);
            this.Controls.Add(this.labelTickPerSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1264, 871);
            this.Name = "FormMain";
            this.Text = "Fire Defender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelUnit.ResumeLayout(false);
            this.panelUnit.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelBuilding.ResumeLayout(false);
            this.panelBuilding.PerformLayout();
            this.panelBuildNew.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.Label labelTicksPerSec;
        private System.Windows.Forms.Label labelTickPerSec;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelUnit;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelTotalTicks;
        private System.Windows.Forms.Label labelEnergyDisplay;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonSlowDown;
        private System.Windows.Forms.Button buttonSpeedUp;
        private System.Windows.Forms.Label labelSelectedLocationDisplay;
        private System.Windows.Forms.Label labelFireLevelDisplay;
        private System.Windows.Forms.Label labelTreesLeftDisplay;
        private System.Windows.Forms.Label labelFireLevel;
        private System.Windows.Forms.Label labelTressLeft;
        private System.Windows.Forms.Button buttonUnitUpgrade;
        private System.Windows.Forms.Label labelNextLevelUnitRange;
        private System.Windows.Forms.Label labelNextLevelUnitDamage;
        private System.Windows.Forms.Label labelNextLevelUnitHp;
        private System.Windows.Forms.Label labelNextLevelUnit;
        private System.Windows.Forms.Label labelUnitRange;
        private System.Windows.Forms.Label labelUnitDamage;
        private System.Windows.Forms.Label labelUnitName;
        private System.Windows.Forms.Label labelUnitHp;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelBuilding;
        private System.Windows.Forms.Button buttonBuildingUpgrade;
        private System.Windows.Forms.Label labelNextLevelBuildingRange;
        private System.Windows.Forms.Label labelNextLevelBuildingDamage;
        private System.Windows.Forms.Label labelNextLevelBuildingHp;
        private System.Windows.Forms.Label labelNextLevelBuilding;
        private System.Windows.Forms.Label labelBuildingRange;
        private System.Windows.Forms.Label labelBuildingDamage;
        private System.Windows.Forms.Label labelBuildingName;
        private System.Windows.Forms.Label labelBuildingHp;
        private System.Windows.Forms.Label labelNextLevelBuildingProduction;
        private System.Windows.Forms.Label labelBuildingProduction;
        private System.Windows.Forms.Label labelUnitRangeDisplay;
        private System.Windows.Forms.Label labelUnitDamageDisplay;
        private System.Windows.Forms.Label labelUnitHpDisplay;
        private System.Windows.Forms.Label labelNextLevelUnitHpRegenDisplay;
        private System.Windows.Forms.Label labelNextLevelUnitHpRegen;
        private System.Windows.Forms.Label labelUnitHpRegenDisplay;
        private System.Windows.Forms.Label labelUnitHpRegen;
        private System.Windows.Forms.Panel panelBuildNew;
        private System.Windows.Forms.Button buttonBuildPipe;
        private System.Windows.Forms.Button buttonBuildPump;
        private System.Windows.Forms.Button buttonBuildDefender;
        private System.Windows.Forms.Label labelBuildingRangeDisplay;
        private System.Windows.Forms.Label labelBuildingProductionDisplay;
        private System.Windows.Forms.Label labelBuildingDamageDisplay;
        private System.Windows.Forms.Label labelBuildingHpDisplay;
        private System.Windows.Forms.Label labelWaterUsageDisplay;
        private System.Windows.Forms.Label labelWaterUsage;
        private System.Windows.Forms.Label labelNextLevelUnitRangeDisplay;
        private System.Windows.Forms.Label labelNextLevelUnitDamageDisplay;
        private System.Windows.Forms.Label labelNextLevelUnitHpDisplay;
        private System.Windows.Forms.Label labelNextLevelBuildingRangeDisplay;
        private System.Windows.Forms.Label labelNextLevelBuildingProductionDisplay;
        private System.Windows.Forms.Label labelNextLevelBuildingDamageDisplay;
        private System.Windows.Forms.Label labelNextLevelBuildingHpDisplay;
    }
}

