using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student : Persoana
    {
        private int numarMatricol;

        private Facultate facultate;

        private Departament departament;

        private byte grupa;

        private byte subgrupa;

        private byte anStudiu;

        private List<Disciplina> discipline;

        private Orar orar;

        private Dictionary<Disciplina, byte> carnetNote;

        public Student()
        {
            discipline = new List<Disciplina>();
            carnetNote = new Dictionary<Disciplina, byte>();
        }

        public Student(string cnp, string nume, string prenume, int numarMatricol, byte grupa, byte subgrupa, byte anStudiu) : base(cnp, nume, prenume)
        {
            this.numarMatricol = numarMatricol;
            this.grupa = grupa;
            this.subgrupa = subgrupa;
            this.anStudiu = anStudiu;
            discipline = new List<Disciplina>();
            carnetNote = new Dictionary<Disciplina, byte>();
        }

        #region Getters and Setters
        public int NumarMatricol
        {
            get
            {
                return numarMatricol;
            }

            set
            {
                numarMatricol = value;
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

        internal Departament Departament
        {
            get
            {
                return departament;
            }

            set
            {
                departament = value;
            }
        }

        public byte Grupa
        {
            get
            {
                return grupa;
            }

            set
            {
                grupa = value;
            }
        }

        public byte Subgrupa
        {
            get
            {
                return subgrupa;
            }

            set
            {
                subgrupa = value;
            }
        }

        public byte AnStudiu
        {
            get
            {
                return anStudiu;
            }

            set
            {
                anStudiu = value;
            }
        }

        internal List<Disciplina> Discipline
        {
            get
            {
                return discipline;
            }

            set
            {
                discipline = value;
            }
        }

        internal Dictionary<Disciplina, byte> CarnetNote
        {
            get
            {
                return carnetNote;
            }

            set
            {
                carnetNote = value;
            }
        }

        internal Orar Orar
        {
            get
            {
                return orar;
            }

            set
            {
                orar = value;
            }
        }
        #endregion
    }


}
