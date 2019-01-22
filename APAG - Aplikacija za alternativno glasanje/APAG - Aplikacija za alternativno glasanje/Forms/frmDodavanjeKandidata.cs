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
    public partial class FrmDodavanjeKandidata : Form
    {
        private Point mouseLocation;

        public FrmDodavanjeKandidata()
        {
            InitializeComponent();
            RadSPodacima.PrikazKandidata(kandidatBindingSource);
            RadSPodacima.PrikazGlasanja(glasanjeBindingSource);
        }

        private void frmDodavanjeKandidata_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyDown += FrmDodavanjeKandidata_KeyDown;
        }


        /// <summary>
        /// Na pritisak tipke F1 otvara Help prozor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDodavanjeKandidata_KeyDown(object sender, KeyEventArgs e)
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

        /// <summary>
        /// Omogućuje pretragu po unesenim vrijednostima u textboxu.
        /// </summary>
        private void PretragaKandidata()
        {
            BindingList<Kandidat> listaKandidata = new BindingList<Kandidat>();
            using (var db = new Entities2())
            {
                foreach (Kandidat kandidat in db.Kandidat)
                {
                    if
                      (kandidat.ID_kandidata.ToString().Contains(txtSearchBar.Text) ||
                       kandidat.Naziv.Contains(txtSearchBar.Text) ||
                       kandidat.Ime.Contains(txtSearchBar.Text) ||
                       kandidat.Prezime.Contains(txtSearchBar.Text) ||
                       kandidat.DodatnaPoruka.Contains(txtSearchBar.Text))
                    {
                        listaKandidata.Add(kandidat);
                    }
                }
            }
            dgvKandidati.DataSource = listaKandidata;
        }


        /// <summary>
        /// Služi za dohvaćanje i postavljanje slike Kandidata.
        /// </summary>
        private void DodavanjeSlike()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                Image image = Image.FromFile(path);
                pbSlikaKandidata.Image = image;
            }
        }


        /// <summary>
        /// Pretvara sliku u polje bajtova.
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public byte[] SlikaUBajtove(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        /// <summary>
        /// Sprema napravljene promjene u bazu podataka.
        /// </summary>
        private void SpremiUBazu()
        {
            // NE MOZE SE DODATI KANDIDATA AKO JE GLASANJE U TIJEKU
            using (var db = new Entities2())
            {
                Kandidat kandidat = new Kandidat
                {
                    Ime = txtImeUnos.Text,
                    Prezime = txtPrezimeUnos.Text,
                    DodatnaPoruka = txtPorukaUnos.Text,
                    Naziv = txtNazivUnos.Text,
                    GlasanjeID_glasanja = int.Parse(cbGlasanja.SelectedValue.ToString()),
                    Slika = SlikaUBajtove(pbSlikaKandidata.Image)
                };
                db.Kandidat.Add(kandidat);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Briše odabranog kandidata iz baze podataka.
        /// </summary>
        private void ObrisiKandidata()
        {
            Kandidat selektiraniKandidat = kandidatBindingSource.Current as Kandidat;
            if (selektiraniKandidat != null)
            {
                using (var db = new Entities2())
                {
                    db.Kandidat.Attach(selektiraniKandidat);
                    {
                        db.Kandidat.Remove(selektiraniKandidat);
                        db.SaveChanges();
                    }
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li pohraniti napravljene promjene?", "Jeste li sigurni?",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SpremiUBazu();
                // Spremit nove kandidate ili promjene na postojecim kandidatima
            }
            RadSPodacima.PrikazKandidata(kandidatBindingSource);
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati kandidata?", "Jeste li sigurni?",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ObrisiKandidata();
            }
            RadSPodacima.PrikazKandidata(kandidatBindingSource);
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            OtvoriHelpFormu();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            PretragaKandidata();
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Clear();
        }

        private void FrmDodavanjeKandidata_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "Search...";
            dgvKandidati.DataSource = kandidatBindingSource;
        }

        // Kod za rad kontrola na frmDodavanjeKandidata.
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
                    WindowState = FormWindowState.Minimized;
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

                private void btnNatrag_Click(object sender, EventArgs e)
                {
                    Natrag();
                }

                private void lblSlika_Click(object sender, EventArgs e)
                {
                    DodavanjeSlike();
                }

                private void lblSlika_MouseDown(object sender, MouseEventArgs e)
                {
                    lblSlika.ForeColor = Color.DeepSkyBlue;
                }

                private void lblSlika_MouseMove(object sender, MouseEventArgs e)
                {
                    lblSlika.ForeColor = Color.DeepSkyBlue;
                }

                private void lblSlika_MouseLeave(object sender, EventArgs e)
                {
                    lblSlika.ForeColor = Color.LightSkyBlue;
                }





        #endregion


    }
}
