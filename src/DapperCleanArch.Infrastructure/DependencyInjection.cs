using DapperCleanArch.Application.Common.Interfaces;
using DapperCleanArch.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DapperCleanArch.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}
