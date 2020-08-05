using SoundRush.Infrastructure.Services.Interfaces;

namespace SoundRush.Infrastructure.Services
{
  public class ServiceA : IServiceA
  {
    public string SendMessage()
    {
      return "Welcome in Service A";
    }
  }
}