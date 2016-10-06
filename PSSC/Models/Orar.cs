using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Orar
    {
        private Dictionary<Curs, Program> programCursuri;

        private Dictionary<Seminar, Program> programSeminarii;

        private Dictionary<Laborator, Program> programLaboratoare;

        public Orar ()
        {
            programCursuri = new Dictionary<Curs, Program>();
            programSeminarii = new Dictionary<Seminar, Program>();
            programLaboratoare = new Dictionary<Laborator, Program>();
        }

        #region Getters and Setters
        internal Dictionary<Curs, Program> ProgramCursuri
        {
            get
            {
                return programCursuri;
            }

            set
            {
                programCursuri = value;
            }
        }

        internal Dictionary<Seminar, Program> ProgramSeminarii
        {
            get
            {
                return programSeminarii;
            }

            set
            {
                programSeminarii = value;
            }
        }

        internal Dictionary<Laborator, Program> ProgramLaboratoare
        {
            get
            {
                return programLaboratoare;
            }

            set
            {
                programLaboratoare = value;
            }
        }
        #endregion
    }
}
