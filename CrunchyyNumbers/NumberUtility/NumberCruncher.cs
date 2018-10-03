using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberUtility;

namespace NumberUtility
{
    public class NumberCruncher
    {
        //made a static method 
        public static int CrunchNumbers(List<int> numbers)
        {
            //using a for loop when manipulating lists (and not foreach), 
            //because foreach caused me trouble   
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                //this is how to tell if numbers aren't even so we can remove them
                if (numbers[i] % 2 != 0)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            //this is how to find the sum
            int sum = numbers.Sum();

            return sum;
        }
    }
}