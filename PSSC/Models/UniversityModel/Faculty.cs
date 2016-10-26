using System.Collections.Generic;

namespace Models.UniversityModel
{
    class Faculty
    {
        private string name;

        private Address address;

        private string phoneNumber;

        private Deanship deanship;

        public Faculty(string name, Address address, string phoneNumber, Deanship deanship)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.deanship = deanship;
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

        internal Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        internal Deanship Deanship
        {
            get
            {
                return deanship;
            }

            set
            {
                deanship = value;
            }
        }
        #endregion
    }
}
