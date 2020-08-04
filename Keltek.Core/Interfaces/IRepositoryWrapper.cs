namespace Keltek.Core.Interfaces
{
  public interface IRepositoryWrapper
  {
    public IUserRepository User { get;}
    public IAccountRepository Account { get; set; }
    void Save();
  }
}