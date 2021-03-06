using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SoundRush.Infrastructure;

namespace SoundRush.API
{
    public class Startup 
  {
    public Startup(IConfiguration configuration) 
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    public ILifetimeScope AutofacContainer { get; private set; }

    public void ConfigureServices(IServiceCollection services) 
    {
      services.AddControllers();
    }

    public void ConfigureContainer(ContainerBuilder builder) 
    {
      builder.RegisterModule(new ContainerModule());
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
    {
      AutofacContainer = app.ApplicationServices.GetAutofacRoot();
      if (env.IsDevelopment()) {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints => {
        endpoints.MapControllers();
      });
    }
  }
}