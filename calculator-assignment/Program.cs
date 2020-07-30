using System;
using System.Collections.Generic;

namespace calculator_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            string linebreak = "----------------------";
            // intro 

            Console.WriteLine(" ");
            Console.WriteLine("Welcome to my calculator assigment. ");
            Console.WriteLine(" ");
            Console.WriteLine("This first section takes a array of comma-seperated numbers (that start as strings) and turns them into integers");
            Console.WriteLine(" ");


            // create a comma seperated list of strings

            var commaSeperatedListOfStrings = new string[3] { "2", "5", "3" };
            Console.WriteLine($"The array called seperatedListOfStrings returns: {commaSeperatedListOfStrings}");
            Console.WriteLine(" ");
            Console.ReadKey(true);



            // a new list to 'push' your newly converted ints into

            List<int> commaSeperatedListOfIntegers = new List<int>();



            // turn comma seperated list of strings into numbers

            foreach (var digit in commaSeperatedListOfStrings)
            {
                commaSeperatedListOfIntegers.Add(int.Parse(digit));
                Console.WriteLine($"Inside the foreach loop of your original, comma seperated array called commaSeperatedListOfStrings returns: '{digit}' and it's a '{digit.GetType()}'");
                Console.WriteLine(" ");
            }

            Console.WriteLine(linebreak);
            Console.WriteLine(" ");
            Console.ReadKey(true);



            Console.WriteLine("Now let's convert those strings to ints!");
            Console.WriteLine("");

            foreach (var digit in commaSeperatedListOfIntegers)
            {
                Console.WriteLine($"commaSeperatedListOfIntegers now has... '{digit}' and it's a '{digit.GetType()}'");
                Console.WriteLine(" ");
            }


            Console.WriteLine(linebreak);
            Console.WriteLine(" ");
            Console.WriteLine("Now we need to multiply them in order. For example, if we had '2, 3, 2' it should return 12 (2x3x2)");
            Console.WriteLine(" ");
            Console.ReadKey(true);




            // print the result of multiplying those values together




            Console.ReadKey();








       

        }
    }
}
