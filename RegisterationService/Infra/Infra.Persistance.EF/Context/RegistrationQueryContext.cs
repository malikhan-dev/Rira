using Domain.Model.Registerations;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistance.EF.Context
{
    public sealed class RegistrationQueryContext : BaseDbContext
    {
        public RegistrationQueryContext(DbContextOptions<RegistrationQueryContext> opt) : base(opt)
        {
        }

        public override DbSet<Registeration> Registerations { get; set ; }
    }
}
