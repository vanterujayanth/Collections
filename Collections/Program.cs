using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Collections;

namespace inheritancedemo.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSetDemo h1 = new HashSetDemo();
            DictionaryDemo d1 = new DictionaryDemo();
            ArrayListDemo a1 = new ArrayListDemo();
            HashSetDemo h2 = new HashSetDemo();
            Hashtable h3 = new Hashtable();
            ListDemo l1 = new ListDemo();
            QueueGenerics q1 = new QueueGenerics();
            SortedListDemo s1 = new SortedListDemo();

            SortedListGenerics s2 = new SortedListGenerics();
            StackDemo s3 = new StackDemo();
            StackGenerics s4 = new StackGenerics();

        }
    }
}