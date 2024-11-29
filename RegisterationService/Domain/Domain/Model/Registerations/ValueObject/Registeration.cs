using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Registerations.ValueObject
{
    public record RegisterationValueObject(string firstName,string lastName,string nationalCode, DateTime dob);
    
    
}
