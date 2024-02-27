using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DictionaryDemo
    {
        public DictionaryDemo()
        {
            Console.WriteLine("dictonary demo :");
            Dictionary<int, string> dic = new Dictionary<int, string>(); // declaration 
            dic.Add(1, "one");
            dic.Add(2, "two");
            dic.Add(3, "three");
            dic.Add(4, "four");
            dic.Add(5, "five");     // for addting the values 
            dic.Add(6, "six");
            dic.Add(7, "seven");

            foreach (var item in dic)     // for writeing down the data 
            {
                Console.WriteLine(item.Value + "  :  " + item.Key);
            }
            dic.Remove(1);    // removeing the set of elements 
            foreach (var item in dic)
            {
                Console.WriteLine(item.Value + "  :  " + item.Key);
            }

        }
    }
}
