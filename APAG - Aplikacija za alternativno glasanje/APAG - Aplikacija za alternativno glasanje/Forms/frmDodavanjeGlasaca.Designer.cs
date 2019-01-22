namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    partial class FrmDodavanjeGlasaca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodavanjeGlasaca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.ucExitBtn1 = new APAG___Aplikacija_za_alternativno_glasanje.UserControls.UcExitBtn();
            this.lblLogo = new System.Windows.Forms.Label();
            this.ucLogo1 = new APAG___Aplikacija_za_alternativno_glasanje.ucLogo();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.txtImeUnos = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtPrezimeUnos = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.txtOIBUnos = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtKorisnikoImeUnos = new System.Windows.Forms.TextBox();
            this.lblBrojOsobne = new System.Windows.Forms.Label();
            this.txtBrojOsobneUnos = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtLozinkaUnos = new System.Windows.Forms.TextBox();
            this.cbGlasanja = new System.Windows.Forms.ComboBox();
            this.glasanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGlasanja = new System.Windows.Forms.Label();
            this.dgvGlasaci = new APAG___Aplikacija_za_alternativno_glasanje.UserControls.UcDataGridView();
            this.glasacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.iDglasacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipkorisnikaIDtipa2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korsinickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojosobneiskazniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glasaoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDglasanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glasanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipKorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glasanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlasaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glasacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.Controls.Add(this.lblNaslov);
            this.pnlMenuBar.Controls.Add(this.lblMinimize);
            this.pnlMenuBar.Controls.Add(this.lblHelp);
            this.pnlMenuBar.Controls.Add(this.ucExitBtn1);
            this.pnlMenuBar.Controls.Add(this.lblLogo);
            this.pnlMenuBar.Controls.Add(this.ucLogo1);
            this.pnlMenuBar.Controls.Add(this.label3);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(969, 90);
            this.pnlMenuBar.TabIndex = 0;
            this.pnlMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseDown);
            this.pnlMenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseMove);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("MS PMincho", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNaslov.Location = new System.Drawing.Point(414, 29);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(111, 33);
            this.lblNaslov.TabIndex = 45;
            this.lblNaslov.Text = "Glasači";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinimize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMinimize.Location = new System.Drawing.Point(913, 5);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 24);
            this.lblMinimize.TabIndex = 43;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMinimize_MouseMove);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHelp.Location = new System.Drawing.Point(888, 4);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(20, 24);
            this.lblHelp.TabIndex = 44;
            this.lblHelp.Text = "?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            this.lblHelp.MouseLeave += new System.EventHandler(this.lblHelp_MouseLeave);
            this.lblHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHelp_MouseMove);
            // 
            // ucExitBtn1
            // 
            this.ucExitBtn1.BackColor = System.Drawing.Color.Transparent;
            this.ucExitBtn1.Location = new System.Drawing.Point(934, 0);
            this.ucExitBtn1.Name = "ucExitBtn1";
            this.ucExitBtn1.Size = new System.Drawing.Size(35, 35);
            this.ucExitBtn1.TabIndex = 42;
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
            this.lblLogo.TabIndex = 41;
            this.lblLogo.Text = "APAG";
            // 
            // ucLogo1
            // 
            this.ucLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLogo1.BackgroundImage")));
            this.ucLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLogo1.Location = new System.Drawing.Point(3, 4);
            this.ucLogo1.Name = "ucLogo1";
            this.ucLogo1.Size = new System.Drawing.Size(71, 62);
            this.ucLogo1.TabIndex = 40;
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
            this.label3.TabIndex = 39;
            this.label3.Text = "____________________";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNatrag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.Color.Black;
            this.btnNatrag.Location = new System.Drawing.Point(847, 584);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(110, 39);
            this.btnNatrag.TabIndex = 40;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.White;
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchBar.Location = new System.Drawing.Point(23, 103);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(244, 22);
            this.txtSearchBar.TabIndex = 42;
            this.txtSearchBar.Text = "Search...";
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSpremi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(410, 543);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(154, 69);
            this.btnSpremi.TabIndex = 43;
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
            this.btnBrisanje.Location = new System.Drawing.Point(23, 479);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(179, 29);
            this.btnBrisanje.TabIndex = 44;
            this.btnBrisanje.Text = "Obriši";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // txtImeUnos
            // 
            this.txtImeUnos.Location = new System.Drawing.Point(585, 131);
            this.txtImeUnos.Name = "txtImeUnos";
            this.txtImeUnos.Size = new System.Drawing.Size(221, 20);
            this.txtImeUnos.TabIndex = 45;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(582, 115);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 46;
            this.lblIme.Text = "Ime";
            // 
            // txtPrezimeUnos
            // 
            this.txtPrezimeUnos.Location = new System.Drawing.Point(585, 183);
            this.txtPrezimeUnos.Name = "txtPrezimeUnos";
            this.txtPrezimeUnos.Size = new System.Drawing.Size(221, 20);
            this.txtPrezimeUnos.TabIndex = 47;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(582, 167);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 48;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(582, 221);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(25, 13);
            this.lblOIB.TabIndex = 50;
            this.lblOIB.Text = "OIB";
            // 
            // txtOIBUnos
            // 
            this.txtOIBUnos.Location = new System.Drawing.Point(585, 237);
            this.txtOIBUnos.Name = "txtOIBUnos";
            this.txtOIBUnos.Size = new System.Drawing.Size(221, 20);
            this.txtOIBUnos.TabIndex = 49;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(582, 274);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 52;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // txtKorisnikoImeUnos
            // 
            this.txtKorisnikoImeUnos.Location = new System.Drawing.Point(585, 290);
            this.txtKorisnikoImeUnos.Name = "txtKorisnikoImeUnos";
            this.txtKorisnikoImeUnos.Size = new System.Drawing.Size(221, 20);
            this.txtKorisnikoImeUnos.TabIndex = 51;
            // 
            // lblBrojOsobne
            // 
            this.lblBrojOsobne.AutoSize = true;
            this.lblBrojOsobne.Location = new System.Drawing.Point(582, 379);
            this.lblBrojOsobne.Name = "lblBrojOsobne";
            this.lblBrojOsobne.Size = new System.Drawing.Size(110, 13);
            this.lblBrojOsobne.TabIndex = 56;
            this.lblBrojOsobne.Text = "Broj osobne iskaznice";
            // 
            // txtBrojOsobneUnos
            // 
            this.txtBrojOsobneUnos.Location = new System.Drawing.Point(585, 395);
            this.txtBrojOsobneUnos.Name = "txtBrojOsobneUnos";
            this.txtBrojOsobneUnos.Size = new System.Drawing.Size(221, 20);
            this.txtBrojOsobneUnos.TabIndex = 55;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(582, 325);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 54;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtLozinkaUnos
            // 
            this.txtLozinkaUnos.Location = new System.Drawing.Point(585, 341);
            this.txtLozinkaUnos.Name = "txtLozinkaUnos";
            this.txtLozinkaUnos.Size = new System.Drawing.Size(221, 20);
            this.txtLozinkaUnos.TabIndex = 53;
            // 
            // cbGlasanja
            // 
            this.cbGlasanja.DataSource = this.glasanjeBindingSource;
            this.cbGlasanja.DisplayMember = "Naziv";
            this.cbGlasanja.FormattingEnabled = true;
            this.cbGlasanja.Location = new System.Drawing.Point(585, 449);
            this.cbGlasanja.Name = "cbGlasanja";
            this.cbGlasanja.Size = new System.Drawing.Size(221, 21);
            this.cbGlasanja.TabIndex = 57;
            this.cbGlasanja.ValueMember = "ID_glasanja";
            // 
            // glasanjeBindingSource
            // 
            this.glasanjeBindingSource.DataSource = typeof(APAG___Aplikacija_za_alternativno_glasanje.Glasanje);
            // 
            // lblGlasanja
            // 
            this.lblGlasanja.AutoSize = true;
            this.lblGlasanja.Location = new System.Drawing.Point(582, 433);
            this.lblGlasanja.Name = "lblGlasanja";
            this.lblGlasanja.Size = new System.Drawing.Size(48, 13);
            this.lblGlasanja.TabIndex = 58;
            this.lblGlasanja.Text = "Glasanja";
            // 
            // dgvGlasaci
            // 
            this.dgvGlasaci.AutoGenerateColumns = false;
            this.dgvGlasaci.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvGlasaci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGlasaci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGlasaci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGlasaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlasaci.ColumnHeadersVisible = false;
            this.dgvGlasaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDglasacDataGridViewTextBoxColumn,
            this.tipkorisnikaIDtipa2DataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.korsinickoimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.brojosobneiskazniceDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.glasaoDataGridViewCheckBoxColumn,
            this.iDglasanjaDataGridViewTextBoxColumn,
            this.glasanjeDataGridViewTextBoxColumn,
            this.tipKorisnikaDataGridViewTextBoxColumn});
            this.dgvGlasaci.DataSource = this.glasacBindingSource;
            this.dgvGlasaci.Location = new System.Drawing.Point(23, 131);
            this.dgvGlasaci.MultiSelect = false;
            this.dgvGlasaci.Name = "dgvGlasaci";
            this.dgvGlasaci.ReadOnly = true;
            this.dgvGlasaci.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGlasaci.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvGlasaci.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGlasaci.RowTemplate.Height = 30;
            this.dgvGlasaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGlasaci.Size = new System.Drawing.Size(513, 339);
            this.dgvGlasaci.TabIndex = 41;
            // 
            // glasacBindingSource
            // 
            this.glasacBindingSource.DataSource = typeof(APAG___Aplikacija_za_alternativno_glasanje.Glasac);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzmjeni.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIzmjeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmjeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmjeni.ForeColor = System.Drawing.Color.Black;
            this.btnIzmjeni.Location = new System.Drawing.Point(231, 479);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(179, 29);
            this.btnIzmjeni.TabIndex = 59;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = false;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // iDglasacDataGridViewTextBoxColumn
            // 
            this.iDglasacDataGridViewTextBoxColumn.DataPropertyName = "ID_glasac";
            this.iDglasacDataGridViewTextBoxColumn.HeaderText = "ID_glasac";
            this.iDglasacDataGridViewTextBoxColumn.Name = "iDglasacDataGridViewTextBoxColumn";
            this.iDglasacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipkorisnikaIDtipa2DataGridViewTextBoxColumn
            // 
            this.tipkorisnikaIDtipa2DataGridViewTextBoxColumn.DataPropertyName = "Tip_korisnikaID_tipa2";
            this.tipkorisnikaIDtipa2DataGridViewTextBoxColumn.HeaderText = "Tip_korisnikaID_tipa2";
            this.tipkorisnikaIDtipa2DataGridViewTextBoxColumn.Name = "tipkorisnikaIDtipa2DataGridViewTextBoxColumn";
            this.tipkorisnikaIDtipa2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tipkorisnikaIDtipa2DataGridViewTextBoxColumn.Visible = false;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korsinickoimeDataGridViewTextBoxColumn
            // 
            this.korsinickoimeDataGridViewTextBoxColumn.DataPropertyName = "Korsinicko_ime";
            this.korsinickoimeDataGridViewTextBoxColumn.HeaderText = "Korsinicko_ime";
            this.korsinickoimeDataGridViewTextBoxColumn.Name = "korsinickoimeDataGridViewTextBoxColumn";
            this.korsinickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojosobneiskazniceDataGridViewTextBoxColumn
            // 
            this.brojosobneiskazniceDataGridViewTextBoxColumn.DataPropertyName = "Broj_osobne_iskaznice";
            this.brojosobneiskazniceDataGridViewTextBoxColumn.HeaderText = "Broj_osobne_iskaznice";
            this.brojosobneiskazniceDataGridViewTextBoxColumn.Name = "brojosobneiskazniceDataGridViewTextBoxColumn";
            this.brojosobneiskazniceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // glasaoDataGridViewCheckBoxColumn
            // 
            this.glasaoDataGridViewCheckBoxColumn.DataPropertyName = "Glasao";
            this.glasaoDataGridViewCheckBoxColumn.HeaderText = "Glasao";
            this.glasaoDataGridViewCheckBoxColumn.Name = "glasaoDataGridViewCheckBoxColumn";
            this.glasaoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // iDglasanjaDataGridViewTextBoxColumn
            // 
            this.iDglasanjaDataGridViewTextBoxColumn.DataPropertyName = "ID_glasanja";
            this.iDglasanjaDataGridViewTextBoxColumn.HeaderText = "ID_glasanja";
            this.iDglasanjaDataGridViewTextBoxColumn.Name = "iDglasanjaDataGridViewTextBoxColumn";
            this.iDglasanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // glasanjeDataGridViewTextBoxColumn
            // 
            this.glasanjeDataGridViewTextBoxColumn.DataPropertyName = "Glasanje";
            this.glasanjeDataGridViewTextBoxColumn.HeaderText = "Glasanje";
            this.glasanjeDataGridViewTextBoxColumn.Name = "glasanjeDataGridViewTextBoxColumn";
            this.glasanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.glasanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipKorisnikaDataGridViewTextBoxColumn
            // 
            this.tipKorisnikaDataGridViewTextBoxColumn.DataPropertyName = "TipKorisnika";
            this.tipKorisnikaDataGridViewTextBoxColumn.HeaderText = "TipKorisnika";
            this.tipKorisnikaDataGridViewTextBoxColumn.Name = "tipKorisnikaDataGridViewTextBoxColumn";
            this.tipKorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipKorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmDodavanjeGlasaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 635);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.lblGlasanja);
            this.Controls.Add(this.cbGlasanja);
            this.Controls.Add(this.lblBrojOsobne);
            this.Controls.Add(this.txtBrojOsobneUnos);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtLozinkaUnos);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtKorisnikoImeUnos);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.txtOIBUnos);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezimeUnos);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtImeUnos);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.dgvGlasaci);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDodavanjeGlasaca";
            this.Text = "frmDodavanjeGlasaca";
            this.Load += new System.EventHandler(this.frmDodavanjeGlasaca_Load);
            this.Click += new System.EventHandler(this.FrmDodavanjeGlasaca_Click);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glasanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlasaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glasacBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnNatrag;
        private UserControls.UcDataGridView dgvGlasaci;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtImeUnos;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtPrezimeUnos;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.TextBox txtOIBUnos;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisnikoImeUnos;
        private System.Windows.Forms.Label lblBrojOsobne;
        private System.Windows.Forms.TextBox txtBrojOsobneUnos;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtLozinkaUnos;
        private System.Windows.Forms.ComboBox cbGlasanja;
        private System.Windows.Forms.Label lblGlasanja;
        private System.Windows.Forms.BindingSource glasanjeBindingSource;
        private System.Windows.Forms.BindingSource glasacBindingSource;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDglasacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipkorisnikaIDtipa2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korsinickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojosobneiskazniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn glasaoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDglasanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glasanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipKorisnikaDataGridViewTextBoxColumn;
    }
}