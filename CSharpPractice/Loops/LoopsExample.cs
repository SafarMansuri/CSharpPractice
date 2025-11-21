using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Loops
{
    internal class LoopsExample
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        //print array elements using diffrant loops

        public void PrintUsingForLoop() {

            for (int i = 0; i < arr.Length; i++) { 
            
                    Console.WriteLine(arr[i]);
            }
        }

        public void PrintUsingForInloop() {
        
          foreach(int item in arr)
            { 
              Console.WriteLine(item);
            }
        }
    }
}
