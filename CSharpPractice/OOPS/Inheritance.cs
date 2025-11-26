using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{
    internal class Inheritance
    {
        public Inheritance() { 
          Console.WriteLine("Constructor called of Inheritance called...");
        }
        public void Test1()
        { 
          Console.WriteLine("Test1 method called...");
        }
        public void Test2()
        {
            Console.WriteLine("Test2 method called...");
        }

        // Overriding Example
        public virtual void example() {
            Console.WriteLine("Parent calss exmaple method");
        }

        }
}
