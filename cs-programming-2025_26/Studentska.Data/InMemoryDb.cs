using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data
{
    public class InMemoryDb
    {
        public static List<Korisnik> tblKorisnici = GenerisiKorisnike();
        public static List<Korisnik> GenerisiKorisnike()
        {
            return new List<Korisnik>()
            {
                new Korisnik("Ime1", "Prezime1", "korisnik1",DateTime.Now,"korisnik1", true,null ),
                new Korisnik("Ime2", "Prezime2", "korisnik2",DateTime.Now,"korisnik2", true,null ),
                new Korisnik("Ime3", "Prezime3", "korisnik3",DateTime.Now,"korisnik3", true,null ),
            };
        }

    }
}
