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
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            employee.Id = 2;

            Employee<string> employee1 = new Employee<string>();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student2";
            employee1.Id = 2;

            IQuittable quit = new Employee<string>();
            quit.Quit();

            //list of strings
            Employee<string> person = new Employee<string>();
            person.Things = new List<string>() { "book", "cup", "pen", "paper"};

            //list of int
            Employee<int> person2 = new Employee<int>();
            person2.Things = new List<int>() { 1,2,3,4,5,6,7 };

            //loop for string
            for(int i = 0; i<person.Things.Count; i++)
            {
                Console.WriteLine(person.Things[i]);
            }

            //loop for int
            for (int i = 0; i < person2.Things.Count; i++)
            {
                Console.WriteLine(person2.Things[i]);
            }
            //check overload operator
            bool check = employee == employee1;

            Console.WriteLine(check);

        Console.ReadLine();
        }
    }
}
