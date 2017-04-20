using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PolicijskaStanica
{
    
    public partial class LoginPage : Window
    {
        private MySqlConnection konekcija;
        public LoginPage()
        {
            InitializeComponent();
            konekcija = new MySqlConnection("server = localhost; user = root; pwd= " + " ; database = arhiva;");
            try
            {
                konekcija.Open();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //Event koji se desava kad korisnik klikne na dugme "Prijavi" 
        //ovde se provjerava postoji li korisnik u bazi i ako odgovaraju uneseni podaci odobrava mu se pristup,u suprotnom se odbija uz obrazlozenje
        private void dugme_prijava_Click(object sender, RoutedEventArgs e)
        {
            string username = textbox_username.Text;
            string password = password_box.Password;
            MySqlCommand komanda = new MySqlCommand("select * from korisnici", konekcija);
            MySqlDataReader r = komanda.ExecuteReader();
            bool otvori=false;
            bool postoji = false;
            for (; ; )
            {
                while (r.Read())
                {
                    username = textbox_username.Text;
                    password = password_box.Password;
                    string usr = r.GetString("username");
                    string pass = r.GetString("sifra");
                    if ((username == usr && password != pass) || (username != usr && password == pass))
                    {
                        System.Windows.MessageBox.Show("Pogresan unos username ili sifre!");
                       /* MediaElement media1 = new MediaElement();
                        media1.LoadedBehavior = MediaState.Manual;
                        media1.Source = new Uri(@"C:\Users\Anes\Desktop\You-shall-not-pass!.mp3");
                        login_page.Children.Add(media1);
                        media1.Play();*/
                        postoji = true;
                    }
                    else if (username == usr && password == pass)
                    {
                        postoji = true;
                        otvori = true;
                        break;
                    }
                }
                if (!postoji)
                {
                    System.Windows.MessageBox.Show("Ne postoji korisnik sa takvim podacima!");
                    r.Close();
                    break;
                }
                else if (otvori)
                {
                   
                    r.Close();
                    break;
                }
                else 
                {
                    r.Close();
                    break;
                }
            }
            if (otvori)
                {
                    OsnovaAplikacije app = new OsnovaAplikacije();
                    app.Show();
                    loginPage.Close();
                }
        }


    }
}
