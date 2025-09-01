using CSharpPractice.BasicPrograms;
using CSharpPractice.OOPS;
namespace CSharpPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Arrays array = new Arrays();
            array.PrintArrayElements();


            // Printing all 4 method

            OOPSExample1 oOPSExample1 = new OOPSExample1();
            oOPSExample1.Test();
            oOPSExample1.Test(10, 20, out int sum, out int mul);
            int result = oOPSExample1.Test(10, 20);
            Console.WriteLine($"Returned result is {result}");
            int result2 = oOPSExample1.Test(10, 20, out int sum2);
            Console.WriteLine($"Returned result is {result2} and sum is {sum2}");
        }
    }
}
