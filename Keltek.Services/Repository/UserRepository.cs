using System;
using System.Linq;
using System.Linq.Expressions;
using Keltek.Core.Interfaces;
using Keltek.Core.Models;
using Keltek.Infrastructure.Context;

namespace Keltek.Infrastructure.Repository
{
  public class UserRepository : RepositoryBase<User>, IUserRepository
  {
    public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
  }
}