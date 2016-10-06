using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Universitate
    {
        private string nume;

        private Adresa adresaRectorat;

        private List<Facultate> facultati;

        public Universitate()
        {
            facultati = new List<Facultate>();
        }

        public Universitate(string nume, Adresa adresaRectorat, List<Facultate> facultati)
        {
            this.nume = nume;
            this.adresaRectorat = adresaRectorat;
            this.facultati = facultati;
        }

        #region Getters and Setters
        public string Nume
        {
            get
            {
                return nume;
            }

            set
            {
                nume = value;
            }
        }

        internal Adresa AdresaRectorat
        {
            get
            {
                return adresaRectorat;
            }

            set
            {
                adresaRectorat = value;
            }
        }

        internal List<Facultate> Facultati
        {
            get
            {
                return facultati;
            }

            set
            {
                facultati = value;
            }
        }
        #endregion
    }
}
