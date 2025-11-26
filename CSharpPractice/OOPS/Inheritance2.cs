using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{

    // single 
    internal class Inheritance2 : Inheritance
    {
        public Inheritance2()
        {
            Console.WriteLine("Constructor of Inheritance2 called...");
        }
        // inheritance based overloading
        public void Test1(int i)
        {
            Console.WriteLine("Test3 method called...");
        }
        public void Test4()
        {
            Console.WriteLine("Test4 method called...");
        }

        public new void Test2() {

            Console.WriteLine("method hiding test2 method"); 
        }

        // overriding example it is optional to do
        public override void example() {

            Console.WriteLine("child class override method");
           
        }
    }
    // Multi-level
    internal class Inheritance3 : Inheritance2
    {

        public Inheritance3() {
            Console.WriteLine("Inheritance3 constructor called...");
        }

        public void Test5()
        {
            Console.WriteLine("Test5 method called...");
        }
        public void Test6()
        {
            Console.WriteLine("Test6 method called...");
        }



    }
}
