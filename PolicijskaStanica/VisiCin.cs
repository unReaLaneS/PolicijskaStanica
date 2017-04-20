using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaStanica
{
    public class VisiCin : Korisnik
    {

        public VisiCin(string ime, string prezime, string username, string password, string brojznacke) : base(ime, prezime, username, password, brojznacke) 
        {
        }
    }
}
