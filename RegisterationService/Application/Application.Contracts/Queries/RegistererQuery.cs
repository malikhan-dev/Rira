using Application.Contracts.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Queries
{
    public class RegistererQuery : IRequest<RegistererDto>
    {
        public int Id { get; set; }
        public RegistererQuery(int id)
        {
            this.Id = id;
        }
    }
}
