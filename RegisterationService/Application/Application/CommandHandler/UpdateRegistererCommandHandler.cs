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
    public class UpdateRegistererCommandHandler : IRequestHandler<UpdateRegistererCommand, BaseCommandResult<bool>>
    {
        private readonly IRegisterationQueryRepository _registerationQueryRepository;
        private readonly IRegisterationCommandRepository _registerationCommandRepository;
        public UpdateRegistererCommandHandler(IRegisterationQueryRepository registerationQueryRepository, IRegisterationCommandRepository registerationCommandRepository)
        {
            _registerationQueryRepository = registerationQueryRepository;
            _registerationCommandRepository = registerationCommandRepository;
        }
        public async Task<BaseCommandResult<bool>> Handle(UpdateRegistererCommand request, CancellationToken cancellationToken)
        {
            var model = _registerationQueryRepository.Get(request.Id);

            model.Update(request.FirstName, request.LastName, request.NationalCode, request.DateOfBirth);

            await _registerationCommandRepository.Update(model,cancellationToken);

            return new BaseCommandResult<bool> { Success = true, Data = true };
        }
    }
}
