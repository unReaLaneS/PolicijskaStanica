using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for ListaOsumnjicenih.xaml
    /// </summary>
    public partial class ListaOsumnjicenih : Window
    {
        private MySqlConnection konekcija;
        private MySqlDataAdapter da;
        private DataSet ds;
        public ListaOsumnjicenih(string user = "root", string pass = "", string baza = "arhiva", string host = "localhost")
        {
            InitializeComponent();
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
            da = new MySqlDataAdapter("select * from lica", konekcija);
            ds = new DataSet();
            da.Fill(ds);
            dataGrid1.ItemsSource = ds.Tables[0].DefaultView;
        }


        private void dataGrid1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            string id = ((DataRowView)dataGrid1.SelectedItem).Row["LiceID"].ToString();
            prikazLica prikaz = new prikazLica();
            prikaz.Show();
            prikaz.TextBlock_id.Text = id;
            MySqlCommand cmd = new MySqlCommand("select * from lica where LiceID ='" + id + "'", konekcija);
            cmd.ExecuteNonQuery();
            MySqlDataReader r;
            r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    prikaz.TextBlock_id.Text = r.GetInt32(0).ToString();
                    prikaz.textblok_ime.Text = r.GetString(1);
                    prikaz.textblok_prezime.Text = r.GetString(2);
                    prikaz.textblok_srednjeime.Text = r.GetString(3);
                    prikaz.textblok_datumrodjenja.Text = r.GetString(4);
                    prikaz.textblok_mjesto.Text = r.GetString(5);
                    prikaz.textblok_pol.Text = r.GetString(6);
                    prikaz.textblok_tipgradje.Text = r.GetString(7);

                    prikaz.textblok_visina.Text = r.GetInt32(8).ToString();
                    prikaz.textblok_bojakose.Text = r.GetString(9);
                    prikaz.textblok_bojaociju.Text = r.GetString(10);
                    prikaz.textblok_oziljci.Text = r.GetString(11);
                    prikaz.textblok_tetovaze.Text = r.GetString(12);
                    r.Close();
                    break;
                }
            }
            else r.Close();

            MySqlCommand cmd1 = new MySqlCommand("select * from vozila where LiceID='" + id + "'", konekcija);
            cmd1.ExecuteNonQuery();
            r = cmd1.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    prikaz.textblok_godiste.Text = r.GetInt32(0).ToString();
                    prikaz.textblok_marka.Text = r.GetString(1);
                    prikaz.textblok_model.Text = r.GetString(2);
                    prikaz.textblok_pogon.Text = r.GetString(3);
                    prikaz.textblok_boja.Text = r.GetString(4);
                    prikaz.textblok_godina_reg.Text = r.GetInt32(5).ToString();
                    prikaz.textblok_drzava.Text = r.GetString(6);
                    prikaz.textblok_tablice.Text = r.GetString(7);
                    prikaz.textblok_br_sasije.Text = r.GetString(8);
                    r.Close();
                    break;
                }
            }
            else r.Close();
            MySqlCommand cmd2 = new MySqlCommand("select * from opsteinformacije where ID='" + id + "'", konekcija);
            cmd2.ExecuteNonQuery();
            r = cmd2.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    prikaz.TextBlock_id.Text = r.GetInt32(0).ToString();
                    prikaz.TextBlock_tip.Text = r.GetString(1);
                    prikaz.TextBlock_datum.Text = r.GetString(2);
                    prikaz.TextBlock_vrijeme.Text = r.GetString(3);
                    r.Close();
                    break;
                }
            }
            else r.Close();
            MySqlCommand cmd3 = new MySqlCommand("select * from adrese where LiceID='" + id + "'", konekcija);
            cmd3.ExecuteNonQuery();
            r = cmd3.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    prikaz.textblok_kucna.Text = r.GetString(1);
                    prikaz.textblok_posao.Text = r.GetString(2);
                    r.Close();
                    break;

                }
            }
            else r.Close();
            MySqlCommand cmd4 = new MySqlCommand("select * from telefonskibrojevi where LiceID='" + id + "'", konekcija);
            cmd4.ExecuteNonQuery();
            r = cmd4.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    prikaz.textblok_kucni.Text = r.GetString(1);
                    prikaz.textblok_mobilni.Text = r.GetString(2);
                    prikaz.textblok_fax.Text = r.GetString(3);
                    r.Close();
                    break;
                }
            }
            else r.Close();
            MySqlCommand cmd5 = new MySqlCommand("select * from idbrojevi where LiceID='" + id + "'", konekcija);
            cmd5.ExecuteNonQuery();
            r = cmd5.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    prikaz.textblok_licna.Text = r.GetString(1);
                    prikaz.textblok_pasos.Text = r.GetString(2);
                    prikaz.textblok_vozacka.Text = r.GetString(3);
                    prikaz.textblok_jmbg.Text = r.GetString(4);
                    r.Close();
                    break;
                }
            }
            else r.Close();
            MySqlCommand cmd6 = new MySqlCommand("select * from biljeske where LiceID='" + id + "'", konekcija);
            cmd6.ExecuteNonQuery();
            r = cmd6.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    prikaz.textblok_biljeske.Text = r.GetString(1);
                    r.Close();
                    break;

                }
            }
            else r.Close();

            MySqlCommand cmd7 = new MySqlCommand("SELECT * FROM slike WHERE LiceID = '" + id + "'", konekcija);
            cmd7.ExecuteNonQuery();
            r = cmd7.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    byte[] data = (byte[])r[1];
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
                    {
                        var imageSource = new BitmapImage();
                        imageSource.BeginInit();
                        imageSource.StreamSource = ms;
                        imageSource.CacheOption = BitmapCacheOption.OnLoad;
                        imageSource.EndInit();


                        prikaz.image_slika.Source = imageSource;
                    }
                    r.Close();
                    break;
                }
                r.Close();
            }
            else r.Close();
        }

        private void button_pretraga_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (textBox_pretraga.Text != "" && int.TryParse(textBox_pretraga.Text,out id)== true)
            {
                da = new MySqlDataAdapter("select * from lica where liceID=" + textBox_pretraga.Text + "", konekcija);
                ds = new DataSet();
                da.Fill(ds);
                dataGrid1.ItemsSource = ds.Tables[0].DefaultView;
            }

        //    MySqlCommand cmd = new MySqlCommand("select * from opsteinformacije o, lica l,vozila v, adrese a ,telefonskibrojevi t, biljeske b, idbrojevi i where o.ID = l.LiceID and l.LiceID = v.LiceID and v.LiceID = a.LiceID and a.LiceID = t.LiceID and t.LiceID = i.LiceID and i.LiceID = b.LiceID and l.LiceID ="+int.Parse(textBox_pretraga.Text)+"",konekcija);
        //    cmd.ExecuteNonQuery();
        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    prikazLica prikaz = new prikazLica();
        //    prikaz.Show();
        //    while (reader.Read())
        //    {
        //        prikaz.TextBlock_tip.Text = reader.GetString(1);
        //        prikaz.TextBlock_id.Text = reader.GetString(0);
        //        prikaz.TextBlock_datum.Text = reader.GetString(2);
        //        prikaz.TextBlock_vrijeme.Text = reader.GetString(3);
        //        prikaz.textblok_ime.Text = reader.GetString(5);
        //        prikaz.textblok_prezime.Text = reader.GetString(6);
        //        prikaz.textblok_srednjeime.Text = reader.GetString(7);
        //        prikaz.textblok_datumrodjenja.Text = reader.GetString(8);
        //        prikaz.textblok_mjesto.Text = reader.GetString(9);
        //        prikaz.textblok_pol.Text = reader.GetString(10);
        //        prikaz.textblok_tipgradje.Text = reader.GetString(11);

        //        prikaz.textblok_visina.Text = reader.GetInt32(12).ToString();
        //        prikaz.textblok_bojakose.Text = reader.GetString(13);
        //        prikaz.textblok_bojaociju.Text = reader.GetString(14);
        //        prikaz.textblok_oziljci.Text = reader.GetString(15);
        //        prikaz.textblok_tetovaze.Text = reader.GetString(16);

        //        prikaz.textblok_godiste.Text = reader.GetInt32(17).ToString();
        //        prikaz.textblok_marka.Text = reader.GetString(18);
        //        prikaz.textblok_model.Text = reader.GetString(19);
        //        prikaz.textblok_pogon.Text = reader.GetString(20);
        //        prikaz.textblok_boja.Text = reader.GetString(21);
        //        prikaz.textblok_godina_reg.Text = reader.GetInt32(22).ToString();
        //        prikaz.textblok_drzava.Text = reader.GetString(23);
        //        prikaz.textblok_tablice.Text = reader.GetString(24);
        //        prikaz.textblok_br_sasije.Text = reader.GetString(25);

        //        prikaz.textblok_kucna.Text = reader.GetString(28);
        //        prikaz.textblok_posao.Text = reader.GetString(29);

        //        prikaz.textblok_kucni.Text = reader.GetString(32);
        //        prikaz.textblok_mobilni.Text = reader.GetString(33);
        //        prikaz.textblok_fax.Text = reader.GetString(34);
        //        prikaz.textblok_biljeske.Text = reader.GetString(35);

        //        prikaz.textblok_licna.Text = reader.GetString(38);
        //        prikaz.textblok_pasos.Text = reader.GetString(39);
        //        prikaz.textblok_vozacka.Text = reader.GetString(40);
        //        prikaz.textblok_jmbg.Text = reader.GetString(41);
        //        reader.Close();
        //        MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM slike WHERE LiceID = '" + int.Parse(textBox_pretraga.Text) + "'", konekcija);
        //        cmd1.ExecuteNonQuery();
        //        reader = cmd1.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            if (reader.HasRows)
        //            {
        //                byte[] data = (byte[])reader[1];

        //                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
        //                {
        //                    var imageSource = new BitmapImage();
        //                    imageSource.BeginInit();
        //                    imageSource.StreamSource = ms;
        //                    imageSource.CacheOption = BitmapCacheOption.OnLoad;
        //                    imageSource.EndInit();


        //                    prikaz.image_slika.Source = imageSource;
        //                    reader.Close();
        //                    break;
        //                }
        //            }
        //            else prikaz.image_slika.ToolTip = "Nemaaaaaaaaa";
        //            reader.Close();
        //            break;
                    
        //        }
               

        //    }
            


        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_pretraga.Text == "" )
            {
                da = new MySqlDataAdapter("select * from lica ", konekcija);
                ds = new DataSet();
                da.Fill(ds);
                dataGrid1.ItemsSource = ds.Tables[0].DefaultView;
            }
        }



    }
}
