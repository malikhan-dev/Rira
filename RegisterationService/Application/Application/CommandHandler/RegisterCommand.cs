using Application.Contracts.Commands;
using Application.Contracts.Commands.Results;
using Domain.Model.Registerations.Repositories;
using Domain.Model.Registerations.Services;
using MediatR;
using System.Runtime.CompilerServices;

namespace Application.Commands
{
    internal class RegisterCommandHandler : IRequestHandler<RegisterCommand, BaseCommandResult<bool>>
    {
        private readonly IRegisterationCommandRepository _repository;
        private readonly IRegisterationQueryRepository _queryRepository;
        public RegisterCommandHandler(IRegisterationCommandRepository repository, IRegisterationQueryRepository queryRepository)
        {
            _repository = repository;
            _queryRepository = queryRepository;
        }
        public async Task<BaseCommandResult<bool>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (_queryRepository.AnyNationalCode(request.NationalCode))
            {
                return new BaseCommandResult<bool>()
                {
                    Data = false,
                    Description = "Already Registered",
                    Success = false,
                };
            }

            var model = RegisterationFactory.Factory(new Domain.Model.Registerations.ValueObject.RegisterationValueObject(request.FirstName, request.LastName, request.NationalCode, request.DateOfBirth));

            await _repository.Add(model, cancellationToken);

            return new BaseCommandResult<bool>() { Data = true, Success = true, Description = "Registered." };
        }
    }
}
