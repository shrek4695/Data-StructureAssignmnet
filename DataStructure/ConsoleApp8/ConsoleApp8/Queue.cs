using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Queue:ICommonFunctionality
    {
        public int front=-1, rear=-1;
        public int[] QueueArray = new int[100];

        public void AddingValues(int Value)
        {
            //StackNode NodeObject = new StackNode();
            if (rear == -1)
                front++;
            QueueArray[rear + 1] = Value;
            rear = rear + 1;
        }
        public int RemovingValues()
        {
            int ValueRemoved = 0;
            if (front == -1)       //checking if stack is empty
            {
                Console.WriteLine("Queue is Empty");
                ValueRemoved = -1;
            }
            else
            {
                ValueRemoved = QueueArray[front];
                if (front == rear)
                {
                    front--;
                    rear--;
                }
            }
            return ValueRemoved;
        }
        public void DisplayingValues()
        {
            int index;
            for (index = front; index <= rear; index++)
                Console.Write(QueueArray[index] + " ");
            Console.WriteLine();
        }
        public void SortingValues()
        {
            int loop1, loop2, SwitchNum;
            for (loop1 = front; loop1 < rear ; loop1++)
            {
                for (loop2 = loop1; loop2 <=rear ; loop2++)
                {
                    if (QueueArray[loop1] < QueueArray[loop2])
                    {
                        SwitchNum = QueueArray[loop1];
                        QueueArray[loop1] = QueueArray[loop2];
                        QueueArray[loop2] = SwitchNum;
                    }
                }
            }
        }
        public int peek()
        {
            return QueueArray[front];
        }
        public Boolean isFull()
        {
            if (rear == QueueArray.Length - 1)
                return true;
            else
                return false;
        }
        public Boolean isEmpty()
        {
            if (front == -1)
                return true;
            else
                return false;
        }
        
    }
}

