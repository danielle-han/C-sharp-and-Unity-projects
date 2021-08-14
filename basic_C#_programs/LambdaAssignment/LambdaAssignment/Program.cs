using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            { 
                new Employee {FirstName="John", LastName="Doe", Id=1 },
                new Employee {FirstName="Jane", LastName="Doe", Id=2 },
                new Employee {FirstName="Bill", LastName="Smith", Id=3 },
                new Employee {FirstName="Joe", LastName="Williams", Id=4 },
                new Employee {FirstName="Alex", LastName="Brown", Id=5 },
                new Employee {FirstName="Paul", LastName="Johnson", Id=6 },
                new Employee {FirstName="Nate", LastName="Miller", Id=7 },
                new Employee {FirstName="Emily", LastName="Kim", Id=8 },
                new Employee {FirstName="Beth", LastName="Lee", Id=9 },
                new Employee {FirstName="Joe", LastName="Park", Id=10 },
            };

  
            //using foreach loop: 

            //List<Employee> joeEmployees = new List<Employee>();

            //foreach (Employee emp in employees)
            //{
            //    if (emp.FirstName == "Joe")
            //    {
            //        joeEmployees.Add(emp);
            //    }
            //}

            //using lambda (firstname == joe)
            List<Employee> joeEmployees = employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine(joeEmployees.Count());

            //lambda (id greater than 5)
            List<Employee> IdGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine(IdGreaterThanFive.Count());

            Console.ReadLine();



        }
    }
}
