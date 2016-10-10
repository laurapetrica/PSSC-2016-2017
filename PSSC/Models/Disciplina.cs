using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum TipEvaluare
    {
        Examen,
        EvaluareDistribuita
    };

    class Disciplina
    {
        private string nume;

        private int nrCredite;

        private Profesor titular;

        private Curs curs;

        private Seminar seminar;

        private Laborator laborator;

        private TipEvaluare tipEvaluare;

        public Disciplina(string nume, int nrCredite)
        {
            this.nume = nume;
            this.nrCredite = nrCredite;
        }

        public Disciplina(string nume, int nrCredite, Curs curs, Seminar seminar, Laborator laborator)
        {
            this.nume = nume;
            this.nrCredite = nrCredite;
            this.curs = curs;
            this.seminar = seminar;
            this.laborator = laborator;
        }
    }
}
