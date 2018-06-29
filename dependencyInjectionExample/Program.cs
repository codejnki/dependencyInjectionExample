using System;
using Autofac;

namespace dependencyInjectionExample
{
  class Program
  {
    static void Main(string[] args)
    {
      var serviceResolver = new ServiceResolver();

      var myProgram = serviceResolver.Container.Resolve<IMyProgram>();

      myProgram.Run();
    }
  }
}
