using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp
{
    public partial class frmXO : Form
    {
        public int Brojac { get; set; }
        private Igrac playerX;
        private Igrac playerO;
        private bool krajIgre = false;
        public frmXO()
        {
            InitializeComponent();
            GenerisiIgrace();
            UcitajPobjede();
        }

        private void UcitajPobjede()
        {
            label3.Text = $"{playerX.Pobjede}";
            label4.Text = $"{playerO.Pobjede}";

        }

        private void GenerisiIgrace()
        {
            playerX = new Igrac("X");
            playerO = new Igrac("O");
        }

        private void frmXO_Load(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        public void RegistrujPotez(object sender)
        {
            Button button = sender as Button;
            if (button != null && button.Text == "")
            {
                if (Brojac % 2 == 0)
                {
                    button.Text = "X";
                    button.BackColor = Color.LightGray;
                }
                else
                {
                    button.Text = "O";

                }
                Brojac++;
                if (KrajIgre())
                {

                    var pobjednikSimbol = button.Text;

                    if (pobjednikSimbol == playerX.Simbol)
                    {
                        playerX.Pobjede++;
                    }
                    else
                    {
                        playerO.Pobjede++;
                    }
                    UcitajPobjede();
                    OnemoguciOdabir();
                    MessageBox.Show($"Winner: {button.Text}");
                }
            }
        }

        public void IgrajPonovo()
        {
            Brojac = 0;

            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach(var button in buttons)
            {
                button.Text = "";
                button.BackColor = Color.White;
                button.Enabled = true;
            }
        }
        public void OnemoguciOdabir()
        {
            Brojac = 0;

            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }

        private bool KrajIgre()
        {
            return ProvjeriDijagonale() || ProvjeriRedove() || ProvjeriKolone();
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) || ProvjeriPobjedu(button2, button5, button8) || ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) || ProvjeriPobjedu(button4, button5, button6) || ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) || ProvjeriPobjedu(button3, button5, button7);
        }

        private bool ProvjeriPobjedu(Button button1, Button button2, Button button3)
        {
            var pobjeda = button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text;
            if (pobjeda)
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.LightGreen;
                return pobjeda;
            }
            return false;
        }

        public class Igrac
        {
            public string Simbol { get; set; }
            public int Pobjede { get; set; }

            public Igrac(string simbol)
            {
                Simbol = simbol;
                Pobjede = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IgrajPonovo();
        }
    }
}
