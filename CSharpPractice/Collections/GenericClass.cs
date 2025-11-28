using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Collections
{
    internal class GenericClass<T>
    {
        // generic method
        public T Add(T a, T b) { 
           dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2;
        }

        public T Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 - d2;
        }

        public T Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 * d2;
        }

        public T Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 % d2;
        }
    }
}
