using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Address
    {
        private string streetName;
        private byte number;
        private string postalCode;
        private string city;
        private string county;
        private string country;

        public Address() { }

        public Address(string streetName, byte number, string postalCode, string city, string county, string country)
        {
            this.streetName = streetName;
            this.number = number;
            this.postalCode = postalCode;
            this.city = city;
            this.county = county;
            this.country = country;
        }

        #region Getters and Setters
        public string StreetName
        {
            get
            {
                return streetName;
            }

            set
            {
                streetName = value;
            }
        }

        public byte Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string County
        {
            get
            {
                return county;
            }

            set
            {
                county = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }
        #endregion
    }
}
