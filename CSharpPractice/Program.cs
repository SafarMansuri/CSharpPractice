using CSharpPractice.BasicPrograms;
using CSharpPractice.OOPS;
namespace CSharpPractice
{
    internal class Program
    {
        // cheking git connection
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*   Arrays array = new Arrays();
               array.PrintArrayElements();*/


            // Printing all 4 method

            /*  OOPSExample1 oOPSExample1 = new OOPSExample1();
              oOPSExample1.Test();
              oOPSExample1.Test(10, 20, out int sum, out int mul);
              int result = oOPSExample1.Test(10, 20);
              Console.WriteLine($"Returned result is {result}");
              int result2 = oOPSExample1.Test(10, 20, out int sum2);
              Console.WriteLine($"Returned result is {result2} and sum is {sum2}");*/


            // Printing user defined types

            /*UserDefinedTypes userDefinedTypes = new UserDefinedTypes();
            Emp emp = userDefinedTypes.getEmpDetailes(101);*/


            // priting in out parameters

            /* InOutParameters inOutParameters = new InOutParameters();
             int result = inOutParameters.Math(10, 20, out int c);
             Console.WriteLine($"Result is {result} and c is {c}");

             Console.WriteLine("--------------------------------------------------");
             int a = 10;
             int b = 20;
             Console.WriteLine(inOutParameters.MathRef(ref a, ref b));

             Console.WriteLine("--------------------------------------------------");
             (int sum, int mul) = inOutParameters.tuppleMethod(100, 200);
             Console.WriteLine($" sum is {sum} mul is {mul}");

             Console.ReadLine();*/
            /* MethodBasics methodBasics = new MethodBasics();
             methodBasics.MethodWithoutParameterWithoutReturnType();
             methodBasics.MethodWithParameterWithoutReturnType(5, 10);
             int returnValue1 = methodBasics.MethodWithoutParameterWithReturnType();
             Console.WriteLine("Return value from method without parameter and with return type: " + returnValue1);
             int returnValue2 = methodBasics.MethodWithParameterWithReturnType(5, 10);
             Console.WriteLine("Return value from method with parameter and with return type: " + returnValue2);
             methodBasics.MethodWithOptionalParameter(5);
             methodBasics.MethodWithNamedParameter(b: 10, a: 5);
             var (sum, product) = methodBasics.MethodWithMultipleReturnType(5, 10);
             Console.WriteLine("Sum: " + sum + ", Product: " + product);
             methodBasics.MethodWithOutParameter(5, 10, out int outSum, out int outProduct);
             Console.WriteLine("Out Sum: " + outSum + ", Out Product: " + outProduct);
             Console.ReadLine();*/

            /* Constructor constructor3
                 = new Constructor(10);



             Constructor constructor1
                 = new Constructor();

             Constructor constructor2
                 = new Constructor();
             constructor2.Display();
             Constructor constructor
             = new Constructor();*/
            // parameterized constructor

            Inheritance inheritance = new Inheritance();
            Inheritance2 inheritance2 = new Inheritance2();
            inheritance2.Test1();
            inheritance2.Test2();
            inheritance2.Test3();
            inheritance2.Test4();
            Console.ReadLine();


        }
    }
}
