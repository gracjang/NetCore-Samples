using Keltek.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Keltek.Infrastructure.Context
{
  public class RepositoryContext : DbContext
  {
    public RepositoryContext(DbContextOptions options) : base (options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Account> Accounts { get; set; }
  }
}