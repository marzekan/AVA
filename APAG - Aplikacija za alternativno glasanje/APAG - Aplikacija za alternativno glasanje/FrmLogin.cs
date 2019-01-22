using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using APAG___Aplikacija_za_alternativno_glasanje.CustomExceptions;
using APAG___Aplikacija_za_alternativno_glasanje.Forms;

namespace APAG___Aplikacija_za_alternativno_glasanje
{

    public partial class FrmLogin : Form
    {
        private Point mouseLocation;
        private bool neispravanUnos;

        public FrmLogin()
        {
            InitializeComponent();
            RadSPodacima.PrikazGlasanja(glasanjeBindingSource);
            odabirGlasanjaCBox.SelectedValue = 0;
            PostavljanjeLokacijeLoginPanela();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyDown += FrmLogin_KeyDown;
        }

        /// <summary>
        /// Na pritisak tipe F1 otvara se FrmHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                OtvoriHelpFormu();
            }
        }

        /// <summary>
        /// Provjerava ima li odabranih glasanja u ComboBoxu 'odabirGlasanjaCBox'.
        /// </summary>
        private void ProvjeraOdabiraGlasanja()
        {
            if(odabirGlasanjaCBox.SelectedValue == null)
            {
                throw new GlasanjeNijeOdabranoException(
                    "Glasanje nije odabrano.\n Odaberite glasanje na kojem želite sudjelovati!");
            }
        }

        /// <summary>
        /// Pozicionira panele koji sadrže kontrole za upis korisničkih podataka tako da budu jedan iza drugog.
        /// </summary>
        private void PostavljanjeLokacijeLoginPanela()
        {
            int brojac = 0;

            foreach (Control kontrola in Controls)
            {
                if (kontrola.GetType() == typeof(Panel) && kontrola.Visible == true)
                {
                    brojac++;
                    switch (brojac)
                    {
                        case 1:
                            kontrola.Location = new Point(297, 190);
                            break;
                        case 2:
                            kontrola.Location = new Point(297, 239);
                            break;
                        case 3:
                            kontrola.Location = new Point(297, 288);
                            break;
                        case 4:
                            kontrola.Location = new Point(297, 336);
                            break;
                        case 5:
                            kontrola.Location = new Point(297, 383);
                            break;
                        case 6:
                            kontrola.Location = new Point(297, 431);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Onemogućuje pisanje u TextBox-e koji nisu potrebni za prijavu na određeno Glasanje.
        /// </summary>
        /// <param name="idGlasanja"></param>
        private void PodaciZaPrijavu(int idGlasanja)
        {
            foreach (Control item in Controls)
            {
                if(item.GetType() == typeof(Panel))
                {
                    item.Visible = true;
                }
            }

            using (var db = new Entities2())
            {
                foreach (Glasanje glasanje in db.Glasanje)
                {
                    if (idGlasanja == glasanje.ID_glasanja)
                    {
                        if (glasanje.ImeOdabir == false)
                        {
                            pnlIme.Visible = false;
                        }
                        if (glasanje.PrezimeOdabir == false)
                        {
                            pnlPrezime.Visible = false;
                        }
                        if (glasanje.OIBOdabir == false)
                        {
                            pnlOIB.Visible = false;
                        }
                        if (glasanje.BrojOsobneIskazniceOdabir == false)
                        {
                            pnlBrojOsobne.Visible = false;
                        }
                        if (glasanje.KorisnickoImeOdabir == false)
                        {
                            pnlLozinka.Visible = false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Provjerava jesu li ispravni podaci s kojima se Glasac prijavio.
        /// </summary>
        /// <returns></returns>
        private bool ProvjeraGlasaca()
        {
            using (var db = new Entities2())
            {
                foreach (Glasac glasac in db.Glasac)
                {
                    if ((glasac.Korsinicko_ime == inputKorisnickoImeTxt.Text ||
                         glasac.Ime == inputImeTxt.Text ||
                         glasac.Prezime == inputPrezimeTxt.Text ||
                         glasac.OIB == inputOIBTxt.Text ||
                         glasac.Broj_osobne_iskaznice == inputBrojOsobneTxt.Text)
                         && glasac.Lozinka == inputLozinkaTxt.Text)
                    {
                        return true;
                    }
                }
                return false;
            }

        }

        /// <summary>
        /// Povjerava pripada li Glasac odabranom glasanju.
        /// </summary>
        /// <returns></returns>
        private bool AutorizacijaGlasac()
        {
            neispravanUnos = false;
            using (var db = new Entities2())
            {
                foreach (Glasac glasac in db.Glasac)
                {
                    try
                    {
                        ProvjeraOdabiraGlasanja();

                        if (glasac.ID_glasanja == (int)odabirGlasanjaCBox.SelectedValue)
                        {
                            if (ProvjeraGlasaca() == true)
                            {
                                return true;
                            }
                        }
                    }
                    catch (GlasanjeNijeOdabranoException ex)
                    {
                        neispravanUnos = true;
                        MessageBox.Show(ex.DodatnaPoruka, "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }

                }
            }
            return false;
        }

        /// <summary>
        /// Provjerava valjanost Administratorovih podataka za prijavu.
        /// </summary>
        /// <returns></returns>
        private bool AutentifikacijaAdmin()
        {
            using (var db = new Entities2())
            {
                foreach (Administrator administrator in db.Administrator)
                {
                    if (administrator.Korisnicko_ime == inputKorisnickoImeTxt.Text && 
                        administrator.Lozinka == inputLozinkaTxt.Text)
                    {
                        return true;
                    }
                 
                }

                return false;
            }
        }

        private void OcistiUnose()
        {
            inputImeTxt.Clear();
            inputPrezimeTxt.Clear();
            inputOIBTxt.Clear();
            inputLozinkaTxt.Clear();
            inputKorisnickoImeTxt.Clear();
            inputBrojOsobneTxt.Clear();
        }

        private void OtvoriHelpFormu()
        {
            FrmHelp frm = new FrmHelp(this);
            frm.Focus();
            frm.ShowDialog();
        }

        /// <summary>
        /// Metoda koja ne klik PotvrdaBtn-a otvara sljedeću formu (administratorsku ili glasačku ovisno o korisnikovom odabiru).
        /// </summary>
        private void OtvoriSljFormu()
        {
            if (AdminChkBox.Checked == true)
            {
                if(ProvjeraGlasaca() == true)
                {
                    MessageBox.Show("Niste ovlašteni za prijavu kao administrator!\n Odznačite kvačicu 'Administratorski način rada'",
                        "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (AutentifikacijaAdmin() == true)
                    {
                        FrmGlavniIzbornik_Admin frmGlavniIzbornikA = new FrmGlavniIzbornik_Admin(inputKorisnickoImeTxt.Text);
                        frmGlavniIzbornikA.Focus();
                        frmGlavniIzbornikA.Show();
                        frmGlavniIzbornikA.Location = Location;
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Krivo korisničko ime ili lozinka!\n Pokušajte ponovno.",
                                        "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        OcistiUnose();
                    }
                }
            }
            else
            {
                try
                {
                    if (AutorizacijaGlasac() == true)
                    {
                        FrmGlavniIzbornik_Glasacki frmGlavniIzbonikG = new FrmGlavniIzbornik_Glasacki(int.Parse(odabirGlasanjaCBox.SelectedValue.ToString()));
                        frmGlavniIzbonikG.Focus();
                        frmGlavniIzbonikG.Show();
                        frmGlavniIzbonikG.Location = Location;
                        Hide();
                    }
                    else
                    {
                        if (neispravanUnos == false)
                        {
                            MessageBox.Show("Kivi podaci za prijavu!\n Pokušajte ponovno.", "Upozorenje!",
                                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            OcistiUnose();
                        }

                        OcistiUnose();
                    }
                }
                catch (GlasanjeNijeOdabranoException ex)
                {
                    MessageBox.Show(ex.DodatnaPoruka, "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void PotvrdaBtn_Click(object sender, EventArgs e)
        {
            OtvoriSljFormu();
        }

        private void odabirGlasanjaCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(odabirGlasanjaCBox.SelectedValue != null)
            {
                int idG = (int)odabirGlasanjaCBox.SelectedValue;
                PodaciZaPrijavu(idG);
                PostavljanjeLokacijeLoginPanela();
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            OtvoriHelpFormu();
        }

        // Ovdje se nalazi kod vezan uz rad UI kontrola na frmLogin
        #region Rad UI kontrola

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda koja omogućuje pomicanje forme mišem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
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

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
