using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Loops;
namespace ReferanceProject.Classess
{
    internal class Program3 : Program1
    {
        public void accessmehod() { 
            Program3 p3 = new Program3();
            p3.Test3_protected();
            p3.Test4_protectedinternal();
            p3.Test5_public();
        }

    }
}
