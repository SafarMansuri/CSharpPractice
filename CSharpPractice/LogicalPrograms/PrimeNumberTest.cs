using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.LogicalPrograms
{
    internal class PrimeNumberTest
    {

        public void CheckPrime()
        {
            uint number;
            Console.WriteLine("Enter a positive integer: ");
            number = Convert.ToUInt32(Console.ReadLine());


            if (number == 0 || number == 1)
            {
                Console.WriteLine("Please Enter a value more than 0 and 1");
                return;
            }
            bool isPrime = true;
            uint halfnumber = number / 2;



        }

    }

}
