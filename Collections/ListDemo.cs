using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ListDemo
    {
        public ListDemo()
        {
            Console.WriteLine("list demo :");
            List<int> list = new List<int>();
            list.Add(20);
            list.Add(3);
            list.Add(40);
            list.Add(3);
            list.Add(344);
            list.Add(10);
            //foreach (int x in list)
            //{
            //    var l1 = list.Find(x => (x % 2 == 0));
            //    Console.WriteLine(l1);
            //}

            Console.WriteLine(list.Capacity);
            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine();
            list.RemoveAt(3);
            foreach (var item in list)
                Console.Write(item + " ");
            Console.ReadLine();
        }
    }
}
