using Application.Contracts.Commands.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Commands
{
    public class RegisterCommand : IRequest<BaseCommandResult<bool>>
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string NationalCode { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public RegisterCommand(int id, string fName, string lName, string nationalCode, DateTime dob)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
            this.NationalCode = nationalCode;
            this.DateOfBirth = dob;
        }
    }
}
