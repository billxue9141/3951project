using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fireDefenderGame
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// number of rows in the game
        /// </summary>
        static int ROW = 10;

        /// <summary>
        /// number of columns in the game
        /// </summary>
        static int COL = 10;

        /// <summary>
        /// maximum allowed ticks per sec
        /// </summary>
        static int MAX_TICK_PER_SEC = 50;

        /// <summary>
        /// minimum allowed ticks per sec
        /// </summary>
        static int MIN_TICK_PER_SEC = 2;

        /// <summary>
        /// initial ticks per sec
        /// </summary>
        static int INITIAL_TICK_PER_SEC = 10;

        /// <summary>
        /// length of each tile rectangle
        /// </summary>
        int tileLength;

        // previously selected tile location
        int prevX;
        int prevY;


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

        //game objects
        GameBoard gameBoard;

        public FormMain()
        {
            InitializeComponent();
            tileLength = (mapPanel.Height) / ROW;
            mapPanel.Paint += new PaintEventHandler(mapPanel_paint);
            this.MinimumSize = new Size(800, 600);
            gameBoard = new GameBoard(ROW, COL);
            initialTicksPerSec = INITIAL_TICK_PER_SEC;
            this.MouseClick += OnMapPanelMouseClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();

            graphicsLayer = this.CreateGraphics();
            StartGameLoop();

        }

        private void StartGameLoop()
        {
            //create & start the tick timer
            Timer t = new Timer();
            int prevTick = 0, currTick;
            startTimer(t);

            while (isRunning)
            {
                //keep app responsive ok
                Application.DoEvents();
                currTick = ticksPerSec;
                // 1. check user input

                // 2. check AI
                // 3. update object data (position, status etc.)
                if (currTick != prevTick)
                {
                    //update all objects (fire for now)
                }
                // 4. check triggers and conditions
                // 5. draw graphics
                mapPanel.Update();
                // 6. sound effects & music

                // 7. update tick counter
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
            int currentXPos = (this.PointToClient(Cursor.Position).X - mapPanel.Location.X) / tileLength;
            int currentYPos = (this.PointToClient(Cursor.Position).Y - mapPanel.Location.Y) / tileLength;
            //these two lines can be removed later
            labelMouseXDisplay.Text = currentXPos.ToString();
            labelMouseYDisplay.Text = currentYPos.ToString();
            if (currentXPos < ROW && currentYPos < COL)
            {
                graphicsLayer = mapPanel.CreateGraphics();
                gameBoard.board[prevX, prevY].isSelected = false;
                updateTile(prevX, prevY, graphicsLayer);
                gameBoard.board[currentXPos, currentYPos].isSelected = true;
                updateTile(currentXPos, currentYPos, graphicsLayer);
                prevX = currentXPos;
                prevY = currentYPos;
            }
        }

        private void startTimer(Timer t)
        {
            t.Interval = 1000 / initialTicksPerSec; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (currentSecond == DateTime.Now.Second && isRunning)
            {
                ticksPerSec = ticksPerSec + 1;
                totalTicks++;
                labelTotalTicksDisplay.Text = totalTicks.ToString();
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
                    updateTile(i, j, graphicsLayer);
        }

        /// <summary>
        /// draw or update all the items on the tile at position x, y
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        /// <param name="graphicsLayer"></param>
        public void updateTile(int xPos, int yPos, Graphics graphicsLayer)
        {
            r = new Rectangle(xPos * tileLength, yPos * tileLength, tileLength, tileLength);
            Tile currentTile = gameBoard.board[xPos, yPos];
            try
            {
                //draw terrain
                Image newImage = Image.FromFile(currentTile.terrain.getImageDebugLocation());
                graphicsLayer.DrawImage(newImage, r);

                //draw building

                //draw fire
                if (gameBoard.board[xPos, yPos].fire != null)
                {
                    newImage = Image.FromFile(currentTile.fire.getImageDebugLocation());
                    graphicsLayer.DrawImage(newImage, r);
                }

                //draw units

                //draw selection
                if (currentTile.isSelected)
                    graphicsLayer.DrawRectangle(Pens.Red, new Rectangle(xPos * tileLength, yPos * tileLength, tileLength - 1, tileLength - 1));
            }
            catch (Exception)
            {
                //if image file can not be found, print tile with green brush.
                graphicsLayer.FillRectangle(Brushes.Green, r);
            }
        }

        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            if (initialTicksPerSec < MAX_TICK_PER_SEC)
                initialTicksPerSec++;
        }

        private void buttonSlowDown_Click(object sender, EventArgs e)
        {
            if (initialTicksPerSec > MIN_TICK_PER_SEC)
                initialTicksPerSec--;
        }
    }
}
