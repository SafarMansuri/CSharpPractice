using CSharpPractice.BasicPrograms;
using CSharpPractice.OOPS;
namespace CSharpPractice
{
    internal class Program
    {
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

            InOutParameters inOutParameters = new InOutParameters();
            int result = inOutParameters.Math(10, 20, out int c);
            Console.WriteLine($"Result is {result} and c is {c}");

            Console.WriteLine("--------------------------------------------------");
            int a = 10;
            int b = 20;
            Console.WriteLine(inOutParameters.MathRef(ref a, ref b));

            Console.WriteLine("--------------------------------------------------");
            (int sum, int mul) = inOutParameters.tuppleMethod(100, 200);
            Console.WriteLine($" sum is {sum} mul is {mul}");
            
            Console.ReadLine();




        }
    }
}
