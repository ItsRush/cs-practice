namespace Studentska.WinApp
{
    partial class frmDogadjaji
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
            txtObavijest = new TextBox();
            txtIspis = new TextBox();
            label1 = new Label();
            cbEmail = new CheckBox();
            btnPosalji = new Button();
            cbSMS = new CheckBox();
            cbDlwms = new CheckBox();
            SuspendLayout();
            // 
            // txtObavijest
            // 
            txtObavijest.Location = new Point(29, 58);
            txtObavijest.Multiline = true;
            txtObavijest.Name = "txtObavijest";
            txtObavijest.Size = new Size(485, 163);
            txtObavijest.TabIndex = 0;
            // 
            // txtIspis
            // 
            txtIspis.Location = new Point(29, 239);
            txtIspis.Multiline = true;
            txtIspis.Name = "txtIspis";
            txtIspis.Size = new Size(741, 169);
            txtIspis.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Sadržaj obavijesti:";
            // 
            // cbEmail
            // 
            cbEmail.AutoSize = true;
            cbEmail.Location = new Point(541, 60);
            cbEmail.Name = "cbEmail";
            cbEmail.Size = new Size(55, 19);
            cbEmail.TabIndex = 2;
            cbEmail.Text = "Email";
            cbEmail.UseVisualStyleBackColor = true;
            cbEmail.CheckedChanged += cbEmail_CheckedChanged;
            // 
            // btnPosalji
            // 
            btnPosalji.Location = new Point(541, 185);
            btnPosalji.Name = "btnPosalji";
            btnPosalji.Size = new Size(166, 36);
            btnPosalji.TabIndex = 3;
            btnPosalji.Text = "Posalji obavijest";
            btnPosalji.UseVisualStyleBackColor = true;
            btnPosalji.Click += btnPosalji_Click;
            // 
            // cbSMS
            // 
            cbSMS.AutoSize = true;
            cbSMS.Location = new Point(541, 85);
            cbSMS.Name = "cbSMS";
            cbSMS.Size = new Size(49, 19);
            cbSMS.TabIndex = 2;
            cbSMS.Text = "SMS";
            cbSMS.UseVisualStyleBackColor = true;
            cbSMS.CheckedChanged += cbSMS_CheckedChanged;
            // 
            // cbDlwms
            // 
            cbDlwms.AutoSize = true;
            cbDlwms.Location = new Point(541, 110);
            cbDlwms.Name = "cbDlwms";
            cbDlwms.Size = new Size(67, 19);
            cbDlwms.TabIndex = 2;
            cbDlwms.Text = "DLWMS";
            cbDlwms.UseVisualStyleBackColor = true;
            cbDlwms.CheckedChanged += cbDlwms_CheckedChanged;
            // 
            // frmDogadjaji
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPosalji);
            Controls.Add(cbDlwms);
            Controls.Add(cbSMS);
            Controls.Add(cbEmail);
            Controls.Add(label1);
            Controls.Add(txtIspis);
            Controls.Add(txtObavijest);
            Name = "frmDogadjaji";
            Text = "frmDogadjaji";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObavijest;
        private TextBox txtIspis;
        private Label label1;
        private CheckBox cbEmail;
        private Button btnPosalji;
        private CheckBox cbSMS;
        private CheckBox cbDlwms;
    }
}