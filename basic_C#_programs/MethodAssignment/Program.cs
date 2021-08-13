using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Math math = new Math(); //create new math object from math class
            Console.WriteLine(math.method1(userInput));
            Console.WriteLine(math.method2(userInput));
            Console.WriteLine(math.method3(userInput));
            Console.ReadLine();
        }
    }
}
