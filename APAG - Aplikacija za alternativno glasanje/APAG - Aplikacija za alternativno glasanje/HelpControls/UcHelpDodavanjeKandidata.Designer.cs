namespace APAG___Aplikacija_za_alternativno_glasanje.HelpControls
{
    partial class UcHelpDodavanjeKandidata
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHelpDodavanjeKandidata));
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTekst2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTekst
            // 
            this.txtTekst.BackColor = System.Drawing.Color.White;
            this.txtTekst.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTekst.Location = new System.Drawing.Point(0, 0);
            this.txtTekst.Multiline = true;
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.ReadOnly = true;
            this.txtTekst.Size = new System.Drawing.Size(552, 456);
            this.txtTekst.TabIndex = 0;
            this.txtTekst.Text = resources.GetString("txtTekst.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtTekst2
            // 
            this.txtTekst2.BackColor = System.Drawing.Color.White;
            this.txtTekst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTekst2.Location = new System.Drawing.Point(0, 820);
            this.txtTekst2.Multiline = true;
            this.txtTekst2.Name = "txtTekst2";
            this.txtTekst2.ReadOnly = true;
            this.txtTekst2.Size = new System.Drawing.Size(552, 127);
            this.txtTekst2.TabIndex = 2;
            this.txtTekst2.Text = resources.GetString("txtTekst2.Text");
            this.txtTekst2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UcHelpDodavanjeKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTekst2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTekst);
            this.Name = "UcHelpDodavanjeKandidata";
            this.Size = new System.Drawing.Size(552, 970);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTekst2;
    }
}
