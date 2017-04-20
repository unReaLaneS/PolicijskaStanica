using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PolicijskaStanica
{
    /// <summary>
    /// Interaction logic for OsnovaAplikacije.xaml
    /// </summary>
    public partial class OsnovaAplikacije : Window
    {
        public OsnovaAplikacije()
        {
            InitializeComponent();
           /* MediaElement Pjesma = new MediaElement();
            Pjesma.Source = new Uri("C:/Users/Anes/Desktop/Projekat OOAD/PolicijskaStanica/PolicijskaStanica/PolicijskaStanica/Slike/The Chiffons - He´s So Fine-[www_flvto_com].mp3",UriKind.RelativeOrAbsolute);
            Pjesma.LoadedBehavior = MediaState.Manual;
            Pjesma.Play();*/
        }

        private void osnovaaplikacije_Loaded(object sender, RoutedEventArgs e)
        {
            string ura;
            string minute;
            if (DateTime.Now.Hour >= 10)
                ura = DateTime.Now.Hour.ToString();
            else
                ura = "0" + DateTime.Now.Hour.ToString();

            if (DateTime.Now.Minute >= 10)
                minute = DateTime.Now.Minute.ToString();
            else minute = "0" + DateTime.Now.Minute.ToString();

            string sekunde;
            if (DateTime.Now.Second >= 10)
                sekunde = DateTime.Now.Second.ToString();
            else sekunde = "0" + DateTime.Now.Second.ToString();

            sat.Content = ura + ":" + minute + ":" + sekunde;

            DispatcherTimer dispatcherTimer = new DispatcherTimer();

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);

            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            dispatcherTimer.Start();

            /*var __mediaPlayer = new MediaPlayer();
            __mediaPlayer.Open(new Uri(@"C:\Users\Anes\Desktop\Projekat OOAD\PolicijskaStanica\PolicijskaStanica\PolicijskaStanica\Slike\The Chiffons - He´s So Fine-[www_flvto_com].mp3"));
            __mediaPlayer.Play();*/
            MediaElement media1 = new MediaElement();
            media1.LoadedBehavior = MediaState.Manual;
            media1.Source = new Uri(@"C:\Users\Anes\Desktop\Projekat OOAD\PolicijskaStanica\PolicijskaStanica\PolicijskaStanica\Zvuk\matrix05.mp3");
            Grida.Children.Add(media1);
            media1.Play();

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            string ura;
            string minute;
            if (DateTime.Now.Hour >= 10)
                ura = DateTime.Now.Hour.ToString();
            else
                ura = "0" + DateTime.Now.Hour.ToString();

            if (DateTime.Now.Minute >= 10)
                minute = DateTime.Now.Minute.ToString();
            else minute = "0" + DateTime.Now.Minute.ToString();

            string sekunde;
            if (DateTime.Now.Second >= 10)
                sekunde = DateTime.Now.Second.ToString();
            else sekunde = "0" + DateTime.Now.Second.ToString();

            sat.Content = ura + ":" + minute + ":" + sekunde;
        }

        private void Dodaj_korisnika_Click(object sender, RoutedEventArgs e)
        {
            DodajKorisnika novi = new DodajKorisnika();
            novi.Show();
        }

        private void Dodaj_osumnjicenog_Click(object sender, RoutedEventArgs e)
        {
            OptuzeniUnos f = new OptuzeniUnos();
            f.Show();
        }

        private void Lista_osumnjicenih_Click(object sender, RoutedEventArgs e)
        {
            ListaOsumnjicenih lista = new ListaOsumnjicenih();
            lista.Show();
        }

        private void Lista_korisnika_Click(object sender, RoutedEventArgs e)
        {
            ListaKorisnika lista = new ListaKorisnika();
            lista.Show();
        }

    }
}
