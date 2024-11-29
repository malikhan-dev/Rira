using Application.Contracts.Commands.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Commands
{
    public class DeleteRegistererCommand : IRequest<BaseCommandResult<bool>>
    {
        public DeleteRegistererCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }


    }
}
