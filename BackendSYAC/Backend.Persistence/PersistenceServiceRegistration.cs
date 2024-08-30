using Backend.Application.Contracts.Persistence;
using Backend.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Backend.Application.Contracts.Infraestructure;
using Backend.Domain.Entities;

namespace Backend.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IAsyncRepository<Producto>), typeof(BaseRepository<Producto>));
            return services;
        }
    }
}