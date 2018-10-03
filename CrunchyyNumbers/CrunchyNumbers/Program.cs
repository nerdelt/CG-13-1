using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NumberUtility;



namespace CrunchyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //create list of numbers 
            List<int> numbers = new List<int>()
            {
                1, 9, 14, 27, 36, 45, 49, 52, 64, 73, 88, 92
            };

            //Call on the method in the NumberCruncher class/ NumberUtility Class Library
            Console.WriteLine("There is a list of numbers.\n");
            Console.WriteLine($"The sum of even numbers in the list is: {NumberCruncher.CrunchNumbers(numbers)}\n");
            Console.WriteLine($"Can you guess what the numbers are? \n\nlol jk\n");
            Console.ReadLine();
        }
    }
}
