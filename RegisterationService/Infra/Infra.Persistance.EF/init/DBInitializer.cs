using Domain.Model.Registerations.Repositories;
using Infra.Persistance.EF.Context;
using Infra.Persistance.EF.Repositories.Commands;
using Infra.Persistance.EF.Repositories.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Persistance.EF.init
{
    public static class DBInitializer
    {
        public static void InitializeDatabases(this IServiceCollection services, string writeConstr)
        {
            //services.AddDbContext<RegistrationReadContext>(cfg =>
            //{
            //    cfg.UseMongoDB(readConstr, readDbName);
            //});

            services.AddDbContext<RegistrationContext>(cfg =>
            {
                cfg.UseSqlServer(writeConstr);
            });

            services.AddDbContext<RegistrationQueryContext>(cfg =>
            {
                cfg.UseSqlServer(writeConstr);
            });

            services.AddScoped<IRegisterationCommandRepository, RegisterationCommandRepository>();

            services.AddScoped<IRegisterationQueryRepository, RegisterationQueryRepository>();
        }
    }
}
