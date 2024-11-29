using Domain.Model.Registerations;
using Domain.Model.Registerations.Repositories;
using Infra.Persistance.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistance.EF.Repositories.Queries
{
    public class RegisterationQueryRepository : IRegisterationQueryRepository
    {
        private readonly RegistrationQueryContext _context;

        public RegisterationQueryRepository(RegistrationQueryContext context)
        {
            _context = context;
        }

      
        public bool AnyNationalCode(string nationalCode)
        {
            return _context.Registerations.Where(x=>x.NationalCode == nationalCode).Any();
        }
        public Registeration Get(int id)
        {
            return _context.Registerations.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
