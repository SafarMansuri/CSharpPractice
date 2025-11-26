using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{
    public class OOPSExample1
    {
        // No value returning with out parameters
        public void Test()
        {
            Console.WriteLine("OOPS Example 1 : Test Without Parameters");
        }

        // No value returning with parameters
        public void Test(int a, int b, out int sum, out int mul)
        {
            sum = a + b;
            mul = a * b;
            Console.WriteLine("OOPS Example 1 : Test With Parameters");
        }

        // Value returning with parameters
        public int Test(int a, int b)
        {
            Console.WriteLine("OOPS Example 1 : Test With Parameters and Value Returning");
            return a + b;
        }

        // value returning with out parameters
        public int Test(int a, int b, out int sum)
        {
            sum = a + b;
            Console.WriteLine("OOPS Example 1 : Test With Parameters and Value Returning with out parameters");
            return a * b;
        }

       

    }
}
