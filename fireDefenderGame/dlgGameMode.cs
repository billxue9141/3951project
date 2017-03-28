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
    public partial class dlgGameMode : Form
    {
        public dlgGameMode()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            FormMain game = new FormMain();
            game.Show();
            this.Close();
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            FormMain game = new FormMain();
            game.Show();
            this.Close();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            FormMain game = new FormMain();
            game.Show();
            this.Close();
        }

        private void buttonCustomize_Click(object sender, EventArgs e)
        {
            FormMain game = new FormMain();
            game.Show();
            this.Close();
        }

    }
}
