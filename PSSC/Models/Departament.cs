using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Departament
    {
        private string nume;

        private List<Student> studenti;

        private List<Profesor> profesori;

        public Departament()
        {
            studenti = new List<Student>();
            profesori = new List<Profesor>();
        }

        public Departament(string nume)
        {
            this.nume = nume;
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

        internal List<Student> Studenti
        {
            get
            {
                return studenti;
            }

            set
            {
                studenti = value;
            }
        }

        internal List<Profesor> Profesori
        {
            get
            {
                return profesori;
            }

            set
            {
                profesori = value;
            }
        }
        #endregion
    }
}
