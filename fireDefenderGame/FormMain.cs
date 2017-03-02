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
        /// length of each rectangle
        /// </summary>
        int length;

        //graphics variables
        Graphics G;
        Rectangle r;

        //fps counter
        int tSec = DateTime.Now.Second;
        int tTicks = 0;
        int totalTicks = 0;

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
                //keep app responsive
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
            if (tSec == DateTime.Now.Second && isRunning)
            {
                tTicks = tTicks + 1;
                totalTicks ++;
                labelTotalTicksDisplay.Text = totalTicks.ToString();                
                System.Threading.Thread.Sleep(100);
            }
            else
            {
                labelTicksPerSec.Text = tTicks.ToString();
                tTicks = 0;
                tSec = DateTime.Now.Second;
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

                    G.FillRectangle(Brushes.Green, r);
                    G.DrawRectangle(Pens.Black, r);
                }
            }
        }

    }
}
