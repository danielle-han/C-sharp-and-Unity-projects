using System;

namespace WhileLoopAssignment
{
    class Program
    {
        static void Main()
        {
            //While loop
            Console.WriteLine("Guess the number");
            Console.WriteLine("Enter a number between 0 and 5 below:");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number != 2)
            {
                Console.WriteLine("You guessed the wrong number. Try again");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number);
            }
            Console.WriteLine("You guessed correctly!");

            //Do while loop 
            Console.WriteLine("Guess the number");
            Console.WriteLine("Enter a number between 0 and 5 below:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("You guessed the wrong number. Try again");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number1);
            } while (number1 != 2);

            Console.WriteLine("You guessed correctly!");
            Console.Read();
        }
    }
}
