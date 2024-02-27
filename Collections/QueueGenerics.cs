using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class QueueGenerics
    {
        public QueueGenerics()
        {
            Console.WriteLine("queue generic demo");
            // declaration of queue
            Queue<String> CallerName = new Queue<string>();
            CallerName.Enqueue("jayanth");
            CallerName.Enqueue("rajesh");
            CallerName.Enqueue("gopal");      // used for addaing the data into the queue
            CallerName.Enqueue("ravi");
            CallerName.Enqueue("somesh");
            Console.WriteLine(CallerName.Count());  //Returns the  count of elements in the Queue.
            CallerName.Contains("jayanth");   // returns the element is present in the queue.
            Console.WriteLine(CallerName.Peek());  //Returns an first item from the queue without removing it.
            foreach (var item in CallerName)
            {
                Console.WriteLine(item);  //for prenting the elemenys in queue
            }
            CallerName.Dequeue();  // it is used to Returns an item from the beginning of the queue and removes it from the queue.
            foreach (var item in CallerName)
            {
                Console.WriteLine(item);  //for prenting the elemenys in queue
            }

        }
    }
}
