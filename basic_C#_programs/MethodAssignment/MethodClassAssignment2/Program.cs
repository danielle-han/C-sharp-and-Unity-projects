using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            //user input
            Console.WriteLine("enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number if you wish:");
            try
            {
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(math.operation(userNum, userNum2));
            } 
            catch (Exception e)
            {
                Console.WriteLine(math.operation(userNum));
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
