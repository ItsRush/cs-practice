using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp
{
    public partial class frmDogadjaji : Form
    {
        delegate void PotpisMetode(string text);

        event PotpisMetode Obavijesti;
        public frmDogadjaji()
        {
            InitializeComponent();
        }

        const string crt = "-----------------------------------------------------------\r\n";
        private void PosaljiSadrzaj(string sadrzaj)
        {
            txtIspis.Text += Environment.NewLine + crt + Environment.NewLine;

            for (int i = 0; i < sadrzaj.Length; i++)
            {
                txtIspis.Text += sadrzaj[i];
                Task.Delay(70).Wait();
            }
        }

        void PosaljiEmail(string text)
        {
            PosaljiSadrzaj("Email: " + text);
        }

        void PosaljiSMS(string text)
        {
            PosaljiSadrzaj("SMS: " + text);
        }
        void PosaljiNaDLWMS(string text)
        {
            PosaljiSadrzaj("DLWMS: " + text);
        }

        private void PretplatiMetodu(CheckBox checkBox, PotpisMetode metoda)
        {
            if (checkBox.Checked)
                Obavijesti += metoda;
            else
                Obavijesti -= metoda;
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(cbEmail, PosaljiEmail);
        }

        private void cbSMS_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(cbSMS, PosaljiSMS);
        }

        private void cbDlwms_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(cbDlwms, PosaljiNaDLWMS);
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            Obavijesti(txtObavijest.Text); //uzmi iz textBoxa Text i posalji ga metodama
        }
    }
}
