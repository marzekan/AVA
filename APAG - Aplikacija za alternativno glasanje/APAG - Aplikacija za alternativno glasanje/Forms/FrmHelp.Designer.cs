namespace APAG___Aplikacija_za_alternativno_glasanje.Forms
{
    partial class FrmHelp
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Glasač");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Administrator");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Login", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Glasanje");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Statistike");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Glavni izbornik", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Novo glasanje");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Kandidati");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Glasači");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Statistike");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Admin", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.tvSadrzaj = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHead = new System.Windows.Forms.RichTextBox();
            this.pnlTeksts = new System.Windows.Forms.Panel();
            this.HelpDodavanjeKandidata = new APAG___Aplikacija_za_alternativno_glasanje.HelpControls.UcHelpDodavanjeKandidata();
            this.HelpNovoGlasanje = new APAG___Aplikacija_za_alternativno_glasanje.HelpControls.UcHelpNovoGlasanje();
            this.HelpGlIzb_Admin = new APAG___Aplikacija_za_alternativno_glasanje.HelpControls.UcHelpGlIzb_Admin();
            this.HelpGlIzb_Glasacki = new APAG___Aplikacija_za_alternativno_glasanje.HelpControls.UcHelpGlIzb_Glasacki();
            this.HelpLoginAdmin = new APAG___Aplikacija_za_alternativno_glasanje.HelpControls.UcHelpLoginAdmin();
            this.HelpLoginGlasacki = new APAG___Aplikacija_za_alternativno_glasanje.HelpControls.UcHelpLoginGlasac();
            this.ucLogo1 = new APAG___Aplikacija_za_alternativno_glasanje.ucLogo();
            this.HelpDodavanjeGlasaca = new APAG___Aplikacija_za_alternativno_glasanje.HelpControls.UcHelpDodavanjeGlasaca();
            this.pnlMenuBar.SuspendLayout();
            this.pnlTeksts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMenuBar.Controls.Add(this.ucLogo1);
            this.pnlMenuBar.Controls.Add(this.lblExit);
            this.pnlMenuBar.Controls.Add(this.lblLogo);
            this.pnlMenuBar.Controls.Add(this.lblMinimize);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(703, 30);
            this.pnlMenuBar.TabIndex = 0;
            this.pnlMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseDown);
            this.pnlMenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseMove);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(676, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(24, 24);
            this.lblExit.TabIndex = 29;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseMove);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblLogo.Location = new System.Drawing.Point(27, 2);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(60, 19);
            this.lblLogo.TabIndex = 21;
            this.lblLogo.Text = "APAG";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(650, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 24);
            this.lblMinimize.TabIndex = 28;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMinimize_MouseMove);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 30);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(11, 404);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(692, 30);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(11, 404);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(11, 424);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(681, 10);
            this.pnlDown.TabIndex = 3;
            // 
            // tvSadrzaj
            // 
            this.tvSadrzaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvSadrzaj.Location = new System.Drawing.Point(17, 109);
            this.tvSadrzaj.Name = "tvSadrzaj";
            treeNode1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode1.Name = "Glasac";
            treeNode1.Text = "Glasač";
            treeNode2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode2.Name = "Admin";
            treeNode2.Text = "Administrator";
            treeNode3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode3.Name = "Login";
            treeNode3.Text = "Login";
            treeNode4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode4.Name = "Glasanje";
            treeNode4.Text = "Glasanje";
            treeNode5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode5.Name = "Statistike";
            treeNode5.Text = "Statistike";
            treeNode6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode6.Name = "GlIzbGlasac";
            treeNode6.Text = "Glavni izbornik";
            treeNode7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode7.Name = "NovoGlasanje";
            treeNode7.Text = "Novo glasanje";
            treeNode8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode8.Name = "Kandidati";
            treeNode8.Text = "Kandidati";
            treeNode9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode9.Name = "Glasaci";
            treeNode9.Text = "Glasači";
            treeNode10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode10.Name = "Statistike";
            treeNode10.Text = "Statistike";
            treeNode11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            treeNode11.Name = "GlIzbAdmin";
            treeNode11.Text = "Admin";
            this.tvSadrzaj.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode11});
            this.tvSadrzaj.Size = new System.Drawing.Size(117, 303);
            this.tvSadrzaj.TabIndex = 4;
            this.tvSadrzaj.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvSadrzaj_BeforeSelect);
            this.tvSadrzaj.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSadrzaj_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(294, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Help";
            // 
            // txtHead
            // 
            this.txtHead.BackColor = System.Drawing.Color.White;
            this.txtHead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHead.Location = new System.Drawing.Point(140, 89);
            this.txtHead.Name = "txtHead";
            this.txtHead.ReadOnly = true;
            this.txtHead.Size = new System.Drawing.Size(532, 52);
            this.txtHead.TabIndex = 6;
            this.txtHead.Text = "Dobrodošli u Help prozor APAG - Aplikacije za alternativno glasanje. \nOvdje možet" +
    "e pronaći informacije o tome kako koristiti APAG aplikaciju. \n";
            // 
            // pnlTeksts
            // 
            this.pnlTeksts.AutoScroll = true;
            this.pnlTeksts.Controls.Add(this.HelpDodavanjeGlasaca);
            this.pnlTeksts.Controls.Add(this.HelpDodavanjeKandidata);
            this.pnlTeksts.Controls.Add(this.HelpNovoGlasanje);
            this.pnlTeksts.Controls.Add(this.HelpGlIzb_Admin);
            this.pnlTeksts.Controls.Add(this.HelpGlIzb_Glasacki);
            this.pnlTeksts.Controls.Add(this.HelpLoginAdmin);
            this.pnlTeksts.Controls.Add(this.HelpLoginGlasacki);
            this.pnlTeksts.Location = new System.Drawing.Point(140, 147);
            this.pnlTeksts.Name = "pnlTeksts";
            this.pnlTeksts.Size = new System.Drawing.Size(552, 275);
            this.pnlTeksts.TabIndex = 7;
            // 
            // HelpDodavanjeKandidata
            // 
            this.HelpDodavanjeKandidata.Location = new System.Drawing.Point(0, 0);
            this.HelpDodavanjeKandidata.Name = "HelpDodavanjeKandidata";
            this.HelpDodavanjeKandidata.Size = new System.Drawing.Size(552, 970);
            this.HelpDodavanjeKandidata.TabIndex = 5;
            // 
            // HelpNovoGlasanje
            // 
            this.HelpNovoGlasanje.Location = new System.Drawing.Point(0, 0);
            this.HelpNovoGlasanje.Name = "HelpNovoGlasanje";
            this.HelpNovoGlasanje.Size = new System.Drawing.Size(552, 741);
            this.HelpNovoGlasanje.TabIndex = 4;
            // 
            // HelpGlIzb_Admin
            // 
            this.HelpGlIzb_Admin.Location = new System.Drawing.Point(0, 0);
            this.HelpGlIzb_Admin.Name = "HelpGlIzb_Admin";
            this.HelpGlIzb_Admin.Size = new System.Drawing.Size(552, 1157);
            this.HelpGlIzb_Admin.TabIndex = 3;
            // 
            // HelpGlIzb_Glasacki
            // 
            this.HelpGlIzb_Glasacki.BackColor = System.Drawing.Color.White;
            this.HelpGlIzb_Glasacki.Location = new System.Drawing.Point(0, 0);
            this.HelpGlIzb_Glasacki.Name = "HelpGlIzb_Glasacki";
            this.HelpGlIzb_Glasacki.Size = new System.Drawing.Size(552, 425);
            this.HelpGlIzb_Glasacki.TabIndex = 2;
            // 
            // HelpLoginAdmin
            // 
            this.HelpLoginAdmin.Location = new System.Drawing.Point(0, 0);
            this.HelpLoginAdmin.Name = "HelpLoginAdmin";
            this.HelpLoginAdmin.Size = new System.Drawing.Size(532, 647);
            this.HelpLoginAdmin.TabIndex = 1;
            // 
            // HelpLoginGlasacki
            // 
            this.HelpLoginGlasacki.Location = new System.Drawing.Point(0, 0);
            this.HelpLoginGlasacki.Name = "HelpLoginGlasacki";
            this.HelpLoginGlasacki.Size = new System.Drawing.Size(532, 742);
            this.HelpLoginGlasacki.TabIndex = 0;
            // 
            // ucLogo1
            // 
            this.ucLogo1.BackColor = System.Drawing.Color.Transparent;
            this.ucLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLogo1.BackgroundImage")));
            this.ucLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLogo1.Location = new System.Drawing.Point(5, 2);
            this.ucLogo1.Name = "ucLogo1";
            this.ucLogo1.Size = new System.Drawing.Size(25, 23);
            this.ucLogo1.TabIndex = 22;
            // 
            // HelpDodavanjeGlasaca
            // 
            this.HelpDodavanjeGlasaca.Location = new System.Drawing.Point(0, 0);
            this.HelpDodavanjeGlasaca.Name = "HelpDodavanjeGlasaca";
            this.HelpDodavanjeGlasaca.Size = new System.Drawing.Size(552, 903);
            this.HelpDodavanjeGlasaca.TabIndex = 6;
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 434);
            this.Controls.Add(this.pnlTeksts);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvSadrzaj);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHelp";
            this.Text = "Help";
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.pnlTeksts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.TreeView tvSadrzaj;
        private ucLogo ucLogo1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtHead;
        private System.Windows.Forms.Panel pnlTeksts;
        private HelpControls.UcHelpLoginAdmin HelpLoginAdmin;
        private HelpControls.UcHelpLoginGlasac HelpLoginGlasacki;
        private HelpControls.UcHelpGlIzb_Glasacki HelpGlIzb_Glasacki;
        private HelpControls.UcHelpGlIzb_Admin HelpGlIzb_Admin;
        private HelpControls.UcHelpNovoGlasanje HelpNovoGlasanje;
        private HelpControls.UcHelpDodavanjeKandidata HelpDodavanjeKandidata;
        private HelpControls.UcHelpDodavanjeGlasaca HelpDodavanjeGlasaca;
    }
}