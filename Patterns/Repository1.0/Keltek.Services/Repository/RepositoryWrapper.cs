using Keltek.Core.Interfaces;
using Keltek.Infrastructure.Context;

namespace Keltek.Infrastructure.Repository
{
  public class RepositoryWrapper : IRepositoryWrapper
  {
    private RepositoryContext _repositoryContext;

    public RepositoryWrapper(IUserRepository userRepository, IAccountRepository accountRepository, RepositoryContext repositoryContext)
    {
      User = userRepository;
      Account = accountRepository;
      _repositoryContext = repositoryContext;
    }

    public IUserRepository User { get; }

    public IAccountRepository Account { get; set; }

    public void Save()
    {
      _repositoryContext.SaveChanges();
    }
  }
}