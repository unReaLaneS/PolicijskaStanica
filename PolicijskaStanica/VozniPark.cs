using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaStanica
{
    public class VozniPark
    {
        public VozniPark() { }
        private List<Vozilo> vozila;

        public List<Vozilo> Vozila
        {
            get { return vozila; }
            set { vozila = value; }
        }
    }
}
