using CSharpPractice.BasicPrograms;
using CSharpPractice.Collections;
using CSharpPractice.LogicalPrograms;
using CSharpPractice.Loops;
using CSharpPractice.OOPS;
using System.Collections;
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

            //  Constructor constructor3
            //      = new Constructor(10);



            //  Constructor constructor1
            //      = new Constructor();

            //  Constructor constructor2
            //      = new Constructor();
            //  constructor2.Display();
            //  Constructor constructor
            //  = new Constructor();
            //// parameterized constructor

            //Inheritance inheritance = new Inheritance();
            //Inheritance2 inheritance2 = new Inheritance2();
            //inheritance2.Test1();
            //inheritance2.Test2();
            //inheritance2.Test1(2);
            //inheritance2.Test4();
            //inheritance.example();
            //inheritance2.example();

            // Paramss p = new Paramss();
            // var someofnumbers = p.parameters(1,2,3,4,5);

            // Console.WriteLine(someofnumbers);


            // var newparameters = p.parametersWithOtherParam("sum of given numbers",1,2,3,4,5);


            // Console.WriteLine(newparameters);

            // LoopsExample loop = new LoopsExample();
            // loop.PrintUsingForLoop();
            // loop.PrintUsingForInloop();
            // Console.WriteLine();

            //FieldsDemo fields = new FieldsDemo();
            //Console.WriteLine("Fields demo class :-"+ fields.x);
            //Console.WriteLine("Foelds demo age" + fields.age);

            //Console.WriteLine("Fieldsdemo y:-"+ FieldsDemo.y);
            //Console.WriteLine("FieldsDemo const"+ FieldsDemo.PI);
            //// modify the variables
            //fields.x = 1;
            ////fields.age = 2;
            //FieldsDemo.y = 2;
            ////FieldsDemo.PI = 3;
            //Console.Beep();
            //Console.ReadLine();

            // FieldsDemo fields = new FieldsDemo();


            //Polymorsphism polymorsphism = new Polymorsphism();
            //polymorsphism.show();
            //polymorsphism.show(2);
            //polymorsphism.show("safar");

            //AbstractChild abstractChild = new AbstractChild();
            //abstractChild.div(2, 4);
            //abstractChild.mul(3, 5);
            //abstractChild.abstractchildmember();

            //Program1 p = new Program1();
            //p.Test2_internal();
            //p.Test4_protectedinternal();
            //p.Test5_public();

            //// accesssing proptected memebers

            //Program2 p2 = new Program2();
            //p2.Test2_internal();
            //p2.Test4_protectedinternal();
            //p2.Test5_public();
            //p2.callprotected();

            // Logical Programs

            //PrimeNumberTest primeNumberTest = new PrimeNumberTest();
            //primeNumberTest.CheckPrime();

            // NonGeneric s = new NonGeneric();
            //s.stackexecution();
            //s.QueueEceution();
            //s.ArrayListExecution();
            //s.HashtableExecution();

            Generic n = new Generic();
            //Console.WriteLine(n.Genericmethod<int>(2, 2));
            //Console.WriteLine(n.Genericmethod<bool>(true, false));
            //Console.WriteLine(n.Genericmethod<string>("safar", "safar"));
            //Console.WriteLine(n.Genericmethod<double>(2.2, 2));

            //GenericClass<int> genericClass = new GenericClass<int>();
            //Console.WriteLine(genericClass.Add(2, 3));

            //GenericClass<string> genericClass1 = new GenericClass<string>();
            //Console.WriteLine(genericClass1.Add("safar" , "safar"));

            // you can see in above using the same classes we can call the methods
            /// for diffrant datatypes so that is the power of generics
            //n.ListExecution();

            //n.DictionaryExecution();
            //n.ColletioninitializerExample();
            LinqExample example = new LinqExample();
            example.linqExectution();
            Console.ReadLine();

        }

    }
}
