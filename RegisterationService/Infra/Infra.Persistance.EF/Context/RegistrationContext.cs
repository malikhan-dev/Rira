using Domain.Model.Registerations;
using Infra.Persistance.EF.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistance.EF.Context
{
    public sealed class RegistrationContext : BaseDbContext
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> opt) : base(opt)
        {

        }

        public override DbSet<Registeration> Registerations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new RegisterationEfMapping());
            base.OnModelCreating(modelBuilder); 

        }
    }
}
