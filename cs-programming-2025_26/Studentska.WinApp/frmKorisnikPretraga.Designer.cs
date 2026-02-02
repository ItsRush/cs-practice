namespace Studentska.WinApp
{
    partial class frmKorisnikPretraga
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
            dgvKorisnici = new DataGridView();
            btnDodajKorisnika = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
            SuspendLayout();
            // 
            // dgvKorisnici
            // 
            dgvKorisnici.AllowUserToAddRows = false;
            dgvKorisnici.AllowUserToDeleteRows = false;
            dgvKorisnici.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisnici.Location = new Point(12, 84);
            dgvKorisnici.Name = "dgvKorisnici";
            dgvKorisnici.ReadOnly = true;
            dgvKorisnici.Size = new Size(586, 213);
            dgvKorisnici.TabIndex = 0;
            dgvKorisnici.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDodajKorisnika
            // 
            btnDodajKorisnika.Location = new Point(471, 41);
            btnDodajKorisnika.Name = "btnDodajKorisnika";
            btnDodajKorisnika.Size = new Size(127, 23);
            btnDodajKorisnika.TabIndex = 1;
            btnDodajKorisnika.Text = "Dodaj Korisnika";
            btnDodajKorisnika.UseVisualStyleBackColor = true;
            btnDodajKorisnika.Click += btnDodajKorisnika_Click;
            // 
            // frmKorisnikPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 309);
            Controls.Add(btnDodajKorisnika);
            Controls.Add(dgvKorisnici);
            Name = "frmKorisnikPretraga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKorisnikPretraga";
            Load += frmKorisnikPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKorisnici;
        private Button btnDodajKorisnika;
    }
}