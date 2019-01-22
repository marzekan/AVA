namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    partial class FrmGlavniIzbornik_Glasacki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavniIzbornik_Glasacki));
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pboxLogOut = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVodstvo = new System.Windows.Forms.Label();
            this.lblTrenutnoVrijeme = new System.Windows.Forms.Label();
            this.lblImeKandidata = new System.Windows.Forms.Label();
            this.lblPreostaloVrijeme = new System.Windows.Forms.Label();
            this.PreostaloVrijemelbl = new System.Windows.Forms.Label();
            this.btnStatistike = new APAG___Aplikacija_za_alternativno_glasanje.UserControls.UcCircleBtn();
            this.btnGlasaj = new APAG___Aplikacija_za_alternativno_glasanje.UserControls.UcCircleBtn();
            this.ucLogo1 = new APAG___Aplikacija_za_alternativno_glasanje.ucLogo();
            this.ucExitBtn1 = new APAG___Aplikacija_za_alternativno_glasanje.UserControls.UcExitBtn();
            this.tajmerPreostaloVrijeme = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuBar.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuBar.Controls.Add(this.lblHelp);
            this.pnlMenuBar.Controls.Add(this.lblMinimize);
            this.pnlMenuBar.Controls.Add(this.ucExitBtn1);
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(802, 53);
            this.pnlMenuBar.TabIndex = 0;
            this.pnlMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseDown);
            this.pnlMenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseMove);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHelp.Location = new System.Drawing.Point(714, 3);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(20, 24);
            this.lblHelp.TabIndex = 26;
            this.lblHelp.Text = "?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            this.lblHelp.MouseLeave += new System.EventHandler(this.lblHelp_MouseLeave);
            this.lblHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHelp_MouseMove);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinimize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMinimize.Location = new System.Drawing.Point(740, 2);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 24);
            this.lblMinimize.TabIndex = 25;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMinimize_MouseMove);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(12, 91);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(95, 25);
            this.lblNaslov.TabIndex = 23;
            this.lblNaslov.Text = "Korisnik:";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("MS PMincho", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblLogo.Location = new System.Drawing.Point(68, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(98, 33);
            this.lblLogo.TabIndex = 18;
            this.lblLogo.Text = "APAG";
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlSideMenu.Controls.Add(this.pboxLogOut);
            this.pnlSideMenu.Controls.Add(this.label3);
            this.pnlSideMenu.Controls.Add(this.lblPrezime);
            this.pnlSideMenu.Controls.Add(this.lblIme);
            this.pnlSideMenu.Controls.Add(this.btnOdjava);
            this.pnlSideMenu.Controls.Add(this.lblLogo);
            this.pnlSideMenu.Controls.Add(this.lblNaslov);
            this.pnlSideMenu.Controls.Add(this.ucLogo1);
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(170, 572);
            this.pnlSideMenu.TabIndex = 5;
            // 
            // pboxLogOut
            // 
            this.pboxLogOut.BackColor = System.Drawing.Color.Transparent;
            this.pboxLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxLogOut.BackgroundImage")));
            this.pboxLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxLogOut.Location = new System.Drawing.Point(20, 512);
            this.pboxLogOut.Name = "pboxLogOut";
            this.pboxLogOut.Size = new System.Drawing.Size(54, 47);
            this.pboxLogOut.TabIndex = 28;
            this.pboxLogOut.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "____________________";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.ForeColor = System.Drawing.Color.White;
            this.lblPrezime.Location = new System.Drawing.Point(16, 170);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(66, 20);
            this.lblPrezime.TabIndex = 26;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.ForeColor = System.Drawing.Color.White;
            this.lblIme.Location = new System.Drawing.Point(16, 136);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 20);
            this.lblIme.TabIndex = 25;
            this.lblIme.Text = "Ime";
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdjava.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.ForeColor = System.Drawing.Color.Black;
            this.btnOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Location = new System.Drawing.Point(3, 508);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(163, 56);
            this.btnOdjava.TabIndex = 24;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(270, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Glasaj!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(580, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Statistike";
            // 
            // lblVodstvo
            // 
            this.lblVodstvo.AutoSize = true;
            this.lblVodstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVodstvo.Location = new System.Drawing.Point(550, 68);
            this.lblVodstvo.Name = "lblVodstvo";
            this.lblVodstvo.Size = new System.Drawing.Size(74, 18);
            this.lblVodstvo.TabIndex = 11;
            this.lblVodstvo.Text = "U vodstvu";
            // 
            // lblTrenutnoVrijeme
            // 
            this.lblTrenutnoVrijeme.AutoSize = true;
            this.lblTrenutnoVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutnoVrijeme.Location = new System.Drawing.Point(619, 68);
            this.lblTrenutnoVrijeme.Name = "lblTrenutnoVrijeme";
            this.lblTrenutnoVrijeme.Size = new System.Drawing.Size(92, 18);
            this.lblTrenutnoVrijeme.TabIndex = 13;
            this.lblTrenutnoVrijeme.Text = "(hh:mm:ss) :";
            // 
            // lblImeKandidata
            // 
            this.lblImeKandidata.AutoSize = true;
            this.lblImeKandidata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeKandidata.Location = new System.Drawing.Point(634, 98);
            this.lblImeKandidata.Name = "lblImeKandidata";
            this.lblImeKandidata.Size = new System.Drawing.Size(97, 18);
            this.lblImeKandidata.TabIndex = 15;
            this.lblImeKandidata.Text = "ImeKandidata";
            // 
            // lblPreostaloVrijeme
            // 
            this.lblPreostaloVrijeme.AutoSize = true;
            this.lblPreostaloVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPreostaloVrijeme.Location = new System.Drawing.Point(189, 68);
            this.lblPreostaloVrijeme.Name = "lblPreostaloVrijeme";
            this.lblPreostaloVrijeme.Size = new System.Drawing.Size(127, 18);
            this.lblPreostaloVrijeme.TabIndex = 16;
            this.lblPreostaloVrijeme.Text = "Preostalo vrijeme:";
            // 
            // PreostaloVrijemelbl
            // 
            this.PreostaloVrijemelbl.AutoSize = true;
            this.PreostaloVrijemelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreostaloVrijemelbl.Location = new System.Drawing.Point(313, 68);
            this.PreostaloVrijemelbl.Name = "PreostaloVrijemelbl";
            this.PreostaloVrijemelbl.Size = new System.Drawing.Size(80, 18);
            this.PreostaloVrijemelbl.TabIndex = 17;
            this.PreostaloVrijemelbl.Text = "HH:mm:ss";
            // 
            // btnStatistike
            // 
            this.btnStatistike.BackColor = System.Drawing.Color.LightBlue;
            this.btnStatistike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistike.BackgroundImage")));
            this.btnStatistike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistike.ForeColor = System.Drawing.Color.LightBlue;
            this.btnStatistike.Location = new System.Drawing.Point(556, 325);
            this.btnStatistike.Name = "btnStatistike";
            this.btnStatistike.Size = new System.Drawing.Size(178, 175);
            this.btnStatistike.TabIndex = 9;
            this.btnStatistike.UseVisualStyleBackColor = false;
            this.btnStatistike.MouseLeave += new System.EventHandler(this.btnStatistike_MouseLeave);
            this.btnStatistike.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnStatistike_MouseMove);
            // 
            // btnGlasaj
            // 
            this.btnGlasaj.BackColor = System.Drawing.Color.LightBlue;
            this.btnGlasaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGlasaj.BackgroundImage")));
            this.btnGlasaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGlasaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlasaj.ForeColor = System.Drawing.Color.LightBlue;
            this.btnGlasaj.Location = new System.Drawing.Point(230, 328);
            this.btnGlasaj.Name = "btnGlasaj";
            this.btnGlasaj.Size = new System.Drawing.Size(178, 172);
            this.btnGlasaj.TabIndex = 6;
            this.btnGlasaj.UseVisualStyleBackColor = false;
            this.btnGlasaj.MouseLeave += new System.EventHandler(this.btnGlasaj_MouseLeave);
            this.btnGlasaj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGlasaj_MouseMove);
            // 
            // ucLogo1
            // 
            this.ucLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLogo1.BackgroundImage")));
            this.ucLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLogo1.Location = new System.Drawing.Point(3, 3);
            this.ucLogo1.Name = "ucLogo1";
            this.ucLogo1.Size = new System.Drawing.Size(71, 62);
            this.ucLogo1.TabIndex = 5;
            // 
            // ucExitBtn1
            // 
            this.ucExitBtn1.BackColor = System.Drawing.Color.Transparent;
            this.ucExitBtn1.Location = new System.Drawing.Point(764, 0);
            this.ucExitBtn1.Name = "ucExitBtn1";
            this.ucExitBtn1.Size = new System.Drawing.Size(35, 35);
            this.ucExitBtn1.TabIndex = 27;
            // 
            // tajmerPreostaloVrijeme
            // 
            this.tajmerPreostaloVrijeme.Interval = 1000;
            this.tajmerPreostaloVrijeme.Tick += new System.EventHandler(this.tajmerPreostaloVrijeme_Tick);
            // 
            // FrmGlavniIzbornik_Glasacki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.PreostaloVrijemelbl);
            this.Controls.Add(this.lblPreostaloVrijeme);
            this.Controls.Add(this.lblImeKandidata);
            this.Controls.Add(this.lblTrenutnoVrijeme);
            this.Controls.Add(this.lblVodstvo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStatistike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGlasaj);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGlavniIzbornik_Glasacki";
            this.Text = "frmGlavniIzbornik_Glasacki";
            this.Load += new System.EventHandler(this.FrmGlavniIzbornik_Glasacki_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblHelp;
        private ucLogo ucLogo1;
        private System.Windows.Forms.Label lblLogo;
        private UserControls.UcExitBtn ucExitBtn1;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnOdjava;
        private UserControls.UcCircleBtn btnGlasaj;
        private System.Windows.Forms.Label label1;
        private UserControls.UcCircleBtn btnStatistike;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.PictureBox pboxLogOut;
        private System.Windows.Forms.Label lblVodstvo;
        private System.Windows.Forms.Label lblTrenutnoVrijeme;
        private System.Windows.Forms.Label lblImeKandidata;
        private System.Windows.Forms.Label lblPreostaloVrijeme;
        private System.Windows.Forms.Label PreostaloVrijemelbl;
        private System.Windows.Forms.Timer tajmerPreostaloVrijeme;
    }
}