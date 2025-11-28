using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Collections
{
    internal class NonGeneric
    {
        // Constructor of Stack class
        public NonGeneric()
        {
            Console.WriteLine("NonGeneric Contructor");
        }

        // this is object destructor when object is not longer in user
        ~NonGeneric()
        {
            Console.WriteLine("NonGeneric Finalizer");
        }

        public void stackexecution()
        {
            Stack s = new Stack();
            s.Push(2); s.Push(3); s.Push("Safar");

            //stack will follow LIFO/FILO order

            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Number of items in the stack is" + s.Count);
            s.Pop();
            foreach (var i in s)

            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Number of items in the stack is" + s.Count);
        }

        public void QueueEceution() {

            // Queue follows the FIFO 

            Queue q = new Queue();

            // Adding elements inside the queue
            q.Enqueue(1); q.Enqueue(2); q.Enqueue(3); q.Enqueue(4); q.Enqueue(5);
            q.Enqueue("safar"); q.Enqueue(true);

            // priting queue elements

            foreach (var i in q) {
                Console.WriteLine(i + " ");
            }

            // removing the elemtns from the queue

            q.Dequeue(); // 1 will be removed

            Console.WriteLine("==============================");
            //pritnting after removing the member
            foreach (var i in q)
            {
                Console.WriteLine(i + " ");
            }
        }
        public void ArrayListExecution()
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("initial capacity of arraylist  " +  arrayList.Capacity);
            arrayList.Add("safar");
            Console.WriteLine(" capacity of arraylist after adding 1st element " + arrayList.Capacity);
            arrayList.Add(2); arrayList.Add(3); arrayList.Add(4);
            Console.WriteLine(" capacity of arraylist after adding 4th element " + arrayList.Capacity);

            arrayList.Add(true);

            Console.WriteLine(" capacity of arraylist after adding 5th element " + arrayList.Capacity);

            // it can prove the initial capacity of the arralist collection is -
            // after adding 1st element it will 4 and after that based on the values
            // it doubles it self like 0,4,8,16,32.....


            //printinf arralist elements

            foreach (var i in arrayList) {
                Console.WriteLine(i + " ");
            }

            // removing elemetns from arraylist
            Console.WriteLine("==============================");

            //arrayList.Remove(3);
            //arrayList.RemoveAt(2); // will remove from 2nd index

            arrayList.RemoveRange(2,2);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i + " ");
            }

            // insert in the middle

            arrayList.Insert(2,3);
            Console.WriteLine("==============================");

            foreach (var i in arrayList)
            {
                Console.WriteLine(i + " ");
            }

            ArrayList arrylist1 = new ArrayList(arrayList);
            Console.WriteLine("initial capacity of arraylist1 is :   " + arrylist1.Capacity);

        }
        public void HashtableExecution() { 
           Hashtable hashtable = new Hashtable();
            hashtable.Add("ID",100);
            hashtable.Add("name","safar");
            hashtable.Add("male",true);
            hashtable.Add("marks", 2.34);


            // pritnint hashtable values
            foreach (var i in hashtable) {

                Console.WriteLine(i + " ");
            }

            //have to print this based on the key value pairs

            foreach (var key in hashtable.Keys) {

                Console.WriteLine(key);
                Console.WriteLine(hashtable[key]);
                Console.WriteLine(key + "  " + hashtable[key]);
            }


        
        }
    }


}
