using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Collections
{
    internal class LinqExample
    {

        public void linqExectution() {
            List<string> list;
            list = new List<string>() {"a","b","c" };

            list.RemoveAt(2);
            
            foreach (var item in list) { 
              Console.WriteLine(item);
            }


        }
    }
}
