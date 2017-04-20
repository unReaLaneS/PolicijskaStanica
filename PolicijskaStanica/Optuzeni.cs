using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PolicijskaStanica
{
   public class Optuzeni
    {
       public Optuzeni() { }
       private int id;
       private string staza;

       public string Staza
       {
           get { return staza; }
           set { staza = value; }
       }
       private string ime;
       private string prezime;
       private DateTime datum_rodjenja;
       private string mjesto_rodjenja;
       private string maticni_broj;
       private string adresa_kuca;
       private string adresa_posao;
       private string srednjeIme;
       private string pol;
       private string tipGradje;
       private int visina;
       private string bojaKose;
       private string bojaOciju;
       private string oziljci;
       private string tetovaze;
       private ImageSource slika;
       private string kucni_broj;
       private string mobilni_broj;
       private string fax_broj;
       private string brLicne;
       private string brVozacke;
       private string brPasosa;
       private string biljeske;
       private string tip;
       private DateTime datum_unosa;
       private string vrijeme_unosa;
     


       public string Vrijeme_unosa
       {
           get { return vrijeme_unosa; }
           set { vrijeme_unosa = value; }
       }

       public DateTime Datum_unosa
       {
           get { return datum_unosa; }
           set { datum_unosa = value; }
       }

       public string Tip
       {
           get { return tip; }
           set { tip = value; }
       }

       public string Biljeske
       {
           get { return biljeske; }
           set { biljeske = value; }
       }

       public string BrPasosa
       {
           get { return brPasosa; }
           set { brPasosa = value; }
       }

       public string BrVozacke
       {
           get { return brVozacke; }
           set { brVozacke = value; }
       }

       public string BrLicne
       {
           get { return brLicne; }
           set { brLicne = value; }
       }

       public string Fax_broj
       {
           get { return fax_broj; }
           set { fax_broj = value; }
       }

       public string Mobilni_broj
       {
           get { return mobilni_broj; }
           set { mobilni_broj = value; }
       }

       public string Kucni_broj
       {
           get { return kucni_broj; }
           set { kucni_broj = value; }
       }

       public ImageSource Slika
       {
           get { return slika; }
           set { slika = value; }
       }

       public string Tetovaze
       {
           get { return tetovaze; }
           set { tetovaze = value; }
       }

       public string Oziljci
       {
           get { return oziljci; }
           set { oziljci = value; }
       }

       public string BojaOciju
       {
           get { return bojaOciju; }
           set { bojaOciju = value; }
       }

       public string BojaKose
       {
           get { return bojaKose; }
           set { bojaKose = value; }
       }

       public int Visina
       {
           get { return visina; }
           set { visina = value; }
       }

       public string TipGradje
       {
           get { return tipGradje; }
           set { tipGradje = value; }
       }


       public string Pol
       {
           get { return pol; }
           set { pol = value; }
       }

       public string SrednjeIme
       {
           get { return srednjeIme; }
           set { srednjeIme = value; }
       }

       public string Adresa_posao
       {
           get { return adresa_posao; }
           set { adresa_posao = value; }
       }

       public string Adresa_kuca
       {
           get { return adresa_kuca; }
           set { adresa_kuca = value; }
       }
       
       public int Id
       {
           get { return id; }
           set { id = value; }
       }

    

      
       public string Maticni_broj
       {
           get { return maticni_broj; }
           set { maticni_broj = value; }
       }

       public string Mjesto_rodjenja
       {
           get { return mjesto_rodjenja; }
           set { mjesto_rodjenja = value; }
       }

       public DateTime Datum_rodjenja
       {
           get { return datum_rodjenja; }
           set { datum_rodjenja = value; }
       }

       public string Prezime
       {
           get { return prezime; }
           set { prezime = value; }
       }

       public string Ime
       {
           get { return ime; }
           set { ime = value; }
       }
    }
}
