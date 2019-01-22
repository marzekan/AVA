using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAG___Aplikacija_za_alternativno_glasanje.UserControls
{
    public partial class UcExitBtn : UserControl
    {
        public UcExitBtn()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Jeste li sigurni da želite izaći iz APAG - Aplikacija za alternativno glasanje?",
                "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            //Application.Exit();
        }

        private void lblExit_MouseMove(object sender, MouseEventArgs e)
        {
            lblExit.Font = new Font(lblExit.Font, FontStyle.Bold);
            lblExit.BackColor = Color.LightBlue;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.Font = new Font(lblExit.Font, FontStyle.Regular);
            lblExit.BackColor = Color.Transparent;
        }
    }
}
