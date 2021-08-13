using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class Math
    {
        public int method1(int integer)
        {
            return integer + 10;
        }

        public int method1(decimal dec)
        {
            int num = Decimal.ToInt32(dec);
            return num * 10;
        }

        public int method1(string num)
        {
            int number = Convert.ToInt32(num);
            return number + 15;
        }
    }
}
