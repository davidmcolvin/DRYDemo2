using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      EmployeeProcessor processor = new EmployeeProcessor();

      Console.Write("What is your first name: ");
      string firstName = Console.ReadLine();

      Console.Write("What is your last name: ");
      string lastName = Console.ReadLine();


      string employeeId = processor.GenerateEmployeeID(firstName, lastName);

      Console.WriteLine($"Your employeeId is {employeeId}");

      Console.ReadLine();
    }
  }
}
