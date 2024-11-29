using Infra.Persistance.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistance.EF
{
    internal class DesignTime_TimeSheetContext_Factory : IDesignTimeDbContextFactory<RegistrationContext>

    {
        public RegistrationContext CreateDbContext(string[] args)
        {

            string designTimeConstr = "Data Source=localhost,1433;Initial Catalog=Registeration;User ID=SA;Password=asd1@2@3!frl;TrustServerCertificate=True";

            var optionsBuilder = new DbContextOptionsBuilder<RegistrationContext>();

            optionsBuilder.UseSqlServer(designTimeConstr);

            return new RegistrationContext(optionsBuilder.Options);
        }
    }
}
