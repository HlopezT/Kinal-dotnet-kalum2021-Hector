using System; 
namespace kalum2021.Models
{
    public class Teacher:Person
    {
        private string _employeedId; 
        public string EmployeedId
        {
            get
            {
                return _employeedId; 
            }
            set
            {
                _employeedId=value;
            }
        }
        //inicio constructores
        public Teacher()
        {
            //constructor nulo 
        }
        public Teacher(string TeacherId, string FirtsName, string LastName, string Mail, DateTime BirthDay, 
        string Gender, string Phone):base(FirtsName,LastName,Mail,BirthDay,Gender,Phone)
        {
            this.EmployeedId=EmployeedId;  
        }
        //fin constructores

    }
}