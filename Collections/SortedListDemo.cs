using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class SortedListDemo
    {
        public SortedListDemo()
        {
            Console.WriteLine("sorted list demo for non generics :");

            SortedList sortedList = new SortedList();
            Console.WriteLine(" the capacity of sorted list :" + sortedList.Capacity); //v to find the capacity 
            sortedList.Add(121, "one two one");
            sortedList.Add(12, "one two ");    // here i  inserted the values
            sortedList.Add(1, "one");
            sortedList.Add(2, 12.2);
            sortedList.Add(4, 234);

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);  // here i will get a sorted  order 
            }

            sortedList.Remove(1); // remove of one pair of (key  and value) can be done by using key or value
        }

    }
}
