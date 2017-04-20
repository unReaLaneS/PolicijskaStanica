using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PolicijskaStanica
{
    /// <summary>
    /// Interaction logic for ListaKorisnika.xaml
    /// </summary>
    public partial class ListaKorisnika : Window
    {
        private MySqlConnection konekcija;
        private MySqlDataAdapter da;
        private DataSet ds;
       
        public ListaKorisnika(string user="root", string pass="", string baza="arhiva", string host = "localhost")
        {
            InitializeComponent();
            string connectionString = "server="+ host +";user=" + user + ";pwd=" + pass + ";database=" + baza;
            konekcija = new MySqlConnection(connectionString);
            try
            {
                konekcija.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
            da = new MySqlDataAdapter("select * from korisnici",konekcija);
            ds = new DataSet();
            da.Fill(ds);
            dataGrid1.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void button_nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       
        
    }
}
