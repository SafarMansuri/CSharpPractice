using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.BasicPrograms
{
    internal class Paramss
    {

        public int parameters(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // method with params and other parameter
        public int parametersWithOtherParam(string message, params int[] numbers)
        {
            Console.WriteLine(message);
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
