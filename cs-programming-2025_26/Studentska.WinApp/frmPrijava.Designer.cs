namespace Studentska.WinApp
{
    partial class frmPrijava
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtKorisnickoIme = new TextBox();
            label2 = new Label();
            txtLozinka = new TextBox();
            btnPrijava = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 99);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Korisničko ime";
            label1.Click += label1_Click;
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(483, 117);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(295, 23);
            txtKorisnickoIme.TabIndex = 1;
            txtKorisnickoIme.Text = "korisnik1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(483, 175);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Lozinka";
            label2.Click += label1_Click;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(483, 193);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(295, 23);
            txtLozinka.TabIndex = 1;
            txtLozinka.Text = "korisnik1";
            // 
            // btnPrijava
            // 
            btnPrijava.BackColor = SystemColors.ActiveCaption;
            btnPrijava.Location = new Point(663, 269);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(115, 43);
            btnPrijava.TabIndex = 2;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = false;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_292905667_yFUJNJPngYeRNlrRL4hApHWxuYyRY4kN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 324);
            Controls.Add(btnPrijava);
            Controls.Add(txtLozinka);
            Controls.Add(label2);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(label1);
            Name = "frmPrijava";
            Text = "frmPrijava";
            Load += frmPrijava_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKorisnickoIme;
        private Label label2;
        private TextBox txtLozinka;
        private Button btnPrijava;
        private ErrorProvider err;
    }
}