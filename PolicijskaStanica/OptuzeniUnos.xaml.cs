using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace PolicijskaStanica
{
    /// <summary>
    /// Interaction logic for OptuzeniUnos.xaml
    /// </summary>
    public partial class OptuzeniUnos : Window
    {

        public OptuzeniUnos()
        {
            InitializeComponent();


        }
        bool validacija()
        {
            bool ispravno = false;

            if (textBox_adresa_kucna.Text == "")
            {
                textBox_adresa_kucna.BorderThickness = new Thickness(2);
                textBox_adresa_kucna.BorderBrush = Brushes.Red;
                ispravno = false;
                
            }
            else
            {
                textBox_adresa_kucna.BorderThickness = new Thickness(1);
                textBox_adresa_kucna.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_adresa_posao.Text == "")
            {
                TextBox_adresa_posao.BorderThickness = new Thickness(2);
                TextBox_adresa_posao.BorderBrush = Brushes.Red;
                ispravno = false;
               
            }
            else
            {
                TextBox_adresa_posao.BorderThickness = new Thickness(1);
                TextBox_adresa_posao.BorderBrush = Brushes.White;
                ispravno = true;
               
            }
            if (TextBox_ime.Text == "")
            {
                TextBox_ime.BorderThickness = new Thickness(2);
                TextBox_ime.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_ime.BorderThickness = new Thickness(1);
                TextBox_ime.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_prezime.Text == "")
            {
                TextBox_prezime.BorderThickness = new Thickness(2);
                TextBox_prezime.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_prezime.BorderThickness = new Thickness(1);
                TextBox_prezime.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_srednje_ime.Text == "")
            {
                TextBox_srednje_ime.BorderThickness = new Thickness(2);
                TextBox_srednje_ime.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_srednje_ime.BorderThickness = new Thickness(1);
                TextBox_srednje_ime.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (DatePicker_datum_rođenja.Text == "" || DatePicker_datum_rođenja == null)
            {
                //check for null
                if (DatePicker_datum_rođenja.SelectedDate == null)
                {
                    ispravno = false;
                    
                }



                else if (DatePicker_datum_rođenja.SelectedDate.Value.Year.Equals(0001))
                    ispravno = false;
                DatePicker_datum_rođenja.BorderThickness = new Thickness(2);
                DatePicker_datum_rođenja.BorderBrush = Brushes.Red;
            }
            else
            {
                DatePicker_datum_rođenja.BorderThickness = new Thickness(1);
                DatePicker_datum_rođenja.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_mjesto_rodjenja.Text == "")
            {
                TextBox_mjesto_rodjenja.BorderThickness = new Thickness(2);
                TextBox_mjesto_rodjenja.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_mjesto_rodjenja.BorderThickness = new Thickness(1);
                TextBox_mjesto_rodjenja.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (ComboBox_pol.SelectedItem == null)
            {
                ComboBox_pol.BorderThickness = new Thickness(2);
                ComboBox_pol.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                ComboBox_pol.BorderThickness = new Thickness(1);
                ComboBox_pol.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_tip_gradje.Text == "")
            {
                TextBox_tip_gradje.BorderThickness = new Thickness(2);
                TextBox_tip_gradje.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_tip_gradje.BorderThickness = new Thickness(1);
                TextBox_tip_gradje.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_visina.Text == "" || int.Parse(TextBox_visina.Text) < 100 && int.Parse(TextBox_visina.Text) > 250)
            {
                TextBox_visina.BorderThickness = new Thickness(2);
                TextBox_visina.BorderBrush = Brushes.Red;
                TextBox_visina.ToolTip = "Visina mora biti izmedju 100 i 250 cm";
                ispravno = false;
            }
            else
            {
                TextBox_visina.BorderThickness = new Thickness(1);
                TextBox_visina.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_boja_kose.Text == "")
            {
                TextBox_boja_kose.BorderThickness = new Thickness(2);
                TextBox_boja_kose.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_boja_kose.BorderThickness = new Thickness(1);
                TextBox_boja_kose.BorderBrush = Brushes.White;
                ispravno = true;
            }

            if (TextBox_boja_ociju.Text == "")
            {
                TextBox_boja_ociju.BorderThickness = new Thickness(2);
                TextBox_boja_ociju.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_boja_ociju.BorderThickness = new Thickness(1);
                TextBox_boja_ociju.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_oziljci.Text == "")
            {
                TextBox_oziljci.BorderThickness = new Thickness(2);
                TextBox_oziljci.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_oziljci.BorderThickness = new Thickness(1);
                TextBox_oziljci.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_tetovaze.Text == "")
            {
                TextBox_tetovaze.BorderThickness = new Thickness(2);
                TextBox_tetovaze.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_tetovaze.BorderThickness = new Thickness(1);
                TextBox_tetovaze.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_vrijeme.Text == "")
            {
                TextBox_vrijeme.BorderThickness = new Thickness(2);
                TextBox_vrijeme.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_vrijeme.BorderThickness = new Thickness(1);
                TextBox_vrijeme.BorderBrush = Brushes.White;
                ispravno = true;
            }
            int a;
            if (int.TryParse(TextBox_id.Text, out a) == false)
            {
                TextBox_id.BorderThickness = new Thickness(2);
                TextBox_id.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_id.BorderThickness = new Thickness(1);
                TextBox_id.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (DatePicker_datum.Text == "" || DatePicker_datum == null)
            {
                if (DatePicker_datum.SelectedDate == null)
                    ispravno = false;

                else if (DatePicker_datum.SelectedDate.Value.Year.Equals(0001))
                    ispravno = false;
                DatePicker_datum.BorderThickness = new Thickness(2);
                DatePicker_datum.BorderBrush = Brushes.Red;
               
                
            }
            else
            {
                DatePicker_datum.BorderThickness = new Thickness(1);
                DatePicker_datum.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_godiste.Text == "")
            {
                TextBox_godiste.BorderThickness = new Thickness(2);
                TextBox_godiste.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_godiste.BorderThickness = new Thickness(1);
                TextBox_godiste.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_marka.Text == "")
            {
                TextBox_marka.BorderThickness = new Thickness(2);
                TextBox_marka.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_marka.BorderThickness = new Thickness(1);
                TextBox_marka.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_model.Text == "")
            {
                TextBox_model.BorderThickness = new Thickness(2);
                TextBox_model.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_model.BorderThickness = new Thickness(1);
                TextBox_model.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_pogon.Text == "")
            {
                TextBox_pogon.BorderThickness = new Thickness(2);
                TextBox_pogon.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_pogon.BorderThickness = new Thickness(1);
                TextBox_pogon.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_boja.Text == "")
            {
                TextBox_boja.BorderThickness = new Thickness(2);
                TextBox_boja.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_boja.BorderThickness = new Thickness(1);
                TextBox_boja.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_god_reg.Text == "" || int.Parse(TextBox_god_reg.Text) < 1940)
            {
                TextBox_god_reg.BorderThickness = new Thickness(2);
                TextBox_god_reg.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_god_reg.BorderThickness = new Thickness(1);
                TextBox_god_reg.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_drz_reg.Text == "")
            {
                TextBox_drz_reg.BorderThickness = new Thickness(2);
                TextBox_drz_reg.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_drz_reg.BorderThickness = new Thickness(1);
                TextBox_drz_reg.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_tablice.Text == "")
            {
                TextBox_tablice.BorderThickness = new Thickness(2);
                TextBox_tablice.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_tablice.BorderThickness = new Thickness(1);
                TextBox_tablice.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_br_sasije.Text == "")
            {
                TextBox_br_sasije.BorderThickness = new Thickness(2);
                TextBox_br_sasije.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_br_sasije.BorderThickness = new Thickness(1);
                TextBox_br_sasije.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_kucni_tel.Text == "")
            {
                TextBox_kucni_tel.BorderThickness = new Thickness(2);
                TextBox_kucni_tel.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_kucni_tel.BorderThickness = new Thickness(1);
                TextBox_kucni_tel.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_mobilni.Text == "")
            {
                TextBox_mobilni.BorderThickness = new Thickness(2);
                TextBox_mobilni.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_mobilni.BorderThickness = new Thickness(1);
                TextBox_mobilni.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_fax.Text == "")
            {
                TextBox_fax.BorderThickness = new Thickness(2);
                TextBox_fax.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_fax.BorderThickness = new Thickness(1);
                TextBox_fax.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (image_slika.Source == null)
            {
                groupbox_slika.BorderThickness = new Thickness(2);
                groupbox_slika.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                groupbox_slika.BorderThickness = new Thickness(1);
                groupbox_slika.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_br_licne.Text == "")
            {
                TextBox_br_licne.BorderThickness = new Thickness(2);
                TextBox_br_licne.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_br_licne.BorderThickness = new Thickness(1);
                TextBox_br_licne.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_br_pasosa.Text == "")
            {
                TextBox_br_pasosa.BorderThickness = new Thickness(2);
                TextBox_br_pasosa.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_br_pasosa.BorderThickness = new Thickness(1);
                TextBox_br_pasosa.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_br_vozacke.Text == "")
            {
                TextBox_br_vozacke.BorderThickness = new Thickness(2);
                TextBox_br_vozacke.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_br_vozacke.BorderThickness = new Thickness(1);
                TextBox_br_vozacke.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_maticni_br.Text == "")
            {
                TextBox_maticni_br.BorderThickness = new Thickness(2);
                TextBox_maticni_br.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_maticni_br.BorderThickness = new Thickness(1);
                TextBox_maticni_br.BorderBrush = Brushes.White;
                ispravno = true;
            }
            if (TextBox_biljeske.Text == "")
            {
                TextBox_biljeske.BorderThickness = new Thickness(2);
                TextBox_biljeske.BorderBrush = Brushes.Red;
                ispravno = false;
            }
            else
            {
                TextBox_biljeske.BorderThickness = new Thickness(1);
                TextBox_biljeske.BorderBrush = Brushes.White;
                ispravno = true;
            }
           
            return ispravno;
        }


        Optuzeni napravi_optuzenog()
        {
            Optuzeni o = new Optuzeni();
            o.Adresa_kuca = textBox_adresa_kucna.Text;
            o.Adresa_posao = TextBox_adresa_posao.Text;
            o.Biljeske = TextBox_biljeske.Text;
            o.BojaKose = TextBox_boja_kose.Text;
            o.BojaOciju = TextBox_boja_ociju.Text;
            o.BrLicne = TextBox_br_licne.Text;
            o.BrPasosa = TextBox_br_pasosa.Text;
            o.BrVozacke = TextBox_br_vozacke.Text;
            o.Datum_rodjenja = DatePicker_datum_rođenja.SelectedDate.Value.Date;
            o.Datum_unosa = DatePicker_datum.SelectedDate.Value.Date;
            o.Fax_broj = TextBox_fax.Text;
            o.Id = int.Parse(TextBox_id.Text);
            o.Ime = TextBox_ime.Text;
            o.Kucni_broj = TextBox_kucni_tel.Text;
            o.Maticni_broj = TextBox_maticni_br.Text;
            o.Mjesto_rodjenja = TextBox_mjesto_rodjenja.Text;
            o.Mobilni_broj = TextBox_mobilni.Text;
            o.Oziljci = TextBox_oziljci.Text;
            o.Pol = ComboBox_pol.Text;
            o.Prezime = TextBox_prezime.Text;
            o.Slika = image_slika.Source;
            o.SrednjeIme = TextBox_srednje_ime.Text;
            o.Tetovaze = TextBox_tetovaze.Text;
            o.Tip = ComboBox_tip.Text;
            o.TipGradje = TextBox_tip_gradje.Text;
            o.Visina = int.Parse(TextBox_visina.Text);
            o.Vrijeme_unosa = TextBox_vrijeme.Text;
            o.Staza = staza;

            return o;




        }
        Vozilo napravi_vozilo()
        {
            Vozilo v = new Vozilo();
            v.Boja = TextBox_boja.Text;
            v.BrSasije = TextBox_br_sasije.Text;
            v.Drzava_registracije = TextBox_drz_reg.Text;
            v.Godiste = int.Parse(TextBox_godiste.Text);
            v.Marka = TextBox_marka.Text;
            v.Model = TextBox_model.Text;
            v.Pogon = TextBox_pogon.Text;
            v.Registarske_tablice = TextBox_tablice.Text;
            v.Godina_registracije = int.Parse(TextBox_god_reg.Text);
            v.Id = int.Parse(TextBox_id.Text);

            return v;



        }
        private void Button_uredu_Click(object sender, RoutedEventArgs e)
        {


            if (validacija())
            {
                Optuzeni unos = napravi_optuzenog();
                OptuzeniDAO optuzeni = new OptuzeniDAO("root", "", "arhiva", "localhost");
                optuzeni.create(unos);
                VoziloDAO vozilo = new VoziloDAO("root", "", "arhiva", "localhost");
                Vozilo v = napravi_vozilo();
                vozilo.create(v);
            }
            else MessageBox.Show("Povjerite da li ste ispravno ispunili polja.");
        }

        string staza;
        private void Button_dodaj_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Title = "Choose Image File";
            op.InitialDirectory =
                         Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            op.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            op.Multiselect = false;
            if (op.ShowDialog() == true)
            {
                image_slika.Source = new BitmapImage(new Uri(op.FileName));
            }
            // store file path in some field or textbox...
            staza = op.FileName;

        }


    }
}
