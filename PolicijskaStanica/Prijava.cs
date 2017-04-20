using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaStanica
{
    public class Prijava
    {
        DateTime datumPodnosenjaPrijave;

        public DateTime DatumPodnosenjaPrijave
        {
            get { return datumPodnosenjaPrijave; }
            set { datumPodnosenjaPrijave = value; }
        }
        string imePodnosioca;

        public string ImePodnosioca
        {
            get { return imePodnosioca; }
            set { imePodnosioca = value; }
        }
        string prezimePodnosioca;

        public string PrezimePodnosioca
        {
            get { return prezimePodnosioca; }
            set { prezimePodnosioca = value; }
        }
        string brojLicneKarte;

        public string BrojLicneKarte
        {
            get { return brojLicneKarte; }
            set { brojLicneKarte = value; }
        }
        int idPrijave;

        public int IdPrijave
        {
            get { return idPrijave; }
            set { idPrijave = value; }
        }
        string imeInspektora;

        public string ImeInspektora
        {
            get { return imeInspektora; }
            set { imeInspektora = value; }
        }
        string prezimInspektora;

        public string PrezimInspektora
        {
            get { return prezimInspektora; }
            set { prezimInspektora = value; }
        }
        int brojZnacke;

        public int BrojZnacke
        {
            get { return brojZnacke; }
            set { brojZnacke = value; }
        }
        string izjavaPodnosioca;

        public string IzjavaPodnosioca
        {
            get { return izjavaPodnosioca; }
            set { izjavaPodnosioca = value; }
        }

        public Prijava(string imepodnosioca, string prezimepodnosioca, string brojlicnekarte, DateTime datum, int id, string imeinspektora, string prezimeinspektora, int brojznacke, string izjava)
        {
            this.datumPodnosenjaPrijave = datum;
            this.imePodnosioca = imepodnosioca;
            this.prezimePodnosioca = prezimepodnosioca;
            this.brojLicneKarte = brojlicnekarte;
            this.idPrijave = id;
            this.imeInspektora = imeinspektora;
            this.prezimInspektora = prezimeinspektora;
            this.brojZnacke = brojznacke;
            this.izjavaPodnosioca = izjava;
        }
    }
}
