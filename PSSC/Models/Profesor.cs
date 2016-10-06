using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor : Persoana
    {
        private Sala cabinet;

        public Profesor() { }

        public Profesor(string cnp, string nume, string prenume, Sala cabinet) : base(cnp, nume, prenume)
        {
            this.cabinet = cabinet;
        }
    }
}
