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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        dlgGameMode dlgGamemode;
        dlgSettings dlgsettings;
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            if (dlgGamemode == null)
            {
                dlgGamemode = new dlgGameMode();
                dlgGamemode.Owner = this;
                dlgGamemode.FormClosed += new FormClosedEventHandler(dlg_FormClosed);
                dlgGamemode.Show();
            }
            else
                dlgGamemode.Activate();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (dlgsettings == null)
            {
                dlgsettings = new dlgSettings();
                dlgsettings.Owner = this;
                dlgsettings.FormClosed += new FormClosedEventHandler(dlg_FormClosed);
                dlgsettings.Show();
            }
            else
                dlgsettings.Activate();
        }
        
        private void buttonCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sean Lee\nBenjamin Hao\nBill Xue", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void dlg_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dlgGamemode != null)
                dlgGamemode = null;
            if (dlgsettings != null)
                dlgsettings = null;
        }
    }
}
