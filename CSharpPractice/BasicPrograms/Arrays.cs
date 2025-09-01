using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.BasicPrograms
{
    internal class Arrays
    {

        public void PrintArrayElements() {

            int[] a = new int[4];
            int element = 0;

            for (int i = 0; i < a.Length; i++) {
                a[i] = element;
                element++;
                 Console.Write(a[i] + " ");
            }

            foreach(int i in a) { Console.WriteLine("foraech"+i); }
        }

        public void PredefinedMethods() {
            int[] arr = {22,44,55,33,3,4,5,6,7,55,4,33,22,1,99,88,77,5,55,44,3,33,22,4,55,6,67 };

            // printing this array elements using foreach
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
            //printing using forloop
            Console.WriteLine("Using forloop");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] +" ");
            Console.WriteLine();
            //sort the array
            Array.Sort(arr);
            Console.Write("sorted array : ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // reversing the array
            Array.Reverse(arr);
            Console.Write("reversed array : ");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}


