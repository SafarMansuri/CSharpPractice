using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.BasicPrograms
{
    internal class FieldsDemo
    {
        // fields examples and understanding of memory managment for fields
        public int x = 100; // instance variable - non static
        public static int y = 200; // static variable
        public const int PI = 10;
        public readonly int age = 25;


        // constructor to assign this vaules

         static  FieldsDemo() {
            Console.WriteLine("static constructor");
        }

        public FieldsDemo() {

            Console.WriteLine("COnstructor called");
        }

        public static void fieldsdemo() {

            Console.WriteLine("static method");
        }
        // when class loads than static constructor will be executed and after creating the instance the non static constructor will be created.
        

    }


}
