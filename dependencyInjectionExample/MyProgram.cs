using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyInjectionExample
{
    public class MyProgram : IMyProgram
    {
      private readonly IService _service;

      public MyProgram(IService service)
      {
        _service = service;
      }

      public void Run()
      {
        _service.WriteTheStuff();
      }
    }
}
