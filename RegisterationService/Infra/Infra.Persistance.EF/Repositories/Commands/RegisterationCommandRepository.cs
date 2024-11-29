using Domain.Model.Registerations;
using Domain.Model.Registerations.Repositories;
using Infra.Persistance.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infra.Persistance.EF.Repositories.Commands
{
    public class RegisterationCommandRepository : IRegisterationCommandRepository
    {
        private readonly RegistrationContext _context;
        public RegisterationCommandRepository(RegistrationContext context)
        {
            _context = context;
        }
        public async Task Add(Registeration registeration, CancellationToken token)
        {
            _context.Add(registeration);
            await _context.SaveChangesAsync(token);
        }
    }
}
