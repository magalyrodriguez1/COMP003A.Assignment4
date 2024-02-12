/*
 * Author: Magaly Rodriguerz
 * Purpose: looping statements assignment 4
 * Course: COMP 003A
 * 
 */

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.WriteLine("Enter a positive whole number:");
            int limit;
            limit = Convert.ToInt32(Console.ReadLine());

            string output = "#";

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(output);
            output += "#";
            }

            Console.WriteLine("\n".PadRight(50, '*'));
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (var item in friends)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

        }
    }
}
