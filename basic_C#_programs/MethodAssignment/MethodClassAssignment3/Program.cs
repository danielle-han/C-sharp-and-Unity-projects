using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.method1(3, 2);
            math.method1(integer: 7, number: 10);
            Console.Read();
        }
    }
}
