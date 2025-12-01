using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{
    internal class InOutParameters
    {

        // Out Parameters Example
        public int Math(int a, int b, out int c) {
            c = a + b;
            return c;
        }
      

        // Referance Example
        public int MathRef(ref int a, ref int b) {
            a = a + 10;
            b = b + 20;
            Console.WriteLine($"Value of a is {a} and Value of b is {b}");
            return a;
        }

        // returning multiple values using out parameters tupples
        public (int, int) tuppleMethod(int a, int b) {

            int c = a + b; // sum
            int d = a * b; // mul

            return (c, d);
        }

        // named tupples
        public (int , int ) namedTuppleMethod(int a, int b)
        {
            int sum = a + b; // sum
           int mul = a * b; // mul
            return (sum, mul);
        }
    }
}
