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
            PanelVisible("panelCustomize", false);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            this.Owner.Hide();
            this.Hide();
            FormMain.ROW = 10;
            FormMain.COL = 10;
            FormMain game = new FormMain();
            game.Show();
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            this.Owner.Hide();
            this.Hide();
            FormMain.ROW = 15;
            FormMain.COL = 15;
            FormMain game = new FormMain();
            game.Show();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            this.Owner.Hide();
            this.Hide();
            FormMain.ROW = 20;
            FormMain.COL = 20;
            FormMain game = new FormMain();
            game.Show();
        }

        private void buttonCustomize_Click(object sender, EventArgs e)
        {
            if (panelCustomize.Visible == true)
                PanelVisible("panelCustomize", false);
            else
                PanelVisible("panelCustomize", true);
        }

        private void PanelVisible(string panelName, bool visible)
        {
            var panel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == panelName);
            if (panel != default(Panel)) panel.Visible = visible;
        }

        private void difficulty_Scroll(object sender, ScrollEventArgs e)
        {
            clValue.Text = difficulty.Value.ToString();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            this.Owner.Hide();
            this.Hide();
            FormMain.ROW = difficulty.Value;
            FormMain.COL = difficulty.Value;
            FormMain game = new FormMain();
            game.Show();
        }
    }
}
