using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Loops
{
    public class Program1
    {
        public Program1() {
            Console.WriteLine("Constructor : Program");
        }

        private void Test1_private() {
            Console.WriteLine("Private Method");
        }

        internal void Test2_internal()
        {
            Console.WriteLine("internal Method");
        }

       protected  void Test3_protected()
        {
            Console.WriteLine("protected Method");
        }

        protected internal void Test4_protectedinternal()
        {
            Console.WriteLine("protectedinternal Method");
        }

        public void Test5_public()
        {
            Console.WriteLine("public Method");
        }
        private protected void Test6_PrivateProptected() {
            Console.WriteLine("PrivateProtected Method");
        }
    }
}
