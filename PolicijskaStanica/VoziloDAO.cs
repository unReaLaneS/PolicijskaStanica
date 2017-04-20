using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaStanica
{
    public class VoziloDAO : IDaoCrud<Vozilo>
    {
        private MySqlConnection konekcija;
        public VoziloDAO(string user, string pass, string baza, string host = "localhost")
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
        public void create(Vozilo entity) {
            string komanda = "insert into vozila values(" + entity.Godiste + ",'" + entity.Marka + "','" + entity.Model + "','" + entity.Pogon + "','" + entity.Boja + "'," + entity.Godina_registracije + ",'" + entity.Drzava_registracije + "','" + entity.Registarske_tablice + "','" + entity.BrSasije + "'," + entity.Id + ");";
            MySqlCommand cmd = new MySqlCommand(komanda, konekcija);
            cmd.ExecuteNonQuery();

        }  
        // INSERT INTO
        //public Vozilo read(Vozilo entity) { }  // SELECT FROM WHERE ..
        //public Vozilo update(Vozilo entity) { } // UPDATE
        //public void delete(Vozilo entity) { }  // DELETE
    }
}
