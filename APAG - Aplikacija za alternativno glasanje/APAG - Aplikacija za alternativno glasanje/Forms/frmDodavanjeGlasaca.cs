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
    public partial class FrmDodavanjeGlasaca : Form
    {
        private Point mouseLocation;

        public FrmDodavanjeGlasaca()
        {
            InitializeComponent();
            RadSPodacima.PrikazGlasaca(glasacBindingSource);
            RadSPodacima.PrikazGlasanja(glasanjeBindingSource);     
        }

        private void frmDodavanjeGlasaca_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyDown += FrmDodavanjeGlasaca_KeyDown;
        }

        /// <summary>
        /// Na pritisak tipke F1 otvara Help prozor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDodavanjeGlasaca_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                OtvoriHelpFormu();
            }
        }

        /// <summary>
        /// Pronalazi Glasaca čiji podaci odgovaraju traženom stringu iz txtSearchBar-a.
        /// </summary>
        private void PretragaGlasaca()
        {
            BindingList<Glasac> listaGlasaca = new BindingList<Glasac>();
            using (var db = new Entities2())
            {
                foreach (Glasac glasac in db.Glasac)
                {
                    if(glasac.OIB != null)
                    {
                        if (glasac.OIB.Contains(txtSearchBar.Text))
                        {
                            listaGlasaca.Add(glasac);
                        }
                    }
                    else if(glasac.Broj_osobne_iskaznice != null)
                    {
                        if (glasac.Broj_osobne_iskaznice.Contains(txtSearchBar.Text))
                        {
                            listaGlasaca.Add(glasac);
                        }
                    }
                    else if(glasac.Ime != null)
                    {
                        if (glasac.Ime.Contains(txtSearchBar.Text))
                        {
                            listaGlasaca.Add(glasac);
                        }
                    }
                    else if(glasac.Prezime != null)
                    {
                        if (glasac.Prezime.Contains(txtSearchBar.Text))
                        {
                            listaGlasaca.Add(glasac);
                        }
                    }
                    else if(glasac.Korsinicko_ime != null)
                    {
                        if (glasac.Korsinicko_ime.Contains(txtSearchBar.Text))
                        {
                            listaGlasaca.Add(glasac);
                        }
                    }
                    else if(glasac.Lozinka != null)
                    {
                        if (glasac.Lozinka.Contains(txtSearchBar.Text))
                        {
                            listaGlasaca.Add(glasac);
                        }
                    }
                    else if(glasac.ID_glasanja.ToString().Contains(txtSearchBar.Text))
                    {
                        listaGlasaca.Add(glasac);
                    }
                    else if (glasac.ID_glasac.ToString().Contains(txtSearchBar.Text))
                    {
                        listaGlasaca.Add(glasac);
                    }
                }
            }

            dgvGlasaci.DataSource = listaGlasaca;
        }

        private void Natrag()
        {
            Close();
        }

        /// <summary>
        /// Spremanje glasača u bazu podataka.
        /// </summary>
        private void SpremiUBazu()
        {
            using (var db = new Entities2())
            {
            
                    Glasac glasac = new Glasac
                    {
                        Ime = txtImeUnos.Text,
                        Prezime = txtPrezimeUnos.Text,
                        Korsinicko_ime = txtKorisnikoImeUnos.Text,
                        OIB = txtOIBUnos.Text,
                        Lozinka = txtLozinkaUnos.Text,
                        Broj_osobne_iskaznice = txtBrojOsobneUnos.Text,
                        ID_glasanja = int.Parse(cbGlasanja.SelectedValue.ToString()),
                        Tip_korisnikaID_tipa2 = 2
                    };
                    db.Glasac.Add(glasac);
                    db.SaveChanges();
                
            }
        }

        private void IzmjeniGlasaca()
        {
            Glasac glasacZaIzmjenu = glasacBindingSource.Current as Glasac;
            using (var db = new Entities2())
            { 
                if (glasacZaIzmjenu != null)
                {
                    txtImeUnos.Text = glasacZaIzmjenu.Ime;
                    txtPrezimeUnos.Text = glasacZaIzmjenu.Prezime;
                    txtKorisnikoImeUnos.Text = glasacZaIzmjenu.Korsinicko_ime;
                    txtOIBUnos.Text = glasacZaIzmjenu.OIB;
                    txtLozinkaUnos.Text = glasacZaIzmjenu.Lozinka;
                    txtBrojOsobneUnos.Text = glasacZaIzmjenu.Broj_osobne_iskaznice;
                    glasacZaIzmjenu.ID_glasanja = int.Parse(cbGlasanja.SelectedValue.ToString());
                    glasacZaIzmjenu.Tip_korisnikaID_tipa2 = 2;
                }
            }
        }

        private void SpremiIzmijenjenogGlasaca()
        {
            Glasac glasacZaIzmjenu = glasacBindingSource.Current as Glasac;
            using (var db = new Entities2())
            {
                if (glasacZaIzmjenu != null)
                {
                    db.Glasac.Attach(glasacZaIzmjenu);
                    txtImeUnos.Text = glasacZaIzmjenu.Ime;
                    txtPrezimeUnos.Text = glasacZaIzmjenu.Prezime;
                    txtKorisnikoImeUnos.Text = glasacZaIzmjenu.Korsinicko_ime;
                    txtOIBUnos.Text = glasacZaIzmjenu.OIB;
                    txtLozinkaUnos.Text = glasacZaIzmjenu.Lozinka;
                    txtBrojOsobneUnos.Text = glasacZaIzmjenu.Broj_osobne_iskaznice;
                    glasacZaIzmjenu.ID_glasanja = int.Parse(cbGlasanja.SelectedValue.ToString());
                    glasacZaIzmjenu.Tip_korisnikaID_tipa2 = 2;
                    //db.Glasac.Remove(glasacZaIzmjenu);
                    //db.Glasac.Add(glasacZaIzmjenu);
                    db.SaveChanges();     
                }
            }
        }

        /// <summary>
        /// Brisanje glasača iz baze podataka.
        /// </summary>
        private void ObrisiGlasaca()
        {
            Glasac selektiraniGlasac = glasacBindingSource.Current as Glasac;
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
            }
        }

        private void OtvoriHelpFormu()
        {
            FrmHelp frmHelp = new FrmHelp(this);
            frmHelp.Focus();
            frmHelp.ShowDialog();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            OtvoriHelpFormu();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Natrag();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li spremiti novog glasača?", "Jeste li sigurni?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SpremiUBazu();
                RadSPodacima.PrikazGlasaca(glasacBindingSource);
            }
            //int Izmjeni = int.Parse(dgvGlasaci.CurrentRow.Cells[0].Value.ToString());

            /*if (Izmjeni == 0)
                if(MessageBox.Show("Želite li spremiti novog glasača?", "Jeste li sigurni?",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                //IzmjeniGlasaca();
                }*/

            //if (Izmjeni !=0)
            /*{
                if (MessageBox.Show("Želite li izmjeniti glasača?", "Jeste li sigurni?",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SpremiIzmijenjenogGlasaca();
                }
            }*/
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            PretragaGlasaca();
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Clear();
        }

        private void FrmDodavanjeGlasaca_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "Search...";
            dgvGlasaci.DataSource = glasacBindingSource;
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati glasača?", "Jeste li sigurni?",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ObrisiGlasaca();
            }
            RadSPodacima.PrikazGlasaca(glasacBindingSource);
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            //IzmjeniGlasaca();
        }

        // Sadrzi kod kontrola na frmDodavanjeGlasaca.
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
    }
}
