using System;

namespace kalum2021.Models
{
    public class Student:Person
    {
        private string _studentId; 
        public string StudentId
        {
            get
            {
                return _studentId; 
            }
            set
            {
                _studentId=value; 
            }
        }
        //inicio constructores
        public Student()
        {
            //constructor nulo 
        }
        public Student(string StudentId, string FirtsName, string LastName,string Mail,
        DateTime BirthDay, string Gender, string Phone): base(FirtsName,LastName,Mail,BirthDay,Gender,Phone)
        {
            this.StudentId=StudentId; 
        }
        //fin constructores
    }
}