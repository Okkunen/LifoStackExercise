using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifoStackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code for testing
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.ReadLine();
            //stack.Clear();
            Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }
    }
}
