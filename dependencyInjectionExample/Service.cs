using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyInjectionExample
{
    class Service : IService
    {
      public void WriteTheStuff()
      {
        Console.WriteLine("I was injected!");
      }
    }
}
