using Studentska.Servis;
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
    public partial class frmKorisnikPretraga : Form
    {
        KorisnikServis db = new KorisnikServis();
        public frmKorisnikPretraga()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKorisnikPretraga_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UcitajPodatke()
        {
            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = db.GetAll();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            if (new frmKorisniciDodaj().ShowDialog() == DialogResult.OK) 
            {
                UcitajPodatke();
            }
        }
    }
}
