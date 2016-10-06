using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum Sex
    {
        masculin,
        feminin
    };

    class Persoana
    {
        private string cnp;

        private string nume;
        private string prenume;

        private char initialaTata;

        private Sex sex;

        private byte varsta;

        private Adresa adresa;

        private string numarTelefon;
        private string adresaEmail;

        public Persoana() { }

        public Persoana(string cnp, string nume, string prenume)
        {
            this.cnp = cnp;
            this.nume = nume;
            this.prenume = prenume;
        }

        #region Getters and Setters
        public string CNP 
        {
            get
            {
                return cnp;
            }

            set
            {
                cnp = value;
            }
        }

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

        public string Prenume
        {
            get
            {
                return prenume;
            }

            set
            {
                prenume = value;
            }
        }

        internal Sex Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public byte Varsta
        {
            get
            {
                return varsta;
            }

            set
            {
                varsta = value;
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

        public string AdresaEmail
        {
            get
            {
                return adresaEmail;
            }

            set
            {
                adresaEmail = value;
            }
        }

        public char InitialaTata
        {
            get
            {
                return initialaTata;
            }

            set
            {
                initialaTata = value;
            }
        }
        #endregion
    }
}
