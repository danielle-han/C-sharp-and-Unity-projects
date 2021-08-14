using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //get user input
                Console.WriteLine("What is the current day of the week?");
                string answer = Console.ReadLine().ToLower();
                //assign to enum type
                DaysofWeek currentDay = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), answer);
                //Check the Enum type
                foreach (DaysofWeek day in Enum.GetValues(typeof(DaysofWeek)))
                {
                    if (day == currentDay)
                    {
                        Console.WriteLine("Today is " + currentDay.ToString());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }
        }

    }
    //days of the week enum
    public enum DaysofWeek
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }
}
