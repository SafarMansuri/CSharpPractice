using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{
    internal class Constructor
    {
        int? x;
        bool? y;
        string? z;
        public Constructor() {
            Console.WriteLine("Constructor called");
        }
        public void Display() {
            Console.WriteLine("Display method called");
        }
        
        public Constructor(int a) {
            Console.WriteLine("Constructor with parameter called: " + a);
        }
    }
}
