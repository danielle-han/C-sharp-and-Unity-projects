using System;

namespace myConsoleApplication
{
    class myConsoleApplication
    {
        static void Main()
        {//console.writeline method is part of system lib
            //Console.WriteLine("What is your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("your name is: " + name + "!");
            //Console.Read(); //need to prevent console from exiting immediately
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine(course);

            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pageNum);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(answer);

            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine(experience);

            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine(feedback);

            Console.WriteLine("How many hours did you study today?");
            int hoursOfStudy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hoursOfStudy);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
