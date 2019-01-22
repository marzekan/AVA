using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APAG___Aplikacija_za_alternativno_glasanje.HelpControls;

namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    public partial class FrmHelp : Form
    {
        private Point mouseLocation;

        public FrmHelp(FrmLogin frmLogin)
        {
            InitializeComponent();
            tvSadrzaj.ExpandAll();
            OnemogucavanjeSadrzajaLogin();
            tvSadrzaj.SelectedNode = tvSadrzaj.Nodes[0].Nodes[0];
        }

        public FrmHelp(FrmGlavniIzbornik_Glasacki frmGlIzbGlasacki)
        {
            InitializeComponent();
            tvSadrzaj.ExpandAll();
            OnemoguvacanjeSadrzajaGlIzbGlasac();
            tvSadrzaj.SelectedNode = tvSadrzaj.Nodes[1].Nodes[0];
        }

        public FrmHelp(FrmGlavniIzbornik_Admin frmGlIzbAdmin)
        {
            InitializeComponent();
            tvSadrzaj.ExpandAll();
            OnemoguvacanjeSadrzajaGlIzbAdmin();
            tvSadrzaj.SelectedNode = tvSadrzaj.Nodes[2];
        }

        public FrmHelp(FrmPostavkeGlasanja frmPostavkeGlasanja)
        {
            InitializeComponent();
            tvSadrzaj.ExpandAll();
            OnemoguvacanjeSadrzajaGlIzbAdmin();
            tvSadrzaj.SelectedNode = tvSadrzaj.Nodes[2].Nodes[0];
        }

        public FrmHelp(FrmDodavanjeKandidata frmDodavanjeKandidata)
        {
            InitializeComponent();
            tvSadrzaj.ExpandAll();
            OnemoguvacanjeSadrzajaGlIzbAdmin();
            tvSadrzaj.SelectedNode = tvSadrzaj.Nodes[2].Nodes[1];
        }

        public FrmHelp(FrmDodavanjeGlasaca frmDodavanjeGlasaca)
        {
            InitializeComponent();
            tvSadrzaj.ExpandAll();
            OnemoguvacanjeSadrzajaGlIzbAdmin();
            tvSadrzaj.SelectedNode = tvSadrzaj.Nodes[2].Nodes[2];
        }

        /// <summary>
        /// Dozvoljava korisniku samo prikaz informacija za Administratorski glavni izbornik.
        /// </summary>
        private void OnemoguvacanjeSadrzajaGlIzbAdmin()
        {
            foreach (TreeNode node in tvSadrzaj.Nodes)
            {
                if (node == tvSadrzaj.Nodes[0])
                {
                    node.ForeColor = Color.Gray;

                    foreach (TreeNode childnode in tvSadrzaj.Nodes[0].Nodes)
                    {
                        childnode.ForeColor = Color.Gray;
                    }
                }
                if (node == tvSadrzaj.Nodes[1])
                {
                    node.ForeColor = Color.Gray;

                    foreach (TreeNode childnode in tvSadrzaj.Nodes[1].Nodes)
                    {
                        childnode.ForeColor = Color.Gray;
                    }
                }
            }
        }

        /// <summary>
        /// Dozvoljava korisniku samo prikaz informacija za Glasački glavni izbornik.
        /// </summary>
        private void OnemoguvacanjeSadrzajaGlIzbGlasac()
        {
            foreach (TreeNode node in tvSadrzaj.Nodes)
            {
                if (node == tvSadrzaj.Nodes[0])
                {
                    node.ForeColor = Color.Gray;

                    foreach (TreeNode childnode in tvSadrzaj.Nodes[0].Nodes)
                    {
                        childnode.ForeColor = Color.Gray;
                    }
                }
                if (node == tvSadrzaj.Nodes[2])
                {
                    node.ForeColor = Color.Gray;

                    foreach (TreeNode childnode in tvSadrzaj.Nodes[2].Nodes)
                    {
                        childnode.ForeColor = Color.Gray;
                    }
                }
            }
        }

        /// <summary>
        /// Prikriva sadržaj kontrola na FrmHelp koji ne treba biti vidljiv.
        /// </summary>
        private void SakrivanjeKontrola()
        {
            foreach (Control kontrola in pnlTeksts.Controls)
            {
                kontrola.Visible = false;
            }
        }

        /// <summary>
        /// Dozvoljava korisniku samo prikaz informacija za Login formu.
        /// </summary>
        private void OnemogucavanjeSadrzajaLogin()
        {
            foreach (TreeNode node in tvSadrzaj.Nodes)
            {
                if (node == tvSadrzaj.Nodes[1])
                {
                    node.ForeColor = Color.Gray;

                    foreach (TreeNode childnode in tvSadrzaj.Nodes[1].Nodes)
                    {
                        childnode.ForeColor = Color.Gray;
                    }
                }
                if (node == tvSadrzaj.Nodes[2])
                {
                    node.ForeColor = Color.Gray;

                    foreach (TreeNode childnode in tvSadrzaj.Nodes[2].Nodes)
                    {
                        childnode.ForeColor = Color.Gray;
                    }
                }
            }
        }

        /// <summary>
        /// Prikazuje određeni tekst za pomoć u aplikaciji.
        /// </summary>
        private void PrikazHelpPanela()
        {
            SakrivanjeKontrola();

            if (tvSadrzaj.SelectedNode == tvSadrzaj.Nodes[0].Nodes[0])
            {
                HelpLoginGlasacki.Visible = true;
                HelpLoginGlasacki.BringToFront();
            }
            else if(tvSadrzaj.SelectedNode == tvSadrzaj.Nodes[0].Nodes[1])
            {
                HelpLoginAdmin.Visible = true;
                HelpLoginAdmin.BringToFront();
            }
            else if(tvSadrzaj.SelectedNode == tvSadrzaj.Nodes[1].Nodes[0])
            {
                HelpGlIzb_Glasacki.Visible = true;
                HelpGlIzb_Glasacki.BringToFront();
            }
            else if(tvSadrzaj.SelectedNode == tvSadrzaj.Nodes[2])
            {
                HelpGlIzb_Admin.Visible = true;
                HelpGlIzb_Admin.BringToFront();
            }
            else if(tvSadrzaj.SelectedNode == tvSadrzaj.Nodes[2].Nodes[0])
            {
                HelpNovoGlasanje.Visible = true;
                HelpNovoGlasanje.BringToFront();
            }
            else if(tvSadrzaj.SelectedNode == tvSadrzaj.Nodes[2].Nodes[1])
            {
                HelpDodavanjeKandidata.Visible = true;
                HelpDodavanjeKandidata.BringToFront();
            }
            else if(tvSadrzaj.SelectedNode == tvSadrzaj.Nodes[2].Nodes[2])
            {
                HelpDodavanjeGlasaca.Visible = true;
                HelpDodavanjeGlasaca.BringToFront();
            }
        }

        private void tvSadrzaj_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PrikazHelpPanela();
        }

        private void tvSadrzaj_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if(Color.Gray == e.Node.ForeColor)
            {
                e.Cancel = true;
            }
        }

        // Ovdje se nalazi kod vezan uz rad UI kontrola FrmHelp.
        #region Rad UI kontrola

        private void pnlMenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlMenuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePosition;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            lblMinimize.Font = new Font(lblMinimize.Font, FontStyle.Bold);
            lblMinimize.BackColor = Color.LightBlue;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.Font = new Font(lblMinimize.Font, FontStyle.Regular);
            lblMinimize.BackColor = Color.Transparent;
        }

        #endregion

    }
}
