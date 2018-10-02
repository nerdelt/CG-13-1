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
        public static int CrunchNumbers(List<int> numbers)
        {
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            int sum = numbers.Sum();

            return sum;
        }
    }
}