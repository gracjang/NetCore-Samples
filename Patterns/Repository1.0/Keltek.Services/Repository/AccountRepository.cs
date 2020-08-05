using Keltek.Core.Interfaces;
using Keltek.Core.Models;
using Keltek.Infrastructure.Context;
using Keltek.Infrastructure.Repository;

namespace Keltek.Services.Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}