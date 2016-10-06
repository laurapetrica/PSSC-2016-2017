using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Adresa
    {
        private string numeStrada;
        private byte numar;
        private string codPostal;
        private string oras;
        private string judet;
        private string tara;

        public Adresa() { }

        public Adresa(string numeStrada, byte numar, string codPostal, string oras, string judet, string tara)
        {
            this.numeStrada = numeStrada;
            this.numar = numar;
            this.codPostal = codPostal;
            this.oras = oras;
            this.judet = judet;
            this.tara = tara;
        }

        #region Getters and Setters
        public string NumeStrada
        {
            get
            {
                return numeStrada;
            }

            set
            {
                numeStrada = value;
            }
        }

        public byte Numar
        {
            get
            {
                return numar;
            }

            set
            {
                numar = value;
            }
        }

        public string CodPostal
        {
            get
            {
                return codPostal;
            }

            set
            {
                codPostal = value;
            }
        }

        public string Oras
        {
            get
            {
                return oras;
            }

            set
            {
                oras = value;
            }
        }

        public string Judet
        {
            get
            {
                return judet;
            }

            set
            {
                judet = value;
            }
        }

        public string Tara
        {
            get
            {
                return tara;
            }

            set
            {
                tara = value;
            }
        }
        #endregion
    }
}
