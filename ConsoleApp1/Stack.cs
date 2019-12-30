using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBoilerPlate
{
    //Stack Class
    class Stack
    {
        //Static for Max Capacity of Stack
        //"readonly" Makes MAX Unable to be Changed
        static readonly int MAX = 1000;

        //Holds the Place for Each Interger 
        int top;

        //Creating Stack of Intergers
        int[] stack = new int[MAX];

    }
}
