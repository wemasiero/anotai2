using Anotai.Application.Interfaces;
using Anotai.Application.Services;
using Anotai.Data.Repositories;
using Anotai.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Anotai.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IGenderService, GenderService>();
            #endregion

            #region Repositories
            services.AddScoped<IGenderRepository, GenderRepository>();
            #endregion
        }
    }
}