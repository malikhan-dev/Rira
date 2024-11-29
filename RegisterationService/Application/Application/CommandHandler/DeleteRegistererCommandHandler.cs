using Application.Contracts.Commands;
using Application.Contracts.Commands.Results;
using Domain.Model.Registerations.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CommandHandler
{
    public class DeleteRegistererCommandHandler : IRequestHandler<DeleteRegistererCommand, BaseCommandResult<bool>>
    {
        private readonly IRegisterationCommandRepository _registerationCommandRepository;
        public DeleteRegistererCommandHandler(IRegisterationCommandRepository registerationCommandRepository)
        {
            _registerationCommandRepository = registerationCommandRepository;
        }
        public async Task<BaseCommandResult<bool>> Handle(DeleteRegistererCommand request, CancellationToken cancellationToken)
        {
            await _registerationCommandRepository.Remove(request.Id, cancellationToken);

            return new BaseCommandResult<bool>()
            {
                Data = true,
                Description = "",
                Success = true,
            };
        }
    }
}
