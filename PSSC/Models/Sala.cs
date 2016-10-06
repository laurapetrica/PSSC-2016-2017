using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Sala
    {
        private string nume;

        private byte etaj;

        private Facultate facultate;

        public Sala() { }

        public Sala (string nume, byte etaj, Facultate facultate)
        {
            this.nume = nume;
            this.etaj = etaj;
            this.facultate = facultate;
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

        public byte Etaj
        {
            get
            {
                return etaj;
            }

            set
            {
                etaj = value;
            }
        }

        internal Facultate Facultate
        {
            get
            {
                return facultate;
            }

            set
            {
                facultate = value;
            }
        }
        #endregion
    }
}
