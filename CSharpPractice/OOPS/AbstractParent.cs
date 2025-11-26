using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{
    internal abstract class AbstractParent
    {
        // concreate methods
        public void add(int a, int b) {
            Console.WriteLine(a+b);
         }

        public void sub(int a, int b) { 
        
           Console.WriteLine(a-b);
        }

        public abstract void mul(int a, int b);
        public abstract void div(int a, int b);

    }

    internal class AbstractChild : AbstractParent{

        public AbstractChild() {

            Console.WriteLine("Abstract Child Constructor");
        }

        public override void mul(int a, int b)
        {
            Console.WriteLine(a*b);

        }
        public override void div(int a, int b)
        {
               Console.WriteLine(a%b);
        }

        public void abstractchildmember() { 
        
          Console.WriteLine("pure child class memebres");
        }




    }
}
