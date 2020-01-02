using System;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Earl Platt III
/// Implementing a Stack
/// Visual Studio 2019
/// </summary>


namespace StackBoilerPlate
{
    //Stack Class
    class Stack
    {
        //Variable Declaration 
        #region
        //Static for Max Capacity of Stack
        //"readonly" Makes MAX Unable to be Changed
        static readonly int MAX = 1000;

        //Holds the Place for Each Interger 
        int top;

        //Creating Stack of Intergers
        int[] stack = new int[MAX];
        #endregion

        //Constructer
        #region
        public Stack()
        {
            top = -1;
        }
        #endregion

        //Methods
        #region
        //Method To Check if the Stack is Empty
        bool IsEmpty()
        {
            return (top < 0);
        }

        //Method to Push Data into the Stack
        bool Push(int data)
        {
            //Checks if Stack is Full
            if (top >= MAX)
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
            if (top < 0)
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
        int Peek()
        {
            //Checks if Stack has Data in it
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }

            //Prints the Top Element in the Stack
            else
            {
                Console.WriteLine("The Top Element in the Stack is : {0}", stack[top]);
                return stack[top];
            }
        }

        //Method to Print Items in the Stack
        void printStack()
        {
            //Checks if the Stack has Data in it
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
                
            }

            //If there is Data in the Stack Prints Stack
            else
            {
                Console.WriteLine("Items in the Stack are: ");
                
                for(int i = top; i >= 0; i--)
                {
                    Console.Write(stack[i] + " ");
                }
            }
        }
        #endregion
    }
}
