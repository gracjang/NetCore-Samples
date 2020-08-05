using System.Reflection;
using Autofac;
using SoundRush.Infrastructure.Services.Interfaces;

namespace SoundRush.Infrastructure.IoC.Modules
{
  public class ServiceModule : Autofac.Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      var assembly = typeof(ServiceModule).GetTypeInfo().Assembly;

      builder.RegisterAssemblyTypes(assembly)
        .Where(x => x.IsAssignableTo<IService>())
        .AsImplementedInterfaces()
        .InstancePerLifetimeScope();
    }
  }
}