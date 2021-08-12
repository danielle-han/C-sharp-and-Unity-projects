using System;

namespace ComparisonAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int hoursPerWeek = Convert.ToInt32(Console.ReadLine());
            int annualSalary = hourlyRate * hoursPerWeek * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            int annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary);

            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary > annualSalary2);

            Console.Read();
        }
    }
}
