using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment4
{
    static class Program //static class
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            //user input
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            math.method(number);

            //method overload and out parameter
            int value;
            math.method(2, 4, out value);

            Console.Read();
        }
    }
}
