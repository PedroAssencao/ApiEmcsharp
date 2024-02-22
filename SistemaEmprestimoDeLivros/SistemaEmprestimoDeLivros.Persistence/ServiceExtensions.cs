using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaEmprestimoDeLivros.Domain.Interfaces;
using SistemaEmprestimoDeLivros.Persistence.Context;
using SistemaEmprestimoDeLivros.Persistence.Repositories;

namespace SistemaEmprestimoDeLivros.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DataBase");
            if (connectionString == null)
            {
                connectionString = "Data Source=DESKTOP-02BUU56;Initial Catalog=UserDb;Integrated Security=True;Encrypt=False;";
            }
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork, UnityOffWork>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

    }
}
