using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment5
{
    public class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //method
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
