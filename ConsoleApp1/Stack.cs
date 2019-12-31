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

        //Method To Check if the Stack is Empty
        bool IsEmpty()
        {
            return (top < 0);
        }

        //Constructer
        public Stack()
        {
            top = -1;
        }

        //Method to Push Data into the Stack
        bool Push(int data)
        {
            //Checks if Stack is Full
            if(top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }

            //If not full Push Data on to the top 
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        //Method to Remove or "Pop" top Element off Stack
        int Pop()
        {
            //Check if Stack has Data
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }

            //Removes Data from Top of the Stack
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        //Method to Check what the Top Element Is without Removing it
        void Peek()
        {
            //Checks if Stack has Data in it
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            //Prints the Top Element in the Stack
            else
            {
                Console.WriteLine("The Top Element in the Stack is : {0}", stack[top]);
            }
        }

      void sortStackTmp()
        {
            Stack input = new Stack();

            Stack tempStack = new Stack();
            while (input.C != 0)
            {
               
            }
        }
    }
}
