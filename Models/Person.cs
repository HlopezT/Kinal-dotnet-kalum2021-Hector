using System;

namespace kalum2021.Models
{
    public abstract class Person
    {
        private string _firtsName; 
        public string FirtsName
        {
            get
            {
                return _firtsName; 
            }
            set
            {
                _firtsName=value; 
            }
        }
        private string _lastName; 
        public string LastName
        {
            get
            {
                return _lastName; 
            }
            set
            {
                _lastName=value; 
            }
        }
        private string _mail; 
        public string Mail
        {
            get
            {
                return _mail; 
            }
            set
            {
                _mail=value; 
            }
        }
        private DateTime _birthDay; 
        public DateTime BirthDay
        {
            get
            {
                return _birthDay; 
            }
            set
            {
                _birthDay=value; 
            }
        }
        private string _gender; 
        public string Gender
        {
            get
            {
                return _gender; 
            }
            set
            {
                _gender=value; 
            }
        }
        private string _phone; 
        public string Phone
        {
            get
            {
                return _phone; 
            }
            set
            {
                _phone=value; 
            }
        }
        //inicio constructores
        public Person()
        {
            //constructor nulo 
        } 
        public Person(string FirtsName, string LastName, string Mail, DateTime BirthDay, 
        string Gender, string Phone)
        {
            this.FirtsName=FirtsName; 
            this.LastName=LastName; 
            this.Mail=Mail; 
            this.BirthDay=BirthDay; 
            this.Gender=Gender; 
            this.Phone=Phone; 
        }
        //fin constructores 
        //inicio metodo sobrecarga 
        public override string ToString()
        {
            return $"{this.FirtsName},{this.LastName}"; 
        }
        //fin metodo sobrecarga
    }
}