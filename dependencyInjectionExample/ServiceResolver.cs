using System.Reflection;
using Autofac;

namespace dependencyInjectionExample
{
  public class ServiceResolver
  {
    public IContainer Container { get; }

    public ServiceResolver()
    {
      var assmebly = Assembly.GetEntryAssembly();
      var builder = new ContainerBuilder();
      builder.RegisterAssemblyTypes(assmebly).As(t => t.GetInterfaces()).SingleInstance();

      this.Container = builder.Build();
    }
  }
}
