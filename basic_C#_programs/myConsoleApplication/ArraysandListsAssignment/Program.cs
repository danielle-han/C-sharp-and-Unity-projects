using System;
using System.Collections.Generic; //need for lists

namespace ArraysandListsAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "hello", "world", "name" };
            Console.WriteLine("Enter a number between 0 and 2");
            int index = Convert.ToInt32(Console.ReadLine());
            while (index > 2 )
            {
                Console.WriteLine("You selected an index that does not exist.");
                Console.WriteLine("Enter a number between 0 and 2");
                index = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(stringArray[index]);

            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Enter a number between 0 and 9");
            index = Convert.ToInt32(Console.ReadLine());
            while (index > 9)
            {
                Console.WriteLine("You selected an index that does not exist.");
                Console.WriteLine("Enter a number between 0 and 9");
                index = Convert.ToInt32(Console.ReadLine());
            }
           
            Console.WriteLine(numArray[index]);
          


            Console.WriteLine("List:");
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("name");
            stringList.Add("date");
            stringList.Add("phone");
            Console.WriteLine("Enter a number between 0 and 4");
            index = Convert.ToInt32(Console.ReadLine());
            while (index > 4)
            {
                Console.WriteLine("You selected an index that does not exist.");
                Console.WriteLine("Enter a number between 0 and 4");
                index = Convert.ToInt32(Console.ReadLine());
            }
               
            Console.WriteLine(stringList[index]);

            Console.Read();


            ////Array Fundamentals
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //same thing as above
            //int[] numArray2 = { 5, 2, 10, 200, 5000 }; //same as above 

            //numArray2[3] = 2;

            //Console.WriteLine(numArray[3]);
            //Console.ReadLine();

            //List Fundamentals
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();


        }
    }
}
