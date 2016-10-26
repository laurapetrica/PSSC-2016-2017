using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Utils;

namespace Models.PersonModel
{
    enum Gender
    {
        male,
        female
    };

    class Person
    {
        private string cnp;

        private string firstName;
        private string middleName;
        private string lastName;

        private char fatherInitial;

        private Gender gender;

        private DateTime dateOfBirth;

        private Address address;

        private string phoneNumber;
        private string emailAddress;

        public Person() { }

        public Person(string cnp, string firstName, string lastName)
        {
            this.cnp = cnp;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        #region Getters and Setters
        public string CNP
        {
            get
            {
                return cnp;
            }

            set
            {
                cnp = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        internal Gender Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
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

        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
            }
        }

        public char FatherInitial
        {
            get
            {
                return fatherInitial;
            }

            set
            {
                fatherInitial = value;
            }
        }
        #endregion
    }
}
