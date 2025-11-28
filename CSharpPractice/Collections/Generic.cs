using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Collections
{
    internal class Generic
    {
        public Generic() {
            Console.WriteLine("Generic constructor");
        }

        // this is generic method which can compare any datatype
        public bool Genericmethod<T>(T a,T b) {

            if (a.Equals(b))
                return true;
            return false;
        }

        // the collection which we have written earlier in Non geric class we can write 
        // the same with generic nothing but defining stack with some type in it

        /*
           e.g: Stack<int> si = new Stack<int>();
                Stack<float> fi = new Stack<float>();
                Stack<string> ss = new Stack<string>();
         */

        // same like this there is other types as well 

        public void ListExecution() {
            List<int> list = new List<int>();

            list.Add(12);
            // list.Add("safar"); // invalid because expects only integer datas
            list.Add(13);

            list.Add(14);

            list.Add(15);

            list.Add(16);

            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("================");
            foreach (var i in list) {
                Console.WriteLine(i + " ");
             }

            // now removing elements from list;

            list.Remove(11);
            Console.WriteLine("================");
            foreach (var i in list)
            {
                Console.WriteLine(i + " ");
            }

            list.RemoveAt(0);
            Console.WriteLine("================");
            foreach (var i in list)
            {
                Console.WriteLine(i + " ");
            }
           // Thread.Sleep(100);
            list.RemoveRange(2,1);

            Console.WriteLine("================");
            foreach (var i in list)
            {
                Console.WriteLine(i + " ");
            }

        }

        // generic dictionary in c#

        public void DictionaryExecution() {

            Dictionary<string, object> d = new Dictionary<string, Object>();

            d.Add("id", 1001);
            d.Add("name", "safar");

            // priting dictionary values

            foreach (var key in d.Keys) {
                Console.WriteLine(key + " " + d[key]);
            }
        
        }

        public void ColletioninitializerExample() {

            List<int> list = new List<int>() { 10, 20, 30, 40, 50};


            foreach (var i in list) {
                Console.WriteLine(i + " ");
              }
        }
    
    }
}
