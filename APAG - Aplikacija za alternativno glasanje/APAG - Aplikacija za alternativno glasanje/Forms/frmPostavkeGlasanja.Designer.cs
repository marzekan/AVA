namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    partial class FrmPostavkeGlasanja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPostavkeGlasanja));
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.ucExitBtn1 = new APAG___Aplikacija_za_alternativno_glasanje.UserControls.UcExitBtn();
            this.lblLogo = new System.Windows.Forms.Label();
            this.ucLogo1 = new APAG___Aplikacija_za_alternativno_glasanje.ucLogo();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtNazivUnos = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dTPDatum = new System.Windows.Forms.DateTimePicker();
            this.txtPocetak = new System.Windows.Forms.TextBox();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.lblKraj = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.gbPrijavaPodaci = new System.Windows.Forms.GroupBox();
            this.chbBrojOsobne = new System.Windows.Forms.CheckBox();
            this.chbKorisnickoIme = new System.Windows.Forms.CheckBox();
            this.chbOIB = new System.Windows.Forms.CheckBox();
            this.chbPrezime = new System.Windows.Forms.CheckBox();
            this.chbIme = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnZavrsiGlasanje = new System.Windows.Forms.Button();
            this.pnlMenuBar.SuspendLayout();
            this.gbPrijavaPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.Controls.Add(this.lblHelp);
            this.pnlMenuBar.Controls.Add(this.lblNaslov);
            this.pnlMenuBar.Controls.Add(this.lblMinimize);
            this.pnlMenuBar.Controls.Add(this.ucExitBtn1);
            this.pnlMenuBar.Controls.Add(this.lblLogo);
            this.pnlMenuBar.Controls.Add(this.ucLogo1);
            this.pnlMenuBar.Controls.Add(this.label3);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(797, 92);
            this.pnlMenuBar.TabIndex = 0;
            this.pnlMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseDown);
            this.pnlMenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseMove);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHelp.Location = new System.Drawing.Point(715, 4);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(20, 24);
            this.lblHelp.TabIndex = 49;
            this.lblHelp.Text = "?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            this.lblHelp.MouseLeave += new System.EventHandler(this.lblHelp_MouseLeave);
            this.lblHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHelp_MouseMove);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("MS PMincho", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNaslov.Location = new System.Drawing.Point(328, 30);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(128, 33);
            this.lblNaslov.TabIndex = 48;
            this.lblNaslov.Text = "Glasanje";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinimize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMinimize.Location = new System.Drawing.Point(741, 4);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 24);
            this.lblMinimize.TabIndex = 46;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMinimize_MouseMove);
            // 
            // ucExitBtn1
            // 
            this.ucExitBtn1.BackColor = System.Drawing.Color.Transparent;
            this.ucExitBtn1.Location = new System.Drawing.Point(762, 0);
            this.ucExitBtn1.Name = "ucExitBtn1";
            this.ucExitBtn1.Size = new System.Drawing.Size(35, 35);
            this.ucExitBtn1.TabIndex = 45;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("MS PMincho", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblLogo.Location = new System.Drawing.Point(68, 10);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(98, 33);
            this.lblLogo.TabIndex = 44;
            this.lblLogo.Text = "APAG";
            // 
            // ucLogo1
            // 
            this.ucLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLogo1.BackgroundImage")));
            this.ucLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLogo1.Location = new System.Drawing.Point(3, 4);
            this.ucLogo1.Name = "ucLogo1";
            this.ucLogo1.Size = new System.Drawing.Size(71, 62);
            this.ucLogo1.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "____________________";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNatrag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.Color.Black;
            this.btnNatrag.Location = new System.Drawing.Point(675, 465);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(110, 39);
            this.btnNatrag.TabIndex = 41;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtNazivUnos
            // 
            this.txtNazivUnos.Location = new System.Drawing.Point(44, 148);
            this.txtNazivUnos.Name = "txtNazivUnos";
            this.txtNazivUnos.Size = new System.Drawing.Size(203, 20);
            this.txtNazivUnos.TabIndex = 42;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(41, 129);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(42, 16);
            this.lblNaziv.TabIndex = 43;
            this.lblNaziv.Text = "Naziv";
            // 
            // dTPDatum
            // 
            this.dTPDatum.Location = new System.Drawing.Point(44, 330);
            this.dTPDatum.Name = "dTPDatum";
            this.dTPDatum.Size = new System.Drawing.Size(203, 20);
            this.dTPDatum.TabIndex = 44;
            // 
            // txtPocetak
            // 
            this.txtPocetak.Location = new System.Drawing.Point(103, 212);
            this.txtPocetak.Name = "txtPocetak";
            this.txtPocetak.Size = new System.Drawing.Size(144, 20);
            this.txtPocetak.TabIndex = 45;
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(103, 250);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(144, 20);
            this.txtKraj.TabIndex = 46;
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPocetak.Location = new System.Drawing.Point(41, 212);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(61, 16);
            this.lblPocetak.TabIndex = 47;
            this.lblPocetak.Text = "Početak:";
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKraj.Location = new System.Drawing.Point(63, 251);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(34, 16);
            this.lblKraj.TabIndex = 48;
            this.lblKraj.Text = "Kraj:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(41, 311);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(50, 16);
            this.lblDatum.TabIndex = 49;
            this.lblDatum.Text = "Datum:";
            // 
            // gbPrijavaPodaci
            // 
            this.gbPrijavaPodaci.Controls.Add(this.chbBrojOsobne);
            this.gbPrijavaPodaci.Controls.Add(this.chbKorisnickoIme);
            this.gbPrijavaPodaci.Controls.Add(this.chbOIB);
            this.gbPrijavaPodaci.Controls.Add(this.chbPrezime);
            this.gbPrijavaPodaci.Controls.Add(this.chbIme);
            this.gbPrijavaPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrijavaPodaci.Location = new System.Drawing.Point(437, 129);
            this.gbPrijavaPodaci.Name = "gbPrijavaPodaci";
            this.gbPrijavaPodaci.Size = new System.Drawing.Size(324, 221);
            this.gbPrijavaPodaci.TabIndex = 50;
            this.gbPrijavaPodaci.TabStop = false;
            this.gbPrijavaPodaci.Text = "Podaci za prijavu";
            // 
            // chbBrojOsobne
            // 
            this.chbBrojOsobne.AutoSize = true;
            this.chbBrojOsobne.Location = new System.Drawing.Point(21, 165);
            this.chbBrojOsobne.Name = "chbBrojOsobne";
            this.chbBrojOsobne.Size = new System.Drawing.Size(100, 20);
            this.chbBrojOsobne.TabIndex = 5;
            this.chbBrojOsobne.Text = "Broj osobne";
            this.chbBrojOsobne.UseVisualStyleBackColor = true;
            // 
            // chbKorisnickoIme
            // 
            this.chbKorisnickoIme.AutoSize = true;
            this.chbKorisnickoIme.Location = new System.Drawing.Point(182, 46);
            this.chbKorisnickoIme.Name = "chbKorisnickoIme";
            this.chbKorisnickoIme.Size = new System.Drawing.Size(114, 20);
            this.chbKorisnickoIme.TabIndex = 3;
            this.chbKorisnickoIme.Text = "Korisničko ime";
            this.chbKorisnickoIme.UseVisualStyleBackColor = true;
            // 
            // chbOIB
            // 
            this.chbOIB.AutoSize = true;
            this.chbOIB.Location = new System.Drawing.Point(182, 102);
            this.chbOIB.Name = "chbOIB";
            this.chbOIB.Size = new System.Drawing.Size(49, 20);
            this.chbOIB.TabIndex = 2;
            this.chbOIB.Text = "OIB";
            this.chbOIB.UseVisualStyleBackColor = true;
            // 
            // chbPrezime
            // 
            this.chbPrezime.AutoSize = true;
            this.chbPrezime.Location = new System.Drawing.Point(21, 102);
            this.chbPrezime.Name = "chbPrezime";
            this.chbPrezime.Size = new System.Drawing.Size(76, 20);
            this.chbPrezime.TabIndex = 1;
            this.chbPrezime.Text = "Prezime";
            this.chbPrezime.UseVisualStyleBackColor = true;
            // 
            // chbIme
            // 
            this.chbIme.AutoSize = true;
            this.chbIme.Location = new System.Drawing.Point(21, 46);
            this.chbIme.Name = "chbIme";
            this.chbIme.Size = new System.Drawing.Size(49, 20);
            this.chbIme.TabIndex = 0;
            this.chbIme.Text = "Ime";
            this.chbIme.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSpremi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(321, 438);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(135, 56);
            this.btnSpremi.TabIndex = 51;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrisanje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisanje.ForeColor = System.Drawing.Color.Black;
            this.btnBrisanje.Location = new System.Drawing.Point(633, 356);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(128, 47);
            this.btnBrisanje.TabIndex = 52;
            this.btnBrisanje.Text = "Obriši glasanje";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            // 
            // btnZavrsiGlasanje
            // 
            this.btnZavrsiGlasanje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZavrsiGlasanje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZavrsiGlasanje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZavrsiGlasanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZavrsiGlasanje.ForeColor = System.Drawing.Color.Black;
            this.btnZavrsiGlasanje.Location = new System.Drawing.Point(286, 129);
            this.btnZavrsiGlasanje.Name = "btnZavrsiGlasanje";
            this.btnZavrsiGlasanje.Size = new System.Drawing.Size(127, 47);
            this.btnZavrsiGlasanje.TabIndex = 53;
            this.btnZavrsiGlasanje.Text = "Završi glasanje";
            this.btnZavrsiGlasanje.UseVisualStyleBackColor = false;
            // 
            // FrmPostavkeGlasanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 516);
            this.Controls.Add(this.btnZavrsiGlasanje);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.gbPrijavaPodaci);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblKraj);
            this.Controls.Add(this.lblPocetak);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.txtPocetak);
            this.Controls.Add(this.dTPDatum);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivUnos);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPostavkeGlasanja";
            this.Text = "frmPostavkeGlasanja";
            this.Load += new System.EventHandler(this.FrmPostavkeGlasanja_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.gbPrijavaPodaci.ResumeLayout(false);
            this.gbPrijavaPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Label lblLogo;
        private ucLogo ucLogo1;
        private System.Windows.Forms.Label label3;
        private UserControls.UcExitBtn ucExitBtn1;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNazivUnos;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DateTimePicker dTPDatum;
        private System.Windows.Forms.TextBox txtPocetak;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.GroupBox gbPrijavaPodaci;
        private System.Windows.Forms.CheckBox chbBrojOsobne;
        private System.Windows.Forms.CheckBox chbKorisnickoIme;
        private System.Windows.Forms.CheckBox chbOIB;
        private System.Windows.Forms.CheckBox chbPrezime;
        private System.Windows.Forms.CheckBox chbIme;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnZavrsiGlasanje;
        private System.Windows.Forms.Label lblHelp;
    }
}