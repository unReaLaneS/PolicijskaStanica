using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaStanica
{
    public class PrijavaDAO: IDaoCrud<Prijava>
    {
        private MySqlConnection konekcija;

        public PrijavaDAO(string user, string pass, string baza, string host="localhost")
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
        public void create(Prijava entity) { }
        //public Prijava read(Prijava entity) { }
        //public Prijava update(Prijava entity) { }
        //public void delete(Prijava entity) { }
    }

}
