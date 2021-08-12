using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter Package Weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            } else
            {
                Console.WriteLine("Enter Package Width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Package Height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Package Length:");
                int length = Convert.ToInt32(Console.ReadLine());
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                } else
                {
                    int quote = (width * height * length * weight) / 100;
                    Console.WriteLine("Estimated total for shipping this package:");
                    Console.WriteLine(quote);
                }
            }
            Console.Read();
        }
    }
}
