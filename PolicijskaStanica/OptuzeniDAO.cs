using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaStanica
{
    class OptuzeniDAO : IDaoCrud<Optuzeni>
    {
        private MySqlConnection konekcija;

        public OptuzeniDAO(string user, string pass, string baza, string host = "localhost")
        {

            string connectionString = "server=" + host + ";user=" + user + ";pwd=" + pass + ";database=" + baza;
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
        public void create(Optuzeni entity)
        {
            string komanda = "insert into opsteinformacije values(" + entity.Id + ",'" + entity.Tip + "','" + entity.Datum_unosa.ToString("dd/MM/yyyy") + "','" + entity.Vrijeme_unosa + "');";
            MySqlCommand cmd = new MySqlCommand(komanda, konekcija);
            cmd.ExecuteNonQuery();
            string komanda1 = "insert into lica values (" + entity.Id + ",'" + entity.Ime + "','" + entity.Prezime + "','" + entity.SrednjeIme + "','" + entity.Datum_unosa.ToString("dd/MM/yyyy") + "','" + entity.Mjesto_rodjenja + "','" + entity.Pol + "','" + entity.TipGradje + "'," + entity.Visina + ",'" + entity.BojaKose + "','" + entity.BojaOciju + "','" + entity.Oziljci + "','" + entity.Tetovaze + "');";
            MySqlCommand cmd1 = new MySqlCommand(komanda1, konekcija);
            cmd1.ExecuteNonQuery();
            string komanda2 = "insert into adrese(kucna,posao,LiceID) values ('" + entity.Adresa_kuca + "','" + entity.Adresa_posao + "'," + entity.Id + ");";
            MySqlCommand cmd2 = new MySqlCommand(komanda2, konekcija);
            cmd2.ExecuteNonQuery();
            string komanda3 = "insert into biljeske values('" + entity.Biljeske + "'," + entity.Id + ");";
            MySqlCommand cmd3 = new MySqlCommand(komanda3, konekcija);
            cmd3.ExecuteNonQuery();
            string komanda4 = "insert into idbrojevi(brLicneKarte,brPasosa,brVozacke,jmbg,LiceID) values('" + entity.BrLicne + "','" + entity.BrPasosa + "','" + entity.BrVozacke + "','" + entity.Maticni_broj + "'," + entity.Id + ");";
            MySqlCommand cmd4 = new MySqlCommand(komanda4, konekcija);
            cmd4.ExecuteNonQuery();
            string komanda5 = "insert into telefonskibrojevi(kucni,mobilni,fax,LiceID) values('" + entity.Kucni_broj + "','" + entity.Mobilni_broj + "','" + entity.Fax_broj + "'," + entity.Id + ");";
            MySqlCommand cmd5 = new MySqlCommand(komanda5, konekcija);
            cmd5.ExecuteNonQuery();

            string komanda6 = "INSERT INTO slike (LiceID,slika) VALUES ('"+entity.Id+"',@file)";
            MySqlCommand cmd6 = new MySqlCommand(komanda6, konekcija);
            cmd6.Parameters.AddWithValue("@file", File.ReadAllBytes(entity.Staza));
            cmd6.ExecuteNonQuery();









        }  // INSERT INTO
        //public Optuzeni read(Optuzeni entity) { }  // SELECT FROM WHERE ..
        //public Optuzeni update(Optuzeni entity) { } // UPDATE
        //public void delete(Optuzeni entity) { }  // DELETE
    }
}
