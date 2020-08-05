using System;
using Autofac;
using SoundRush.Infrastructure.IoC.Modules;

namespace SoundRush.Infrastructure 
{
  public class ContainerModule : Module 
  {
    protected override void Load(ContainerBuilder builder) 
    {
      builder.RegisterModule<ServiceModule>();
    }
  }
}