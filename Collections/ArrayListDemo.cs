using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ArrayListDemo
    {
        public ArrayListDemo()
        {
            Console.WriteLine("array list demo");
            ArrayList list = new ArrayList();
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(300);
            list.Add(344);

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
