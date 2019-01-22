using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    public partial class FrmPostavkeGlasanja : Form
    {
        private Point mouseLocation;

        public FrmPostavkeGlasanja()
        {
            InitializeComponent();
        }

        private void FrmPostavkeGlasanja_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyDown += FrmPostavkeGlasanja_KeyDown;
        }


        /// <summary>
        /// Na pritisak tipke F1 otvara Help prozor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPostavkeGlasanja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                OtvoriHelpFormu();
            }
        }

        private void OtvoriHelpFormu()
        {
            FrmHelp frmHelp = new FrmHelp(this);
            frmHelp.Focus();
            frmHelp.ShowDialog();
        }

        private void Natrag()
        {
            Close();
        }


        private void ZavrsiGlasanje()
        {

        }

        /// <summary>
        /// Spremanje promjena u bazu podataka.
        /// </summary>
        private void SpremiGlasanje()
        {

            using (var db = new Entities2())
            {

                Glasanje glasanje = new Glasanje
                {
                    Naziv = txtNazivUnos.Text,
                    VrijemePocetka = TimeSpan.Parse(txtPocetak.Text),
                    VrijemeZavrsetka = TimeSpan.Parse(txtKraj.Text),
                    Datum = DateTime.Parse(dTPDatum.Text),
                    ImeOdabir = (chbIme.Checked==true) ? true : false,
                    OIBOdabir = (chbOIB.Checked==true) ? true : false,
                    PrezimeOdabir = (chbPrezime.Checked==true) ? true :false,
                    BrojOsobneIskazniceOdabir =(chbBrojOsobne.Checked == true) ? true : false,
                    KorisnickoImeOdabir = (chbKorisnickoIme.Checked == true) ? true : false,
                    AdministratorID_administrator = 1

                };
                db.Glasanje.Add(glasanje);
                db.SaveChanges();

            }
        }

        /// <summary>
        /// Brisanje glasanja iz baze podataka.
        /// </summary>
        private void Obrisi()
        {
            
           /* Glasanje selektiranoGlasanje = 
            if (selektiraniGlasac != null)
            {
                using (var db = new Entities2())
                {
                    db.Glasac.Attach(selektiraniGlasac);
                    {
                        db.Glasac.Remove(selektiraniGlasac);
                        db.SaveChanges();
                    }
                }
            }*/
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Natrag();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            OtvoriHelpFormu();
        }

        // Kod za rad kontroli na formi frmPostavkeGlasanja.
        #region

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

        private void lblHelp_MouseMove(object sender, MouseEventArgs e)
        {
            lblHelp.Font = new Font(lblHelp.Font, FontStyle.Bold);
            lblHelp.BackColor = Color.LightBlue;
        }

        private void lblHelp_MouseLeave(object sender, EventArgs e)
        {
            lblHelp.Font = new Font(lblHelp.Font, FontStyle.Regular);
            lblHelp.BackColor = Color.Transparent;
        }

        #endregion

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li pohraniti napravljene promjene?", "Jeste li sigurni?",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SpremiGlasanje();
            }
        }
    }
}
