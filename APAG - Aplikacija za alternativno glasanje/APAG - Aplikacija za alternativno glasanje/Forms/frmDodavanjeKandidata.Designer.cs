namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    partial class FrmDodavanjeKandidata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodavanjeKandidata));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.ucLogo1 = new APAG___Aplikacija_za_alternativno_glasanje.ucLogo();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.ucExitBtn1 = new APAG___Aplikacija_za_alternativno_glasanje.UserControls.UcExitBtn();
            this.txtImeUnos = new System.Windows.Forms.TextBox();
            this.txtPrezimeUnos = new System.Windows.Forms.TextBox();
            this.txtNazivUnos = new System.Windows.Forms.TextBox();
            this.txtPorukaUnos = new System.Windows.Forms.TextBox();
            this.pbSlikaKandidata = new System.Windows.Forms.PictureBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.lblSlika = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.cbGlasanja = new System.Windows.Forms.ComboBox();
            this.glasanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKandidati = new APAG___Aplikacija_za_alternativno_glasanje.UserControls.UcDataGridView();
            this.iDkandidataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glasanjeIDglasanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaPorukaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.glasanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kandidatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kandidatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaKandidata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glasanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandidati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandidatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandidatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.Controls.Add(this.lblNaslov);
            this.pnlMenuBar.Controls.Add(this.lblLogo);
            this.pnlMenuBar.Controls.Add(this.ucLogo1);
            this.pnlMenuBar.Controls.Add(this.label3);
            this.pnlMenuBar.Controls.Add(this.lblMinimize);
            this.pnlMenuBar.Controls.Add(this.lblHelp);
            this.pnlMenuBar.Controls.Add(this.ucExitBtn1);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(797, 92);
            this.pnlMenuBar.TabIndex = 1;
            this.pnlMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseDown);
            this.pnlMenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseMove);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("MS PMincho", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNaslov.Location = new System.Drawing.Point(329, 33);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(141, 33);
            this.lblNaslov.TabIndex = 39;
            this.lblNaslov.Text = "Kandidati";
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
            this.lblLogo.TabIndex = 38;
            this.lblLogo.Text = "APAG";
            // 
            // ucLogo1
            // 
            this.ucLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLogo1.BackgroundImage")));
            this.ucLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLogo1.Location = new System.Drawing.Point(3, 4);
            this.ucLogo1.Name = "ucLogo1";
            this.ucLogo1.Size = new System.Drawing.Size(71, 62);
            this.ucLogo1.TabIndex = 37;
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
            this.label3.TabIndex = 36;
            this.label3.Text = "____________________";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinimize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMinimize.Location = new System.Drawing.Point(743, 4);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 24);
            this.lblMinimize.TabIndex = 28;
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
            this.lblHelp.Location = new System.Drawing.Point(718, 3);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(20, 24);
            this.lblHelp.TabIndex = 29;
            this.lblHelp.Text = "?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            this.lblHelp.MouseLeave += new System.EventHandler(this.lblHelp_MouseLeave);
            this.lblHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHelp_MouseMove);
            // 
            // ucExitBtn1
            // 
            this.ucExitBtn1.BackColor = System.Drawing.Color.Transparent;
            this.ucExitBtn1.Location = new System.Drawing.Point(763, 0);
            this.ucExitBtn1.Name = "ucExitBtn1";
            this.ucExitBtn1.Size = new System.Drawing.Size(35, 35);
            this.ucExitBtn1.TabIndex = 0;
            // 
            // txtImeUnos
            // 
            this.txtImeUnos.Location = new System.Drawing.Point(335, 126);
            this.txtImeUnos.Name = "txtImeUnos";
            this.txtImeUnos.Size = new System.Drawing.Size(182, 20);
            this.txtImeUnos.TabIndex = 3;
            // 
            // txtPrezimeUnos
            // 
            this.txtPrezimeUnos.Location = new System.Drawing.Point(335, 173);
            this.txtPrezimeUnos.Name = "txtPrezimeUnos";
            this.txtPrezimeUnos.Size = new System.Drawing.Size(182, 20);
            this.txtPrezimeUnos.TabIndex = 4;
            // 
            // txtNazivUnos
            // 
            this.txtNazivUnos.Location = new System.Drawing.Point(335, 222);
            this.txtNazivUnos.Name = "txtNazivUnos";
            this.txtNazivUnos.Size = new System.Drawing.Size(182, 20);
            this.txtNazivUnos.TabIndex = 5;
            // 
            // txtPorukaUnos
            // 
            this.txtPorukaUnos.Location = new System.Drawing.Point(335, 333);
            this.txtPorukaUnos.Multiline = true;
            this.txtPorukaUnos.Name = "txtPorukaUnos";
            this.txtPorukaUnos.Size = new System.Drawing.Size(403, 108);
            this.txtPorukaUnos.TabIndex = 6;
            // 
            // pbSlikaKandidata
            // 
            this.pbSlikaKandidata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaKandidata.Location = new System.Drawing.Point(604, 112);
            this.pbSlikaKandidata.Name = "pbSlikaKandidata";
            this.pbSlikaKandidata.Size = new System.Drawing.Size(134, 139);
            this.pbSlikaKandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaKandidata.TabIndex = 7;
            this.pbSlikaKandidata.TabStop = false;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(335, 107);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 8;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(335, 157);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 9;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(335, 206);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(335, 317);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(84, 13);
            this.lblPoruka.TabIndex = 11;
            this.lblPoruka.Text = "Dodatna poruka";
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSlika.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSlika.Location = new System.Drawing.Point(655, 253);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(40, 18);
            this.lblSlika.TabIndex = 12;
            this.lblSlika.Text = "Slika";
            this.lblSlika.Click += new System.EventHandler(this.lblSlika_Click);
            this.lblSlika.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSlika_MouseDown);
            this.lblSlika.MouseLeave += new System.EventHandler(this.lblSlika_MouseLeave);
            this.lblSlika.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSlika_MouseMove);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSpremi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(335, 448);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(135, 56);
            this.btnSpremi.TabIndex = 38;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
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
            this.btnNatrag.TabIndex = 39;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.White;
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchBar.Location = new System.Drawing.Point(12, 98);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(239, 22);
            this.txtSearchBar.TabIndex = 40;
            this.txtSearchBar.Text = "Search...";
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrisanje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisanje.ForeColor = System.Drawing.Color.Black;
            this.btnBrisanje.Location = new System.Drawing.Point(39, 447);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(177, 29);
            this.btnBrisanje.TabIndex = 41;
            this.btnBrisanje.Text = "Obriši";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // cbGlasanja
            // 
            this.cbGlasanja.DataSource = this.glasanjeBindingSource;
            this.cbGlasanja.DisplayMember = "Naziv";
            this.cbGlasanja.FormattingEnabled = true;
            this.cbGlasanja.Location = new System.Drawing.Point(335, 274);
            this.cbGlasanja.Name = "cbGlasanja";
            this.cbGlasanja.Size = new System.Drawing.Size(182, 21);
            this.cbGlasanja.TabIndex = 42;
            this.cbGlasanja.ValueMember = "ID_glasanja";
            // 
            // glasanjeBindingSource
            // 
            this.glasanjeBindingSource.DataSource = typeof(APAG___Aplikacija_za_alternativno_glasanje.Glasanje);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Glasanje";
            // 
            // dgvKandidati
            // 
            this.dgvKandidati.AutoGenerateColumns = false;
            this.dgvKandidati.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKandidati.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKandidati.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKandidati.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKandidati.ColumnHeadersVisible = false;
            this.dgvKandidati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkandidataDataGridViewTextBoxColumn,
            this.glasanjeIDglasanjaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.dodatnaPorukaDataGridViewTextBoxColumn,
            this.slikaDataGridViewImageColumn,
            this.glasanjeDataGridViewTextBoxColumn,
            this.glasDataGridViewTextBoxColumn});
            this.dgvKandidati.DataSource = this.kandidatBindingSource;
            this.dgvKandidati.Location = new System.Drawing.Point(12, 137);
            this.dgvKandidati.MultiSelect = false;
            this.dgvKandidati.Name = "dgvKandidati";
            this.dgvKandidati.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKandidati.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvKandidati.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKandidati.RowTemplate.Height = 30;
            this.dgvKandidati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKandidati.Size = new System.Drawing.Size(241, 290);
            this.dgvKandidati.TabIndex = 44;
            // 
            // iDkandidataDataGridViewTextBoxColumn
            // 
            this.iDkandidataDataGridViewTextBoxColumn.DataPropertyName = "ID_kandidata";
            this.iDkandidataDataGridViewTextBoxColumn.HeaderText = "ID_kandidata";
            this.iDkandidataDataGridViewTextBoxColumn.Name = "iDkandidataDataGridViewTextBoxColumn";
            // 
            // glasanjeIDglasanjaDataGridViewTextBoxColumn
            // 
            this.glasanjeIDglasanjaDataGridViewTextBoxColumn.DataPropertyName = "GlasanjeID_glasanja";
            this.glasanjeIDglasanjaDataGridViewTextBoxColumn.HeaderText = "GlasanjeID_glasanja";
            this.glasanjeIDglasanjaDataGridViewTextBoxColumn.Name = "glasanjeIDglasanjaDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // dodatnaPorukaDataGridViewTextBoxColumn
            // 
            this.dodatnaPorukaDataGridViewTextBoxColumn.DataPropertyName = "DodatnaPoruka";
            this.dodatnaPorukaDataGridViewTextBoxColumn.HeaderText = "DodatnaPoruka";
            this.dodatnaPorukaDataGridViewTextBoxColumn.Name = "dodatnaPorukaDataGridViewTextBoxColumn";
            // 
            // slikaDataGridViewImageColumn
            // 
            this.slikaDataGridViewImageColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewImageColumn.HeaderText = "Slika";
            this.slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
            this.slikaDataGridViewImageColumn.Visible = false;
            // 
            // glasanjeDataGridViewTextBoxColumn
            // 
            this.glasanjeDataGridViewTextBoxColumn.DataPropertyName = "Glasanje";
            this.glasanjeDataGridViewTextBoxColumn.HeaderText = "Glasanje";
            this.glasanjeDataGridViewTextBoxColumn.Name = "glasanjeDataGridViewTextBoxColumn";
            this.glasanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // glasDataGridViewTextBoxColumn
            // 
            this.glasDataGridViewTextBoxColumn.DataPropertyName = "Glas";
            this.glasDataGridViewTextBoxColumn.HeaderText = "Glas";
            this.glasDataGridViewTextBoxColumn.Name = "glasDataGridViewTextBoxColumn";
            this.glasDataGridViewTextBoxColumn.Visible = false;
            // 
            // kandidatBindingSource
            // 
            this.kandidatBindingSource.DataSource = typeof(APAG___Aplikacija_za_alternativno_glasanje.Kandidat);
            // 
            // kandidatBindingSource1
            // 
            this.kandidatBindingSource1.DataSource = typeof(APAG___Aplikacija_za_alternativno_glasanje.Kandidat);
            // 
            // FrmDodavanjeKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 516);
            this.Controls.Add(this.dgvKandidati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGlasanja);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.pbSlikaKandidata);
            this.Controls.Add(this.txtPorukaUnos);
            this.Controls.Add(this.txtNazivUnos);
            this.Controls.Add(this.txtPrezimeUnos);
            this.Controls.Add(this.txtImeUnos);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDodavanjeKandidata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodavanjeKandidata";
            this.Load += new System.EventHandler(this.frmDodavanjeKandidata_Load);
            this.Click += new System.EventHandler(this.FrmDodavanjeKandidata_Click);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaKandidata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glasanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandidati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandidatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandidatBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UcExitBtn ucExitBtn1;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblLogo;
        private ucLogo ucLogo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtImeUnos;
        private System.Windows.Forms.TextBox txtPrezimeUnos;
        private System.Windows.Forms.TextBox txtNazivUnos;
        private System.Windows.Forms.TextBox txtPorukaUnos;
        private System.Windows.Forms.PictureBox pbSlikaKandidata;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.ComboBox cbGlasanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource glasanjeBindingSource;
        private UserControls.UcDataGridView dgvKandidati;
        private System.Windows.Forms.BindingSource kandidatBindingSource;
        private System.Windows.Forms.BindingSource kandidatBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkandidataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glasanjeIDglasanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatnaPorukaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn slikaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glasanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glasDataGridViewTextBoxColumn;
    }
}