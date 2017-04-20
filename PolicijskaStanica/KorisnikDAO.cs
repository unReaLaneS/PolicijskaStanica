using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaStanica
{
   
    class KorisnikDAO : IDaoCrud<Korisnik>
    {
        private MySqlConnection konekcija;

        public KorisnikDAO(string user, string pass, string baza, string host="localhost")
        {
            string connectionString="server=" + host + ";user="  + user + ";pwd="+ pass + ";database = " + baza;
            konekcija = new MySqlConnection(connectionString);
            try
            {
                konekcija.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void create(Korisnik entity) 
        {

           MySqlCommand cmd = new MySqlCommand("insert into korisnici values("+entity.BrojZnacke+",'"+entity.Ime+"','"+entity.Prezime+"','"+entity.korisnickoIme+"','"+entity.Sifra+"');",konekcija);
           cmd.ExecuteNonQuery();
        }
        //public Korisnik read(Korisnik entity) { }
        //public Korisnik update(Korisnik entity) { }
        //public void delete(Korisnik entity) { }
    }

}
