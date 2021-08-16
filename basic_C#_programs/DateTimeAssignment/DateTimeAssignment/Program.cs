using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //current date and time
            Console.WriteLine(DateTime.Now);

            //asking for number
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            TimeSpan time = new TimeSpan(num, 0, 0);
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            time += currentTime;

            //time in 'num' hours:
            Console.WriteLine("The time in {0} hours is: " + time.ToString(), num);

            Console.Read();
        }
    }
}
