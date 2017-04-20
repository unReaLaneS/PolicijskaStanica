using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolicijskaStanica
{
   public class Vozilo
    {
       public Vozilo() { }

       private string marka;
       private string brSasije;
       private int godiste;
       private int godina_registracije;
       private string pogon;
       private string drzava_registracije;
       private int id;

       public int Id
       {
           get { return id; }
           set { id = value; }
       }

       public string Drzava_registracije
       {
           get { return drzava_registracije; }
           set { drzava_registracije = value; }
       }

       public string Pogon
       {
           get { return pogon; }
           set { pogon = value; }
       }

       public int Godina_registracije
       {
           get { return godina_registracije; }
           set { godina_registracije = value; }
       }

       public int Godiste
       {
           get { return godiste; }
           set { godiste = value; }
       }

       public string BrSasije
       {
           get { return brSasije; }
           set { brSasije = value; }
       }

       public string Marka
       {
           get { return marka; }
           set { marka = value; }
       }
       private string model;

       public string Model
       {
           get { return model; }
           set { model = value; }
       }
       private string boja;

       public string Boja
       {
           get { return boja; }
           set { boja = value; }
       }
       private string registarske_tablice;

       public string Registarske_tablice
       {
           get { return registarske_tablice; }
           set { registarske_tablice = value; }
       }

    }
}
