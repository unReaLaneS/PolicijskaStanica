using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaStanica
{
    public abstract class Korisnik
    {
        private string Username;

        public string korisnickoIme
        {
            get { return Username; }
            set { Username = value; }
        }
        private string Password;

        public string Sifra
        {
            get { return Password; }
            set { Password = value; }
        }
        private string Name;

        public string Ime
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Lastname;

        public string Prezime
        {
            get { return Lastname; }
            set { Lastname = value; }
        }
        private string brojZnacke;

        public string BrojZnacke
        {
            get { return brojZnacke; }
            set { brojZnacke = value; }
        }


        public Korisnik(string ime, string prezime, string username, string password, string brojznacke)
        {
            // TODO: Complete member initialization
            this.Username = username;
            this.Password = password;
            this.Name = ime;
            this.Lastname = prezime;
            this.brojZnacke = brojznacke;
        }


    }
}
