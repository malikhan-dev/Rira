using Domain.Model.Registerations;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistance.EF.Context
{
    public abstract class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions opt) : base(opt)
        {

        }
        public abstract DbSet<Registeration> Registerations { get; set; }
    }
}
