using Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.UniversityModel
{
    class University
    {
        private string name;

        private Address rectorshipAddress;

        private List<Faculty> faculties;

        public University()
        {
            faculties = new List<Faculty>();
        }

        public University(string name, Address rectorshipAddress, List<Faculty> faculties)
        {
            this.name = name;
            this.rectorshipAddress = rectorshipAddress;
            this.faculties = faculties;
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

        internal Address RectorshipAddress
        {
            get
            {
                return rectorshipAddress;
            }

            set
            {
                rectorshipAddress = value;
            }
        }

        internal List<Faculty> Faculties
        {
            get
            {
                return faculties;
            }

            set
            {
                faculties = value;
            }
        }
        #endregion
    }
}
