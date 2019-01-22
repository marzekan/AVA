using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogikaOdabiraPobjednika;

namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    public partial class FrmGlavniIzbornik_Glasacki : Form
    {
        private Point mouseLocation;
        private int idGlasanja;

        public FrmGlavniIzbornik_Glasacki(int IdGlasanja)
        {
            InitializeComponent();
            idGlasanja = IdGlasanja;
            tajmerPreostaloVrijeme.Start();
            PrikazVodstva_TestniPodaci();
        }

        private void FrmGlavniIzbornik_Glasacki_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyDown += FrmGlavniIzbornik_Glasacki_KeyDown;
        }

        // Kreiranje testnih podataka.
        #region Testni podaci
        List<string> listaOdabira1 = new List<string>();
        List<string> listaOdabira2 = new List<string>();
        List<string> listaOdabira3 = new List<string>();
        private void PrikazVodstva_TestniPodaci()
        {
            List<string> listaKandidata = new List<string>();

            string kandidat1 = "1";
            string kandidat2 = "2";
            string kandidat3 = "3";

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                int a, b, c;

                a = rand.Next(1, 4);
                
                if(a == 1)
                {
                    listaOdabira1.Add(kandidat1);
                }
                else if(a == 2)
                {
                    listaOdabira1.Add(kandidat2);
                }
                else if(a == 3)
                {
                    listaOdabira1.Add(kandidat3);
                }

                do
                {
                    b = rand.Next(1, 4);
                } while (a == b);

                if (b == 1)
                {
                    listaOdabira2.Add(kandidat1);
                }
                else if (b == 2)
                {
                    listaOdabira2.Add(kandidat2);
                }
                else if (b == 3)
                {
                    listaOdabira2.Add(kandidat3);
                }

                do
                {
                    c = rand.Next(1,4);

                } while (c == b || c == a);

                if (c == 1)
                {
                    listaOdabira3.Add(kandidat1);
                }
                else if (c == 2)
                {
                    listaOdabira3.Add(kandidat2);
                }
                else if (c == 3)
                {
                    listaOdabira3.Add(kandidat3);
                }
            }
            string pobjednik = Voting.OdabirPobjednika(listaOdabira1, listaOdabira2, listaOdabira3);

            if (pobjednik == "1")
            {
                pobjednik = "Marko";
            }
            else if (pobjednik == "2")
            {
                pobjednik = "Filip";
            }
            else if (pobjednik == "3")
            {
                pobjednik = "Benjamin";
            }

            lblTrenutnoVrijeme.Text = DateTime.Now.ToString("HH:mm");
            lblImeKandidata.Text = pobjednik;
        }
        #endregion

        /// <summary>
        /// Na pritisak tipke F1 otvara se Help prozor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGlavniIzbornik_Glasacki_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                OtvoriHelpFormu();
            }
        }

        /// <summary>
        /// Prikazuje preostalo vrijeme za glasanje na FrmGlavniIzbornik_Glasacki.
        /// </summary>
        private void PrikazPreostalogVremena()
        {
            using (var db = new Entities2())
            {
                foreach (Glasanje glasanje in db.Glasanje)
                {
                    if(glasanje.ID_glasanja == idGlasanja)
                    {
                        DateTime trenutnoVrijeme = DateTime.Now;
                        DateTime vrijemeZavrsetka = DateTime.Parse(glasanje.VrijemeZavrsetka.ToString());
                        TimeSpan preostaloVrijeme = vrijemeZavrsetka - trenutnoVrijeme;
                        PreostaloVrijemelbl.Text = preostaloVrijeme.ToString(@"hh\:mm\:ss");
                    }
                }
            }
        }

        /// <summary>
        /// Metoda koja otvara formu na kojoj se može glasovati.
        /// </summary>
        private void OtvoriFrmGlasanje()
        {

        }

        /// <summary>
        /// Metoda koja otvara formu na kojoj se mogu vidjeti statistički podaci.
        /// </summary>
        private void OtvoriFrmStatistike()
        {

        }

        private void OtvoriHelpFormu()
        {
            FrmHelp frmHelp = new FrmHelp(this);
            frmHelp.ShowDialog();
            frmHelp.Focus();
        }

        private void Odjava()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Close();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Odjava();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            OtvoriHelpFormu();
        }

        private void tajmerPreostaloVrijeme_Tick(object sender, EventArgs e)
        {
            PrikazPreostalogVremena();
        }

        // Ovdje se nalazi kod vezan uz rad UI kontrola na frmGlavniIzbornik_Glasacki
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
            this.WindowState = FormWindowState.Minimized;
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

        private void btnGlasaj_MouseMove(object sender, MouseEventArgs e)
        {
            btnGlasaj.BackColor = Color.DeepSkyBlue;
        }

        private void btnGlasaj_MouseLeave(object sender, EventArgs e)
        {
            btnGlasaj.BackColor = Color.LightBlue;
        }

        private void btnStatistike_MouseMove(object sender, MouseEventArgs e)
        {
            btnStatistike.BackColor = Color.DeepSkyBlue;
        }

        private void btnStatistike_MouseLeave(object sender, EventArgs e)
        {
            btnStatistike.BackColor = Color.LightBlue;
        }


        #endregion
    }
}
