using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{
    internal class MethodBasics
    {
        // Here will write all type of methods by my own for understanding purpose

        // 1. Method without parameter and without return type

        public void MethodWithoutParameterWithoutReturnType() {
            Console.WriteLine("This is a method without parameter and without return type");
        }
        // 2. Method with parameter and without return type
        public void MethodWithParameterWithoutReturnType(int a, int b)
        {
            Console.WriteLine("This is a method with parameter and without return type");
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, a + b);
        }
        // 3. Method without parameter and with return type
        public int MethodWithoutParameterWithReturnType()
        {
            Console.WriteLine("This is a method without parameter and with return type");
            return 42; // returning a constant value
        }
        // 4. Method with parameter and with return type
        public int MethodWithParameterWithReturnType(int a, int b)
        {
            Console.WriteLine("This is a method with parameter and with return type");
            return a + b; // returning the sum of two parameters
        }
        // 5. Method with optional parameter
        public void MethodWithOptionalParameter(int a, int b = 10)
        {
            Console.WriteLine("This is a method with optional parameter");
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, a + b);
        }
        // 6. Method with named parameter
        public void MethodWithNamedParameter(int a, int b)
        {
            Console.WriteLine("This is a method with named parameter");
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, a + b);
        }
        // 7. Method with multiple return type
        public (int, int) MethodWithMultipleReturnType(int a, int b)
        {
            Console.WriteLine("This is a method with multiple return type");
            return (a + b, a * b); // returning sum and product of two parameters
        }
        // 8. Method with out parameter
        public void MethodWithOutParameter(int a, int b, out int sum, out int product)
        {
            Console.WriteLine("This is a method with out parameter");
            sum = a + b;
            product = a * b;
        }

        public void paramsmethod(double[] args) {

            Console.WriteLine("params example",args);

        }

     

    }
}
