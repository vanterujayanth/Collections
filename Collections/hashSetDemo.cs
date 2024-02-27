using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class HashSetDemo
    {
        public HashSetDemo()
        {
            Console.WriteLine("hash set demo :");
            HashSet<int> Even = new HashSet<int>(); // declaration of hash set
            HashSet<int> Odd = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                Even.Add(i * 2);  // to Add even numbers
                Odd.Add((i * 2) + 1);  // to add odd numbers 
            }
            Console.WriteLine("even numbers :");
            foreach (int i in Even)
            {
                Console.Write(i + ",");  // to print even numbers 
            }
            Console.WriteLine();
            Console.WriteLine("odd numbers :");
            foreach (int i in Odd)
            {
                Console.Write(i + ",");  // to print odd numbers 
            }
            Console.WriteLine();
            HashSet<int> Numbers = new HashSet<int>(Even);
            Numbers.UnionWith(Odd);
            Console.WriteLine("all numbers :");
            foreach (int i in Numbers)
            {
                Console.Write(i + ",");  // to print all numbers 
            }
            Console.WriteLine();
            Numbers.IntersectWith(Even);
            Console.WriteLine("intyerscept numbers");
            foreach (int i in Numbers)
            {
                Console.Write(i + ",");  // to print only interscept  numbers 
            }
        }
    }
}
