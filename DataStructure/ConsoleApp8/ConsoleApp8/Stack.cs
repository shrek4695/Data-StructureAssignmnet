using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Stack : ICommonFunctionality
    {
        public int[] StackArray = new int[100]; //Array to store address of each node of stack
        public int StackTop=-1; 
        public void AddingValues(int Value)
        {
            //StackNode NodeObject = new StackNode();
            if (StackTop == StackArray.Length - 1)
                Console.WriteLine("Stack Full");
            else
            {
                StackArray[StackTop+1] = Value;
                StackTop++;
            }
        }
        public int RemovingValues()
        {
            int ValueRemoved=0;
            if (StackTop == -1)       //checking if stack is empty
            {
                Console.WriteLine("Stack is Empty");
                ValueRemoved = -1;
            }
            else
            {
                ValueRemoved = StackArray[StackTop];
                StackArray[StackTop] = -1;
                StackTop--;
            }
            return ValueRemoved;
        }
        public void DisplayingValues()
        {
            int index;
            for(index=0;index<=StackTop;index++)
                Console.Write(StackArray[index]+" ");
            Console.WriteLine();
        }
        public void SortingValues()
        {
            int loop1, loop2,SwitchNum;
            for(loop1=0;loop1<StackTop;loop1++)
            {
                for(loop2=loop1;loop2<=StackTop;loop2++)
                {
                   if(StackArray[loop1]>StackArray[loop2])
                    {
                        SwitchNum = StackArray[loop1];
                        StackArray[loop1] = StackArray[loop2];
                        StackArray[loop2] = SwitchNum;
                    }
                }
            }
        }
        public int GettingTopValue()
        {
            return StackArray[StackTop];
        }
        
    }
}
