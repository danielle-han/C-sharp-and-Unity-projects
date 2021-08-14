using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment4
{
    public class Math
    {

        public void method(int integer)
        {
           int div = integer / 2;
            Console.WriteLine(div);
        }

        //method overload
        public void method(int integer, int number, out int value) //out parameter
        {
            value = 4;
            Console.WriteLine(integer + number);
            Console.WriteLine(value);
        }


    }
}
