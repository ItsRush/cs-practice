using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public int Id { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Lozinka { get; set; }

        public bool Aktivan {  get; set; }

        public Image? Slika { get; set; }
        public Korisnik(string ime = "", string prezime = "", string korisnickoIme = "", DateTime datumRodjenja =  default(DateTime), string lozinka = "", bool aktivan = true, Image ? slika = null)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            DatumRodjenja = datumRodjenja;
            Lozinka = lozinka;
            Aktivan = aktivan;
            Slika = slika;
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime} ({KorisnickoIme} - {Aktivan})";
        }
    }
}
