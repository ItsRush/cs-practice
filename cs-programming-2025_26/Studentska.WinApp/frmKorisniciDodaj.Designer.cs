namespace Studentska.WinApp
{
    partial class frmKorisniciDodaj
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
            pbSlika = new PictureBox();
            ofdSlika = new OpenFileDialog();
            btnSacuvaj = new Button();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtKorisnickoIme = new TextBox();
            txtLozinka = new TextBox();
            dtpDatumRodjenja = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbAktivan = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.BackgroundImageLayout = ImageLayout.Stretch;
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(47, 70);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(180, 234);
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.Click += pictureBox1_Click;
            // 
            // ofdSlika
            // 
            ofdSlika.FileName = "openFileDialog1";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(566, 285);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(269, 113);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(183, 23);
            txtIme.TabIndex = 2;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(458, 113);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(183, 23);
            txtPrezime.TabIndex = 2;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(269, 243);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(183, 23);
            txtKorisnickoIme.TabIndex = 2;
            txtKorisnickoIme.TextChanged += txtKorisnickoIme_TextChanged;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(458, 243);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(183, 23);
            txtLozinka.TabIndex = 2;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(269, 181);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(372, 23);
            dtpDatumRodjenja.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 95);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 4;
            label1.Text = "Ime";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 95);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Prezime";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 163);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Datum rođenja";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 225);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 4;
            label4.Text = "Korisničko ime";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 225);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Lozinka:";
            label5.Click += label1_Click;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(269, 285);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 5;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // frmKorisniciDodaj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 386);
            Controls.Add(cbAktivan);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(txtLozinka);
            Controls.Add(txtPrezime);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(txtIme);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Name = "frmKorisniciDodaj";
            Text = "frmKorisniciDodaj";
            Load += frmKorisniciDodaj_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private OpenFileDialog ofdSlika;
        private Button btnSacuvaj;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtKorisnickoIme;
        private TextBox txtLozinka;
        private DateTimePicker dtpDatumRodjenja;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox cbAktivan;
    }
}