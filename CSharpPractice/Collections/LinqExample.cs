using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Collections
{
    internal class LinqExample
    {

        public void linqExectution() {
            List<int> list;
            list = new List<int>() { 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93, 6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };
            
            // printing list elements
            foreach (var item in list) { 
              Console.WriteLine(item);
            }

            var lists = from i in list where i > 40 orderby i ascending select i;

            Console.WriteLine(String.Join(", ", lists));
        }

        public void linqExectution2()
        {
            string[] colors = { "Red", "Blue", "Green", "Black", "White", "Brown", "Orange", "Purple", "Yellow", "Aqua" };

            var color = from i in colors select i;
            Console.WriteLine(String.Join(", ",color));

            // get the list of order in ascending order
            var color2 = from i in colors orderby i ascending select i;
                        Console.WriteLine(String.Join(", ", color2));

            var color3 = from i in color orderby i descending select i;
            Console.WriteLine(String.Join(", ", color3));
        }
    }
}
