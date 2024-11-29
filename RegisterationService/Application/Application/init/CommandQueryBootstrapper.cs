using Application.Commands;
using Application.Pipelines;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.init
{
    public static class AppBootstrapper
    {
        public static void InitCommands(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<RegisterCommandHandler>();
            });
        }

        public static void InitializeAppService(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ExceptionHandledCommandBehaviour<,>));

        }
    }
}
