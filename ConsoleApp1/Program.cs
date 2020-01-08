using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBoilerPlate
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(10);

            s.Push(10);
            s.Push(5);
            s.Push(30);
            s.Push(40);
            s.Push(100);
            s.Push(50);
            s.Push(1);
            s.Push(8);
            s.Push(45);
            s.Push(55);
            s.printStack();
            s.Pop();
        }
    }
}
