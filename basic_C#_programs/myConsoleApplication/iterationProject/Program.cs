using System;
using System.Collections.Generic;

namespace iterationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string array of names
            string[] nameArray = { "John", "Jane", "Joe", "Bill", "Andy", "Alex" };

            //take user input
            Console.WriteLine("Add a text to append to names:");
            string yourText = Console.ReadLine();

            //add user input to each string in array
            for (int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = nameArray[i] + " " + yourText;
            }

            //print out each string in array
            foreach(string name in nameArray)
            {
                Console.WriteLine(name);
            }


            //infinite loop fixed; loop using <
            int x = 1;
            while (x < 10)
            {
                x++;
                Console.WriteLine(x);
            }

            //loop using <=
            int y = 0;
            while (y <= 10)
            {
                y++;
                Console.WriteLine(y);
            }

            //create List
            List<string> colorList = new List<string> { "green", "blue", "red", "yellow", "orange", "purple" };

            //get user input
            Console.WriteLine("Enter a color:");
            string color = Console.ReadLine();

            //loop for list (assignment 4)
            for(int i = 0; i < colorList.Count; i++)
            {
               if (color == colorList[i])
                {
                    Console.WriteLine(i);
                    break;
                } else if (i==5 && color != colorList[i])
                {
                    Console.WriteLine("The color you entered is not in the list");
                }

            }

            //list (assignment 5)
            List<string> animalList = new List<string> { "bird", "dog", "cat", "tiger", "lion", "bear", "bird", "dog", "dog" };

            //user input
            Console.WriteLine("Enter an animal:");
            string animal = Console.ReadLine();

            //loop
            for (int i = 0; i < animalList.Count; i++)
            {
                if (animal == animalList[i])
                {
                    Console.WriteLine(i);
                    if (i == animalList.LastIndexOf(animal))
                    {
                        break;
                    }
                }
                else if (animalList.Count - i == 1 && animal != animalList[i])
                {
                    Console.WriteLine("The animal you entered is not in the list");
                }
            }


            //assignment 6
            List<string> nameList = new List<string> { "bill", "john", "joe", "alex", "alex", "john", "jane" };
            List<string> checkNameList = new List<string> { };

            foreach (string name in nameList)
            {
                //show string and whether or not it has already appeared.
                Console.WriteLine(name);
                if (checkNameList.Contains(name))
                {
                    Console.WriteLine(name + " already appeared in list");
                }
                checkNameList.Add(name);
            }

            Console.WriteLine("End of program");
            Console.Read();
        }
    }
}
