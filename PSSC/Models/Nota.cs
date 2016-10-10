using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Nota
    {
        private byte notaExamen;
        private byte notaActivitateParcurs;

        public Nota(byte notaExamen, byte notaActivitateParcurs)
        {
            this.notaExamen = notaExamen;
            this.notaActivitateParcurs = notaActivitateParcurs;    
        }

        #region Getters and Setters
        public byte NotaExamen
        {
            get
            {
                return notaExamen;
            }

            set
            {
                notaExamen = value;
            }
        }

        public byte NotaActivitateParcurs
        {
            get
            {
                return notaActivitateParcurs;
            }

            set
            {
                notaActivitateParcurs = value;
            }
        }
        #endregion
    }
}
