using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment6
{
    public class Employee : Person, IQuittable //inheritance
    {
        //property
        public int Id { get; set; }

        //method
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        //calling quit method 
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }

        //overload operator ==
        public static bool operator ==(Employee employee, Employee employee1)
        {
            return employee.Id == employee1.Id;
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            return employee.Id != employee1.Id;
        }
    }

}
