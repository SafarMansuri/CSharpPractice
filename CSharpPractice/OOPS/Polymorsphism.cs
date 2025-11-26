using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{
    internal class Polymorsphism
    {
        public Polymorsphism()
        {
            Console.WriteLine("Contructor called of Polymorsphism");
        }

        /// method overloading
        /// 
        public void show()
        {
            Console.WriteLine("show method called");

        }

        public void show(int i)
        {

            Console.WriteLine("show method with" + i);
        }

        public void show(string s)
        {
            Console.WriteLine("show method with" + s);
        }
    }
    }
