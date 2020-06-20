using System;
using System.Collections.Generic;
using System.Linq;

namespace AddingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Adding Numbers");
            Console.WriteLine("Hello! Today you're going to give me a list of 5 numbers and I will add them up for you.");
            Console.WriteLine();

            string input;
            int numToAdd;
            List<int> numList = new List<int>();

            Console.WriteLine("Please input your first value: ");

            do
            {
                input = Console.ReadLine();
                if (Int32.TryParse(input, out numToAdd))
                {
                    numList.Add(numToAdd);
                    Console.WriteLine("Added! ");

                }

                else
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        numList.Add(0);
                        Console.WriteLine("You entered an invalid character, I've entered a 0 in this space.");
                    }
                }

            } while (numList.Count < 5);

            Console.WriteLine();
            Console.WriteLine("The total is " + numList.Sum());
        }
    }
}
