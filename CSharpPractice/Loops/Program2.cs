using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Loops
{
    internal class Program2 : Program1
    {

        public void callprotected() {
            Test3_protected();
            Program2 p2 = new Program2();
            p2.Test3_protected();
        }
    }
}
