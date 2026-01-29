using Studentska.Servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp
{
    public partial class frmPrijava : Form
    {
        KorisnikServis db = new KorisnikServis();
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var korisnickoIme = txtKorisnickoIme.Text;
                var lozinka = txtLozinka.Text;

                var korisnik = db.GetByKorisnickoIme(korisnickoIme);

                if (korisnik != null)
                {
                    if (korisnik.Lozinka == lozinka)
                    {
                        if (korisnik.Aktivan)
                        {
                            Hide();
                            MessageBox.Show($"unos validan");
                            frmGlavna glavna = new frmGlavna();
                            if(glavna.ShowDialog() == DialogResult.OK)
                                Show();
                        }
                        else
                        {
                            MessageBox.Show(Resursi.Get(Kljucevi.userNotActive));
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Resursi.Get(Kljucevi.passwordReq));
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(Resursi.Get(Kljucevi.invalidUserLogin));
                    return;
                }

            }
        }

        private bool ValidanUnos()
        {
            return Validator.ValidanUnos(txtKorisnickoIme, err, "Obavezno unijeti korisicko ime")
                && Validator.ValidanUnos(txtLozinka, err, "Obavezno unijeti lozinku");
        }

        public class Validator
        {
            public static bool ValidanUnos(TextBox textBox, ErrorProvider err, string poruka)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    err.SetError(textBox, poruka);
                    return false;
                }
                err.Clear();
                return true;
            }
        }

        public class Kljucevi
        {
            public const string invalidUserLogin = "invalid_user_login";
            public const string userNotActive = "user_not_active";
            public const string passwordReq = "password_required";
            public const string usernameReq = "username_required";
        }
        public class Resursi
        {
            static ResourceManager manager = new ResourceManager("Studentska.WinApp.Properties.Resources", typeof(frmPrijava).Assembly);

            public static string Get(string kljuc) {
                return manager.GetString(kljuc);
            }
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
