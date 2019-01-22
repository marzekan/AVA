using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    public partial class FrmGlavniIzbornik_Admin : Form
    {
        private Point mouseLocation;

        private BindingList<Glasanje> listaGlasanja = null;
        

        public FrmGlavniIzbornik_Admin(string ime)
        {
            InitializeComponent();
            lblKIme.Text = ime;
            PrikaziGlasanja();
        }

        private void FrmGlavniIzbornik_Admin_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyDown += FrmGlavniIzbornik_Admin_KeyDown;
        }

        /// <summary>
        /// Na pritisak tipke F1 otvara Help prozor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGlavniIzbornik_Admin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                OtvoriHelpFormu();
            }
        }

        /// <summary>
        /// Pronalazi Glasanja čiji podaci odgovaraju traženom stringu iz txtSreachBar-a.
        /// </summary>
        private void PrikaziGlasanja()
        {
            int AdminID = 0;
            listaGlasanja = new BindingList<Glasanje>();

            using (var db = new Entities2())
            {
                foreach (Administrator admin in db.Administrator)
                {
                    if(admin.Korisnicko_ime == lblKIme.Text)
                    {
                        AdminID = admin.ID_administrator;
                    }
                }

                foreach (Glasanje glasanje in db.Glasanje)
                {
                    if(glasanje.AdministratorID_administrator == AdminID)
                    {
                        listaGlasanja.Add(glasanje);
                    }
                }
            }
            dgvGlasanja.DataSource = listaGlasanja;
        }

        private void PrikaziGlasace()
        {
            BindingList<Glasac> listaGlasaca = new BindingList<Glasac>();
            using (var db = new Entities2())
            {
                foreach (Glasac glasac in db.Glasac)
                {
                    if (glasac.ID_glasanja == int.Parse(dgvGlasanja.CurrentRow.Cells[0].Value.ToString()))
                    {
                        listaGlasaca.Add(glasac);
                    }
                }
            }
            dgvGlasaci.DataSource = listaGlasaca;
        }

        private void PrikaziKandidate()
        {
            BindingList<Kandidat> listaKandidata = new BindingList<Kandidat>();
            using (var db = new Entities2())
            {
                foreach (Kandidat kandidat in db.Kandidat)
                {
                    if (kandidat.GlasanjeID_glasanja == int.Parse(dgvGlasanja.CurrentRow.Cells[0].Value.ToString()))
                    {
                        listaKandidata.Add(kandidat);
                    }
                }
            }
            dgvKandidata.DataSource = listaKandidata;
        }
        
        /// <summary>
        /// Pronalazi Glasanja čiji podaci odgovaraju traženom stringu iz txtSreachBar-a.
        /// </summary>
        private void PretragaGlasanja()
        {
            BindingList<Glasanje> listaGlasanjaPretraga = new BindingList<Glasanje>();
            foreach (Glasanje glasanje in listaGlasanja)
            {
                if (glasanje.ID_glasanja.ToString().Contains(txtSearchBar.Text) ||
                   glasanje.Naziv.Contains(txtSearchBar.Text) ||
                   glasanje.VrijemePocetka.ToString().Contains(txtSearchBar.Text) ||
                   glasanje.VrijemeZavrsetka.ToString().Contains(txtSearchBar.Text) ||
                   glasanje.Datum.ToString().Contains(txtSearchBar.Text))
                {
                    listaGlasanjaPretraga.Add(glasanje);
                }
            }
            dgvGlasanja.DataSource = listaGlasanjaPretraga;
        }

        /// <summary>
        /// Metoda koja otvara formu za dodavanje Kanidata.
        /// </summary>
        private void OtvoriFrmDodavKandidata()
        {
            FrmDodavanjeKandidata dodavanjeKandidata = new FrmDodavanjeKandidata();
            Visible = false;
            dodavanjeKandidata.Focus();
            dodavanjeKandidata.ShowDialog();
            Visible = true;
        }

        /// <summary>
        /// Metoda koja otvara formu za dodavanje Glasača.
        /// </summary>
        private void OtvoriFrmDodavGlasaca()
        {
            FrmDodavanjeGlasaca dodavanjeGlasaca = new FrmDodavanjeGlasaca();
            Visible = false;
            dodavanjeGlasaca.Focus();
            dodavanjeGlasaca.ShowDialog();
            Visible = true;
        }

        /// <summary>
        /// Metoda koja otvara formu za podešavanje postavki Glasanja.
        /// </summary>
        private void OtvoriFrmPostavkeGlasanja()
        {
            FrmPostavkeGlasanja postavkeGLasanja = new FrmPostavkeGlasanja();
            Visible = false;
            postavkeGLasanja.Focus();
            postavkeGLasanja.ShowDialog();
            Visible = true;
        }

        private void OtvoriHelpFormu()
        {
            FrmHelp frmHelp = new FrmHelp(this);
            frmHelp.Focus();
            frmHelp.ShowDialog();
        }

        private void Odjava()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Close();
        }

        private void btnKandidati_Click(object sender, EventArgs e)
        {
            OtvoriFrmDodavKandidata();
        }

        private void btnGlasaci_Click(object sender, EventArgs e)
        {
            OtvoriFrmDodavGlasaca();
        }

        private void btnNovoGlasanje_Click(object sender, EventArgs e)
        {
            OtvoriFrmPostavkeGlasanja();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Odjava();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            PretragaGlasanja();
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Clear();
        }

        private void FrmGlavniIzbornik_Admin_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "Search...";
            dgvGlasanja.DataSource = listaGlasanja;

        }

        // Ovdje se nalazi kod vezan uz rad UI kontrola na frmGlavniIzbornik_Admin
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

        private void dgvGlasanja_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGlasanja.SelectedRows != null)
            {
                PrikazivanjePodatakaOGlasanju();
                PrikaziGlasace();
                PrikaziKandidate();
            }
        }
       
        /// <summary>
        /// Prikaz podataka o glasanju na glavnoj formi administratorskog sučelja.
        /// </summary>
        private void PrikazivanjePodatakaOGlasanju()
        {
            foreach (Control kontrola in gbPostavke.Controls)
            {
                if(kontrola.GetType() == typeof(Label))
                {
                    kontrola.Enabled = true;
                }
            }
             string Datum = dgvGlasanja.CurrentRow.Cells[3].Value.ToString();
             string ispis = "";
             for (int i = 0; i < 11; i++)
             {
                 ispis += Datum[i];
             }
             lblDatumPrikaz.Text = ispis;
            

            lblPocetakPrikaz.Text = dgvGlasanja.CurrentRow.Cells[11].Value.ToString();
            lblZavrsetakPrikaz.Text = dgvGlasanja.CurrentRow.Cells[12].Value.ToString();

            if (dgvGlasanja.CurrentRow.Cells[5].Value.ToString() == "False")
            {
                lblOIB.Enabled = false;
            }
            if (dgvGlasanja.CurrentRow.Cells[4].Value.ToString() == "False")
            {
                lblKorisnickoIme.Enabled = false;
            }
            if (dgvGlasanja.CurrentRow.Cells[6].Value.ToString() == "False")
            {
                lblBrojOsobne.Enabled = false;
            }
            if (dgvGlasanja.CurrentRow.Cells[7].Value.ToString() == "False")
            {
                lblIme2.Enabled = false;
            }
            if (dgvGlasanja.CurrentRow.Cells[8].Value.ToString() == "False")
            {
                lblPrezime2.Enabled = false;
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            OtvoriHelpFormu();
        }
    }
}
