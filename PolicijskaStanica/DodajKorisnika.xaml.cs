using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PolicijskaStanica
{
    /// <summary>
    /// Interaction logic for DodajKorisnika.xaml
    /// </summary>
    public partial class DodajKorisnika : Window
    {
            private bool noviprvi = false;
            private bool novidrugi = false;
            private bool novitreci = false;
            private bool novicetvrti = false;
            private bool novipeti = false;
        public DodajKorisnika()
        {
            InitializeComponent();
           
          
        }

        public Korisnik noviKorisnik()
        {
            bool prvi = false;
            bool drugi = false;
            bool treci = false;
            bool cetvrti = false;
            bool peti = false;

            if (Ime.Text == "")
            {
                Ime.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
                prvi = true;
            }
            else
            {
                Ime.BorderBrush = Brushes.White;
                status.Content = "Čekanje unosa podataka...";
                status.Foreground = Brushes.White;
            }
            if (Prezime.Text == "")
            {
                Prezime.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
                drugi = true;
            }
            else
            { 
                Prezime.BorderBrush = Brushes.White;
                status.Content = "Čekanje unosa podataka...";
                status.Foreground = Brushes.White;
            }
            if (Username.Text == "")
            {
                Username.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
                treci = true;
            }
            else
            {
                Username.BorderBrush = Brushes.White;
                status.Content = "Čekanje unosa podataka...";
                status.Foreground = Brushes.White;
            }
            if (Sifra.Text == "")
            {
                Sifra.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
                cetvrti = true;
            }
            else
            {
                Sifra.BorderBrush = Brushes.White;
                status.Content = "Čekanje unosa podataka...";
                status.Foreground = Brushes.White;
            }
            if (ID.Text == "")
            {
                ID.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
                peti = true;
            }
            else
            {
                ID.BorderBrush = Brushes.White;
                status.Content = "Čekanje unosa podataka...";
                status.Foreground = Brushes.White;
            }
            if (!prvi && !drugi && !treci && !cetvrti && !peti)
            {
                if (Administrator.IsChecked == true)
                {
                    return new Administrator(Ime.Text, Prezime.Text, Username.Text, Sifra.Text, ID.Text);
                }
                else if (VisiCin.IsChecked == true)
                {
                    return new VisiCin(Ime.Text, Prezime.Text, Username.Text, Sifra.Text, ID.Text);
                }
                else return new NiziCin(Ime.Text, Prezime.Text, Username.Text, Sifra.Text, ID.Text);
            }
            else return null;

        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            DodajKorisnika1.Close();
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Korisnik novi = this.noviKorisnik();
            if (novi == null) return;
            System.Windows.MessageBox.Show("Dodali ste novog korisnika!");
            this.Close();
            KorisnikDAO unos = new KorisnikDAO("root", "", "arhiva", "localhost");
            unos.create(novi);
        }

        private void Prezime_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Prezime.Text == "")
            {
                Prezime.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
            }
            else
            {
                Prezime.BorderBrush = Brushes.White;
                novidrugi = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
            }
        }

        private void Ime_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Ime.Text == "")
            {
                Ime.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;

            }
            else
            {
                Ime.BorderBrush = Brushes.White;
                noviprvi = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
            }
        }

        private void Username_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "")
            {
                Username.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
            }
            else
            {
                Username.BorderBrush = Brushes.White;
                novitreci = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
            }
        }

        private void Sifra_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Sifra.Text == "")
            {
                Sifra.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
            }
            else
            {
                Sifra.BorderBrush = Brushes.White;
                novicetvrti = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
            }
        }

        private void ID_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ID.Text == "")
            {
                ID.BorderBrush = Brushes.Red;
                status.Content = "Zaboravili ste ispuniti neko od polja unosa!";
                status.Foreground = Brushes.Red;
            }
            else
            {
                ID.BorderBrush = Brushes.White;
                novipeti = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
            }
        }

        private void Ime_MouseLeave(object sender, MouseEventArgs e)
        {
                if (Ime.Text != "") noviprvi = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
        }

        private void Prezime_MouseLeave(object sender, MouseEventArgs e)
        {
                if (Prezime.Text != "") novidrugi = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
        }

        private void Username_MouseLeave(object sender, MouseEventArgs e)
        {
                if (Username.Text != "") novitreci = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
            
        }

        private void Sifra_MouseLeave(object sender, MouseEventArgs e)
        {
                if (Sifra.Text != "") novicetvrti = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
            
        }

        private void ID_MouseLeave(object sender, MouseEventArgs e)
        {
                if (ID.Text != "") novipeti = true;
                if (noviprvi == true && novidrugi == true && novitreci == true && novicetvrti == true && novipeti == true)
                {
                    status.Content = "Čekanje unosa podataka...";
                    status.Foreground = Brushes.White;
                }
            
        }

    }
}
