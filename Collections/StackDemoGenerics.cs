using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class StackGenerics
    {
        public StackGenerics()
        {
            Console.WriteLine("stack demo for generics :");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);   // it is used to insert a element at the top of the stack
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Peek(); // it returns the top element of the stack
            stack.Contains(3);  // it is used to check the element is present in stack 
            foreach (int i in stack)
            {
                stack.Push(i);    // used to print the elements of stack 
            }
            stack.Pop();       // it is used to remove the element of the top of the stack and return it 
            foreach (int i in stack)
            {
                stack.Push(i);    // used to print the elements of stack 
            }


        }

    }
}
