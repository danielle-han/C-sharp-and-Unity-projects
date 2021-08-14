using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment6
{
    public abstract class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //method
        public abstract void SayName();
    }
}
