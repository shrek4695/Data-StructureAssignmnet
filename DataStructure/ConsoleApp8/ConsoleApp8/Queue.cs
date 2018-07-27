using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Queue:ICommonFunctionality
    {
        public int front, rear;
        public int[] QueueArray = new int[100];

        public void AddingValues(int Value)
        {
            //StackNode NodeObject = new StackNode();
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
            //Sorting Code
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
        public void QueueMenu()
        {
            int UserChoice;
            Queue QueueObject = new Queue();
            do
            {
                Console.Clear();
                Console.WriteLine("Queue Menu");
                Console.WriteLine("1-EnQueue");
                Console.WriteLine("2-DeQueue");
                Console.WriteLine("3-Display Elements of Queue");
                Console.WriteLine("4-Sort Elements of Queue");
                Console.WriteLine("5-Print Element at Front in Queue");
                Console.WriteLine("6-Check if Queue is Full");
                Console.WriteLine("7-Check if Queue is Empty");
                Console.WriteLine("8-Go Back To Main Menu");
                Console.WriteLine("Enter Your Choice");
                UserChoice = int.Parse(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1:
                        Console.WriteLine("Enter Element to be Inserted");
                        int AddValue = int.Parse(Console.ReadLine());
                        QueueObject.AddingValues(AddValue);
                        Console.WriteLine("Value Added in Stack");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        int ValueRemoved = QueueObject.RemovingValues();
                        Console.WriteLine("Value Removed is " + ValueRemoved);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        QueueObject.DisplayingValues();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Stack Before Sorting");
                        QueueObject.DisplayingValues();
                        QueueObject.SortingValues();
                        Console.WriteLine("Stack After Sorting");
                        QueueObject.DisplayingValues();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Front Value=" + QueueObject.peek());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        if (QueueObject.isFull())
                            Console.WriteLine("Queue is Full");
                        else
                            Console.WriteLine("Queue is not Full");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        if (QueueObject.isEmpty())
                            Console.WriteLine("Queue is Empty");
                        else
                            Console.WriteLine("Queue is not Empty");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("Exiting Queue Menu");
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid Input. Please Try Again");
                        Console.Clear();
                        break;
                }
            } while (UserChoice != 8);
        }
    }
}

