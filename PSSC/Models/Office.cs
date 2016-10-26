using Models.UniversityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Office
    {
        private string name;

        private byte floor;

        private Faculty faculty;

        public Office() { }

        public Office (string name, byte floor, Faculty faculty)
        {
            this.name = name;
            this.floor = floor;
            this.faculty = faculty;
        }

        #region Getters and Setters
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public byte Floor
        {
            get
            {
                return floor;
            }

            set
            {
                floor = value;
            }
        }

        internal Faculty Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }
        #endregion
    }
}
