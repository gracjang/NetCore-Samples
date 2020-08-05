using Keltek.Core.Interfaces;
using Keltek.Infrastructure.Repository;
using Keltek.Services.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Keltek.Services
{
    public static class ServiceExtensions
    {
        public static void InstallRepository(this IServiceCollection service)
        {
          service.AddTransient<IUserRepository, UserRepository>();
          service.AddTransient<IAccountRepository, AccountRepository>();
          service.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
          service.AddTransient<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}