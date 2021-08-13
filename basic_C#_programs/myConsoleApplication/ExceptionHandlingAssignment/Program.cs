using System;
using System.Collections.Generic;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { 23, 30, 26, 400, 15, 69, 73, 80, 500, 10};

            //try catch
            try
            {
                //user input
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                //loop
                for (int i = 0; i < numList.Count; i++)
                {
                    int divide = numList[i] / number;
                    Console.WriteLine(divide);
                }

            }
            catch (FormatException error)
            {
                Console.WriteLine("Please input a whole number");

            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Please do not input 0.");

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);

            } 
            finally
            {
                Console.WriteLine("Program exited try/catch block. Continue on with program execution");
                Console.Read();
            }
          



            //try
            //{
            //    Console.WriteLine("Pick a number:");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Pick a second number:");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Dividing the two...");
            //    int numberThree = numberOne / numberTwo;

            //    Console.WriteLine(numberThree);

            //} catch (FormatException error)
            //{
            //    Console.WriteLine("please type a whole number");//error.Message
            //}
            //catch (DivideByZeroException error)
            //{
            //    Console.WriteLine("please dont divide by zero");
            //} 
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.Message);
            //    return; //would immediately stop execution 
            //}
            //finally //will always run regardless of what happens above
            //{//used b/c a lot of times when you catch something - stop execution  
            //    Console.ReadLine();
            //} //typically has a database log
            
        }
    }
}
