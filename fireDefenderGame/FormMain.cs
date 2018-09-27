using fireDefenderGame.buildings;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace fireDefenderGame
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// number of rows in the game
        /// </summary>
        public static int ROW = 10;

        /// <summary>
        /// number of columns in the game
        /// </summary>
        public static int COL = 10;

        /// <summary>
        /// maximum allowed ticks per sec
        /// </summary>
        static int MAX_TICK_PER_SEC = 150;

        /// <summary>
        /// minimum allowed ticks per sec
        /// </summary>
        static int MIN_TICK_PER_SEC = 2;

        /// <summary>
        /// initial ticks per sec
        /// </summary>
        static int INITIAL_TICK_PER_SEC = 3;

        /// <summary>
        /// length of each tile rectangle
        /// </summary>
        int tileLength;

        Size formSize;

        // previously selected tile location
        int prevX;
        int prevY;

        //currently selected unit
        Unit selectedUnit;

        //graphics variables
        Graphics graphicsLayer;
        Rectangle r;

        //fps counter
        int currentSecond = DateTime.Now.Second;
        int ticksPerSec = 0;
        int totalTicks = 0;
        int initialTicksPerSec;

        //game running?
        bool isRunning = true;
        bool isPaused = true;   //start the game paused so the player can choose when to start

        //game objects
        GameBoard gameBoard;

        public FormMain()
        {
            InitializeComponent();
            tileLength = (mapPanel.Height) / ROW;
            this.MinimumSize = new Size(850, 586);
            formSize = this.Size;
            gameBoard = new GameBoard(ROW, COL, this);
            mapPanel.Paint += new PaintEventHandler(mapPanel_paint);
            initialTicksPerSec = INITIAL_TICK_PER_SEC;
            this.MouseClick += OnMapPanelMouseClick;
            prevX = ((Building)gameBoard.buildings[0]).tile.row;
            prevY = ((Building)gameBoard.buildings[0]).tile.col;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();

            graphicsLayer = this.CreateGraphics();

            //align all the info panel's locations to overlay each other
            panelBuildNew.Location = panelUnit.Location;
            panelBuilding.Location = panelUnit.Location;
            StartGameLoop();
        }

        /// <summary>
        /// the main game loop
        /// </summary>
        private void StartGameLoop()
        {
            //create & start the tick timer
            Timer t = new Timer();
            int prevTick = 0, currTick;
            startTimer(t);

            while (isRunning)
            {
                //keep app responsive 
                Application.DoEvents();

                //check if the user resized the main form, update the size of graphics accordingly
                if (this.Size != formSize)
                {
                    formSize = this.Size;
                    if ((mapPanel.Height) / ROW < (mapPanel.Width) / ROW)
                        tileLength = (mapPanel.Height) / ROW;
                    else
                        tileLength = (mapPanel.Width) / ROW;

                    // mapPanel.Height = tileLength * ROW;
                    // mapPanel.Width = tileLength * ROW;
                    graphicsLayer = mapPanel.CreateGraphics();
                    graphicsLayer.Clear(SystemColors.Control);
                    for (int i = 0; i < COL; i++)
                        for (int j = 0; j < ROW; j++)
                            updateTile(i, j);
                }

                //if game is paused, do not update any game objects
                if (isPaused)
                    continue;
                currTick = ticksPerSec;

                //loop through game objects everytime our timer ticks
                if (currTick != prevTick)
                {
                    //if there's no more fire left, show "win" message
                    if (gameBoard.fires == null || gameBoard.fires.Count == 0)
                    {
                        stopTimer(t);
                        MessageBox.Show("Congratulations, you saved the forest!" + Environment.NewLine
                            + "You used " + totalTicks.ToString() + " game time!",
                            "Congratulations", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        break;
                    }

                    //if fire station burnt down, show "game over" message
                    if (gameBoard.fireStation.currentHp < gameBoard.fireStation.maxHp)
                    {
                        stopTimer(t);
                        MessageBox.Show("You lost the fire station!", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        break;
                    }

                    //loop through all units
                    foreach (Unit unit in gameBoard.units)
                        unit.tile.update();

                    //loop through all fires                     
                    foreach (Fire fire in gameBoard.fires)
                        fire.tile.update();

                    //loops through all buildings (generate energy etc.)
                    foreach (Building building in gameBoard.buildings)
                        building.update();

                    //update all game objects
                    ArrayList tmpFire = new ArrayList();
                    ArrayList tmpUnit = new ArrayList();

                    for (int i = 0; i < COL; i++)
                        for (int j = 0; j < ROW; j++)
                        {
                            if (gameBoard.board[i, j].fire != null)
                                tmpFire.Add(gameBoard.board[i, j].fire);
                            if (gameBoard.board[i, j].unit != null)
                                tmpUnit.Add(gameBoard.board[i, j].unit);
                        }
                    gameBoard.fires = tmpFire;
                    gameBoard.units = tmpUnit;

                    //update tile info panel
                    labelWaterUsageDisplay.Text = gameBoard.gameResource.waterUsage + " / " + gameBoard.gameResource.waterProduction;

                    if (gameBoard.board[prevX, prevY].fire != null)
                        labelFireLevelDisplay.Text = gameBoard.board[prevX, prevY].fire.currentHp.ToString();
                    else
                        labelFireLevelDisplay.Text = "N/A";
                    if (gameBoard.board[prevX, prevY].terrain != null)
                        labelTreesLeftDisplay.Text = gameBoard.board[prevX, prevY].terrain.currentHp.ToString();
                    else
                        labelTreesLeftDisplay.Text = "0";

                    //update info panels
                    updateInfoPanel(gameBoard.board[prevX, prevY]);
                }

                // draw graphics
                mapPanel.Update();

                // no sound effects & music for now, we can add them here

                // update tick counter
                t.Interval = 1000 / initialTicksPerSec;
                prevTick = ticksPerSec;
            }
        }

        /// <summary>
        /// when the user click on the game board,
        /// read the mouse's current position, highlight the selected tile,
        /// and show the tile's information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnMapPanelMouseClick(Object sender, MouseEventArgs e)
        {
            buttonPause.Enabled = true;
            int currentXPos = (this.PointToClient(Cursor.Position).X - mapPanel.Location.X) / tileLength;
            int currentYPos = (this.PointToClient(Cursor.Position).Y - mapPanel.Location.Y) / tileLength;
            labelSelectedLocationDisplay.Text = currentXPos.ToString() + ", " + currentYPos.ToString();
            if (currentXPos < ROW && currentYPos < COL)
            {
                panelInfo.Visible = true;

                //move selected unit, if the target tile does not have a building, and is within a tile with water
                if (selectedUnit != null
                    && gameBoard.board[currentXPos, currentYPos].building == null
                    && gameBoard.board[currentXPos, currentYPos].terrain.hasWater)
                {
                    Unit tmpUnit = selectedUnit.copy();
                    gameBoard.units.Remove(selectedUnit);
                    selectedUnit.tile.unit = null;

                    tmpUnit.tile = gameBoard.board[currentXPos, currentYPos];
                    gameBoard.board[currentXPos, currentYPos].unit = tmpUnit;
                    gameBoard.units.Add(tmpUnit);
                    selectedUnit = null;

                    updateTile(prevX, prevY);
                    updateTile(currentXPos, currentYPos);
                    panelUnit.Visible = true;
                }
                else
                {
                    selectedUnit = null;
                }

                //update graphics
                graphicsLayer = mapPanel.CreateGraphics();
                gameBoard.board[prevX, prevY].isSelected = false;
                updateTile(prevX, prevY);
                gameBoard.board[currentXPos, currentYPos].isSelected = true;
                updateTile(currentXPos, currentYPos);

                //show tile info
                labelTreesLeftDisplay.Text = gameBoard.board[currentXPos, currentYPos].terrain.currentHp.ToString();
                if (gameBoard.board[currentXPos, currentYPos].fire == null)
                    labelFireLevelDisplay.Text = "N/A";
                else
                    labelFireLevelDisplay.Text = gameBoard.board[currentXPos, currentYPos].fire.currentHp.ToString();

                //show all other panel info
                updateInfoPanel(gameBoard.board[currentXPos, currentYPos]);

                //reset the previous x and y positions
                prevX = currentXPos;
                prevY = currentYPos;
            }
        }


        /// <summary>
        /// draw and update all the items on the tile at position x, y
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        /// <param name="graphicsLayer"></param>
        public void updateTile(int xPos, int yPos)
        {
            r = new Rectangle(xPos * tileLength, yPos * tileLength, tileLength, tileLength);
            Tile currentTile = gameBoard.board[xPos, yPos];
            try
            {
                //draw terrain
                Image newImage = Image.FromFile(currentTile.terrain.getImageDebugLocation());
                graphicsLayer.DrawImage(newImage, r);

                //draw building
                if (gameBoard.board[xPos, yPos].building != null)
                {
                    newImage = Image.FromFile(currentTile.building.getImageDebugLocation());
                    graphicsLayer.DrawImage(newImage, r);
                }

                //draw units
                if (gameBoard.board[xPos, yPos].unit != null)
                {
                    newImage = Image.FromFile(currentTile.unit.getImageDebugLocation());
                    graphicsLayer.DrawImage(newImage, r);
                }

                //draw fire
                if (gameBoard.board[xPos, yPos].fire != null)
                {
                    newImage = Image.FromFile(currentTile.fire.getImageDebugLocation());
                    graphicsLayer.DrawImage(newImage, r);
                }

                //show tiles where fire is being put out
                if (currentTile.isUnderWaterAttack)
                    graphicsLayer.DrawRectangle(Pens.Blue, new Rectangle(xPos * tileLength, yPos * tileLength, tileLength - 1, tileLength - 1));

                //draw selection
                if (currentTile.isSelected)
                    graphicsLayer.DrawRectangle(Pens.Red, new Rectangle(xPos * tileLength, yPos * tileLength, tileLength - 1, tileLength - 1));
            }
            catch (Exception)
            {
                //if image file can not be found, print tile with green brush.
                //graphicsLayer.FillRectangle(Brushes.Green, r);
            }
        }

        /// <summary>
        /// update all the info on unit/building/build new panel
        /// </summary>
        void updateInfoPanel(Tile tile)
        {
            //show unit panel if select tile has a unit
            if (tile.unit != null)
            {
                panelUnit.Visible = true;
                panelBuilding.Visible = false;
                panelBuildNew.Visible = false;
                labelUnitName.Text = tile.unit.description;
                labelUnitHpDisplay.Text = tile.unit.currentHp.ToString();
                labelUnitDamageDisplay.Text = tile.unit.minDamage + " to " + tile.unit.maxDamage;
                labelUnitRangeDisplay.Text = tile.unit.attackRange.ToString();
                labelUnitHpRegenDisplay.Text = tile.unit.hpRegen.ToString();

                labelNextLevelUnitHpDisplay.Text = tile.unit.nextLevelHp.ToString();
                labelNextLevelUnitDamageDisplay.Text = tile.unit.nextLevelMinDamage + " to " + tile.unit.nextLevelMaxDamage;
                buttonUnitUpgrade.Text = "Upgrade (" + tile.unit.upgradeCost + " Energy)";
                //for now these stats doesn't change
                labelNextLevelUnitHpRegenDisplay.Text = tile.unit.hpRegen.ToString();
                labelNextLevelUnitRangeDisplay.Text = tile.unit.nextLevelRange.ToString();

                //if player doesn't have enough energy for upgrade, disable the upgrade button
                if (gameBoard.gameResource.energy < tile.unit.upgradeCost)
                    buttonUnitUpgrade.Enabled = false;
                else
                    buttonUnitUpgrade.Enabled = true;
            }

            //show building panel if selected tile has a building
            else if (tile.building != null)
            {
                panelUnit.Visible = false;
                panelBuilding.Visible = true;
                panelBuildNew.Visible = false;
                labelBuildingName.Text = tile.building.description;
                labelBuildingHpDisplay.Text = tile.building.currentHp.ToString();
                labelBuildingDamageDisplay.Text = tile.building.minDamage + " to " + tile.building.maxDamage;
                labelBuildingProductionDisplay.Text = tile.building.waterProduction.ToString();
                labelBuildingRangeDisplay.Text = tile.building.radius.ToString();
                labelBuildingEnergyProductionDisplay.Text = tile.building.energyProduction.ToString();

                labelNextLevelBuildingHpDisplay.Text = tile.building.nextLevelHp.ToString();
                labelNextLevelBuildingDamageDisplay.Text = tile.building.nextLevelMinDamage + " to " + tile.building.nextLevelMaxDamage;
                labelNextLevelBuildingProductionDisplay.Text = tile.building.nextLevelWaterProduction.ToString();
                labelNextLevelBuildingRangeDisplay.Text = tile.building.nextLevelRange.ToString();
                labelNextLevelBuildingEnergyProductionDisplay.Text = tile.building.nextLevelEnergyProduction.ToString();

                buttonBuildingUpgrade.Text = "Upgrade (" + tile.building.upgradeCost + " Energy)";
                //if player doesn't have enough energy for upgrade, disable the upgrade button
                if (gameBoard.gameResource.energy < tile.building.upgradeCost)
                    buttonBuildingUpgrade.Enabled = false;
                else
                    buttonBuildingUpgrade.Enabled = true;
            }

            //else show the "construct new building/unit" panel
            else
            {
                panelUnit.Visible = false;
                panelBuilding.Visible = false;
                panelBuildNew.Visible = true;
                if (!tile.terrain.hasWater)
                {
                    buttonBuildPipe.Enabled = false;
                    buttonBuildDefender.Enabled = false;
                    buttonBuildPump.Enabled = false;
                    buttonBuildEnergyGenerator.Enabled = false;
                }
                else
                {
                    //enable build Pump button if player has enough energy
                    if (gameBoard.gameResource.energy < Pump.BUILD_COST)
                        buttonBuildPump.Enabled = false;
                    else
                        buttonBuildPump.Enabled = true;

                    if (gameBoard.gameResource.waterUsage >= gameBoard.gameResource.waterProduction)
                    {
                        buttonBuildPipe.Enabled = false;
                        buttonBuildDefender.Enabled = false;
                        buttonBuildEnergyGenerator.Enabled = false;
                        buttonBuildPump.Text = "Build Pump (" + Pump.BUILD_COST + " Energy)";
                        buttonBuildPipe.Text = "Build Pipe (need more water)";
                        buttonBuildDefender.Text = "Build Defender (need more water)";
                        buttonBuildEnergyGenerator.Text = "Build Energy Generator (need more water)";
                    }
                    else
                    {
                        buttonBuildPipe.Text = "Build Pipe (" + Pipe.BUILD_COST + " Energy)";
                        buttonBuildDefender.Text = "Build Defender (" + Defender.BUILD_COST + " Energy)";
                        buttonBuildPump.Text = "Build Pump (" + Pump.BUILD_COST + " Energy)";
                        buttonBuildEnergyGenerator.Text = "Build Energy Generator (" + EnergyGenerator.BUILD_COST + " Energy)";

                        //enable build defender button if player has engough energy
                        if (gameBoard.gameResource.energy < Defender.BUILD_COST)
                            buttonBuildDefender.Enabled = false;
                        else
                            buttonBuildDefender.Enabled = true;

                        //enable build pipe button if player has enough energy
                        if (gameBoard.gameResource.energy < Pipe.BUILD_COST)
                            buttonBuildPipe.Enabled = false;
                        else
                            buttonBuildPipe.Enabled = true;

                        //enable build energy generator if player has enough energy
                        if (gameBoard.gameResource.energy < EnergyGenerator.BUILD_COST)
                            buttonBuildEnergyGenerator.Enabled = false;
                        else
                            buttonBuildEnergyGenerator.Enabled = true;
                    }
                }
            }
        }

        private void startTimer(Timer t)
        {
            t.Interval = 1000 / initialTicksPerSec; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        private void stopTimer(Timer t)
        {
            t.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isPaused)
                return;
            if (currentSecond == DateTime.Now.Second && isRunning)
            {
                ticksPerSec = ticksPerSec + 1;
                totalTicks++;
                gameBoard.gameResource.energy += gameBoard.gameResource.energyGeneration;
                labelEnergyDisplay.Text = gameBoard.gameResource.energy.ToString() + " (" + gameBoard.gameResource.energyGeneration + " per tick)";
            }
            else
            {
                labelTicksPerSec.Text = ticksPerSec.ToString();
                ticksPerSec = 0;
                currentSecond = DateTime.Now.Second;
            }
        }

        private void mapPanel_paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            graphicsLayer = e.Graphics;
            graphicsLayer.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            for (int i = 0; i < COL; i++)
                for (int j = 0; j < ROW; j++)
                    updateTile(i, j);
        }

        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            if (initialTicksPerSec < MAX_TICK_PER_SEC)
            {
                int tmp = initialTicksPerSec * 2;
                if (tmp > MAX_TICK_PER_SEC)
                    initialTicksPerSec = MAX_TICK_PER_SEC;
                else
                    initialTicksPerSec = tmp;
            }
        }

        private void buttonSlowDown_Click(object sender, EventArgs e)
        {
            if (initialTicksPerSec > MIN_TICK_PER_SEC)
            {
                int tmp = initialTicksPerSec / 2;
                if (tmp < MIN_TICK_PER_SEC)
                    initialTicksPerSec = MIN_TICK_PER_SEC;
                else
                    initialTicksPerSec = tmp;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                buttonPause.Text = "Pause";
                isPaused = false;
                buttonSlowDown.Enabled = true;
                buttonSpeedUp.Enabled = true;
                panelInfo.Visible = true;
            }
            else
            {
                buttonPause.Text = "Resume";
                isPaused = true;
                buttonSlowDown.Enabled = false;
                buttonSpeedUp.Enabled = false;
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (gameBoard.board[prevX, prevY].unit != null)
                selectedUnit = gameBoard.board[prevX, prevY].unit;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Fire defender", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            dlgGameMode dlgGameMode = new dlgGameMode();
            dlgGameMode.Owner = this;
            dlgGameMode.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            dlgSettings dlgsettings = new dlgSettings();
            dlgsettings.Owner = this;
            dlgsettings.Show();
        }

        private void buttonBuildPipe_Click(object sender, EventArgs e)
        {
            if (gameBoard.board[prevX, prevY].building != null)
                return;
            gameBoard.gameResource.energy -= Pipe.BUILD_COST;
            Building building = new Pipe(gameBoard.board[prevX, prevY], gameBoard.random);
            gameBoard.board[prevX, prevY].building = building;
            gameBoard.buildings.Add(building);
            panelBuildNew.Visible = false;
            panelBuilding.Visible = true;
            updateTile(prevX, prevY);
        }

        private void buttonBuildPump_Click(object sender, EventArgs e)
        {
            if (gameBoard.board[prevX, prevY].building != null)
                return;
            gameBoard.gameResource.energy -= Pump.BUILD_COST;
            Building building = new Pump(gameBoard.board[prevX, prevY], gameBoard.random);
            gameBoard.board[prevX, prevY].building = building;
            gameBoard.buildings.Add(building);
            panelBuildNew.Visible = false;
            panelBuilding.Visible = true;
            updateTile(prevX, prevY);
        }

        private void buttonBuildDefender_Click(object sender, EventArgs e)
        {
            if (gameBoard.board[prevX, prevY].unit != null)
                return;
            gameBoard.gameResource.energy -= Defender.BUILD_COST;
            Unit unit = new Defender(gameBoard.board[prevX, prevY], gameBoard.random);
            gameBoard.board[prevX, prevY].unit = unit;
            gameBoard.units.Add(unit);
            panelBuildNew.Visible = false;
            panelUnit.Visible = true;
            updateTile(prevX, prevY);
        }

        private void buttonBuildEnergyGenerator_Click(object sender, EventArgs e)
        {
            if (gameBoard.board[prevX, prevY].building != null)
                return;
            gameBoard.gameResource.energy -= EnergyGenerator.BUILD_COST;
            Building building = new EnergyGenerator(gameBoard.board[prevX, prevY], gameBoard.random);
            gameBoard.board[prevX, prevY].building = building;
            gameBoard.buildings.Add(building);
            panelBuildNew.Visible = false;
            panelBuilding.Visible = true;
            updateTile(prevX, prevY);
        }


        private void buttonUnitUpgrade_Click(object sender, EventArgs e)
        {
            if (gameBoard.gameResource.energy > gameBoard.board[prevX, prevY].unit.upgradeCost)
                gameBoard.gameResource.energy -= gameBoard.board[prevX, prevY].unit.upgradeCost;
            gameBoard.board[prevX, prevY].unit.upgrade();
            updateTile(prevX, prevY);
        }

        private void buttonBuildingUpgrade_Click(object sender, EventArgs e)
        {
            if (gameBoard.gameResource.energy > gameBoard.board[prevX, prevY].building.upgradeCost)
                gameBoard.gameResource.energy -= gameBoard.board[prevX, prevY].building.upgradeCost;
            gameBoard.board[prevX, prevY].building.upgrade();
            updateTile(prevX, prevY);
        }
    }
}
