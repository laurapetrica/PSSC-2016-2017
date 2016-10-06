using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Facultate
    {
        private string nume;

        private Adresa adresa;

        private string numarTelefon;

        private List<Departament> departamente;

        public Facultate()
        {
            departamente = new List<Departament>();
        }

        public Facultate(string nume, Adresa adresa, string numarTelefon, List<Departament> departamente)
        {
            this.nume = nume;
            this.adresa = adresa;
            this.numarTelefon = numarTelefon;
            this.departamente = departamente;
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

        internal Adresa Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        public string NumarTelefon
        {
            get
            {
                return numarTelefon;
            }

            set
            {
                numarTelefon = value;
            }
        }

        internal List<Departament> Departamente
        {
            get
            {
                return departamente;
            }

            set
            {
                departamente = value;
            }
        }
        #endregion
    }
}
