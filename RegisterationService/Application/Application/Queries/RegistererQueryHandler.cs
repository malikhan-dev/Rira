using Application.Contracts.DTO;
using Application.Contracts.Queries;
using Domain.Model.Registerations.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class RegistererQueryHandler : IRequestHandler<RegistererQuery, RegistererDto>
    {
        private readonly IRegisterationQueryRepository _registerationQueryRepository;

        public RegistererQueryHandler(IRegisterationQueryRepository registerationQueryRepository)
        {
            _registerationQueryRepository = registerationQueryRepository;
        }

       
        public async Task<RegistererDto> Handle(RegistererQuery request, CancellationToken cancellationToken)
        {
            var model =  _registerationQueryRepository.Get(request.Id);

            return new RegistererDto()
            {
                Id = model.Id,
                DateOfBirth = model.DateOfBirth,
                FirstName = model.FirstName,
                LastName = model.LastName,
                NationalCode = model.NationalCode,
            };
        }
    }
}
