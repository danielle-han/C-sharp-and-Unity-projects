using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.method1(5));

            Console.WriteLine(math.method1(2.453m));

            Console.WriteLine(math.method1("30"));

            Console.ReadLine();
        }
    }
}
