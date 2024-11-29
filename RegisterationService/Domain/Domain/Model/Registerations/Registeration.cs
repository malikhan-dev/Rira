using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Registerations
{
    public class Registeration
    {
        public int Id { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string NationalCode { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }

        public Registeration()
        {
            
        }
        public Registeration(string fName, string lName, string nationalCode, DateTime dob)
        {
            FirstName = fName;
            LastName = lName;
            NationalCode = nationalCode;
            DateOfBirth = dob;
        }
    }
}
