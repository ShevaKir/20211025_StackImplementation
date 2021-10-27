using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211025_StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            
            stack.Push(2);
            stack.Push(3);
            stack.Push(6);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            if(stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }

            MyStack<double> myStack = new MyStack<double>();

            myStack.Push(2.23);
            myStack.Push(33.2);

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            if(!myStack.IsEmpty)
            {
                Console.WriteLine(myStack.Pop());
            }


            Console.ReadKey();
        }
    }
}
