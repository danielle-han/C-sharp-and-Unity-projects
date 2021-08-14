using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            employee.Id = 2;

            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student2";
            employee1.Id = 2;

            IQuittable quit = new Employee();
            quit.Quit();

            //check overload operator
            bool check = employee == employee1;

            Console.WriteLine(check);

        Console.ReadLine();
        }
    }
}
