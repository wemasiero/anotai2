using Anotai.Application.Interfaces;
using Anotai.Application.Services;
using Anotai.Data.Context;
using Anotai.Data.Repositories;
using Anotai.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Anotai.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();

            #region Services
            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBookService, BookService>();
            #endregion

            #region Repositories
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            #endregion
        }
    }
}