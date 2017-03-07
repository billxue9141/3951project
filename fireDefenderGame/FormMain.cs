using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        static int ROW = 20;

        /// <summary>
        /// number of columns in the game
        /// </summary>
        static int COL = 20;

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
        /// length of each rectangle
        /// </summary>
        int length;

        //graphics variables
        Graphics G;
        Rectangle r;

        //fps counter
        int currentSecond = DateTime.Now.Second;
        int ticksPerSec = 0;
        int totalTicks = 0;
        int initialTicksPerSec;

        //game running?
        bool isRunning = true;

        GameBoard gameBoard;


        public FormMain()
        {
            InitializeComponent();
            length = (mapPanel.Height) / ROW;
            mapPanel.Paint += new PaintEventHandler(mapPanel_paint);
            this.MinimumSize = new Size(800, 600);
            gameBoard = new GameBoard(ROW, COL);
            initialTicksPerSec = INITIAL_TICK_PER_SEC;
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();

            G = this.CreateGraphics();
            StartGameLoop();

        }

        private void StartGameLoop()
        {
            while (isRunning)
            {
                //keep app responsive ok
                Application.DoEvents();

                // 1. check user input
                // 2. check AI
                // 3. update object data (position, status etc.)
                // 4. check triggers and conditions
                // 5. draw graphics
                // 6. sound effects & music

                // update tick counter
                TickCounter();
                updateCursor();
                mapPanel.Update();
                
            }
        }
        
        private void updateCursor()
        {
            Point point = Control.MousePosition;
            labelmouseXDisplay.Text = point.X.ToString();
            labelMouseYDisplay.Text = point.Y.ToString();
        }

        private void TickCounter()
        {
            if (currentSecond == DateTime.Now.Second && isRunning)
            {
                ticksPerSec = ticksPerSec + 1;
                totalTicks ++;
                labelTotalTicksDisplay.Text = totalTicks.ToString();                
                System.Threading.Thread.Sleep(1000/initialTicksPerSec);
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
            G = e.Graphics;

            G.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), p.DisplayRectangle);

            int length = p.Height / ROW;

            for (int i = 0; i < COL; i++)
            {
                for (int j = 0; j < ROW; j++)
                {
                    r = new Rectangle(i * length, j * length, length, length);
                    //if the tile is on fire, fill tile with a different color - replace with an image later
                    if (gameBoard.board[i, j].fire != null)
                        G.FillRectangle(Brushes.Red, r);
                    else
                        G.FillRectangle(Brushes.Green, r);
                    
                    G.DrawRectangle(Pens.Black, r);
                }
            }
        }

        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            if(initialTicksPerSec < MAX_TICK_PER_SEC)
                initialTicksPerSec++;
        }

        private void buttonSlowDown_Click(object sender, EventArgs e)
        {
            if (initialTicksPerSec > MIN_TICK_PER_SEC)
                initialTicksPerSec--;
        }
    }
}
