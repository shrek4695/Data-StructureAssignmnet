using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class DesignClass
    {
        Stack StackObject = new Stack();
        Queue QueueObject = new Queue();
        LinkList LinkListObject = new LinkList();
        //DesignClass DesignObject = new DesignClass();
        public void StackMenu()
        {
            int UserChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("Stack Menu");
                Console.WriteLine("1-PUSH");
                Console.WriteLine("2-POP");
                Console.WriteLine("3-Display Elements of Stack");
                Console.WriteLine("4-Sort Elements in Stack");
                Console.WriteLine("5-Print Stack Top Value");
                Console.WriteLine("6-Go Back To Main Menu");
                Console.WriteLine("Enter Your Choice");
                UserChoice = int.Parse(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1:
                        Console.WriteLine("Enter Element to be Inserted");
                        int AddValue = int.Parse(Console.ReadLine());
                        StackObject.AddingValues(AddValue);
                        Console.WriteLine("Value Added in Stack");
                        //Console.ReadLine();
                        break;
                    case 2:
                        int ValueRemoved = StackObject.RemovingValues();
                        Console.WriteLine("Value Removed is " + ValueRemoved);
                        break;
                    case 3:
                        StackObject.DisplayingValues();
                        Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Stack Before Sorting");
                        StackObject.DisplayingValues();
                        StackObject.SortingValues();
                        Console.WriteLine("Stack After Sorting");
                        StackObject.DisplayingValues();
                        break;
                    case 5:
                        Console.WriteLine("Top Value=" + StackObject.GettingTopValue());
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Exiting Stack Menu");
                        //Console.ReadLine();
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid Input. Please Try Again");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (UserChoice != 6);

        }

        public void QueueMenu()
        {
            int UserChoice;
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
                        Console.WriteLine("Value Added in Queue");
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 2:
                        int ValueRemoved = QueueObject.RemovingValues();
                        Console.WriteLine("Value Removed is " + ValueRemoved);
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 3:
                        QueueObject.DisplayingValues();
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Stack Before Sorting");
                        QueueObject.DisplayingValues();
                        QueueObject.SortingValues();
                        Console.WriteLine("Stack After Sorting");
                        QueueObject.DisplayingValues();
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Front Value=" + QueueObject.peek());
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 6:
                        if (QueueObject.isFull())
                            Console.WriteLine("Queue is Full");
                        else
                            Console.WriteLine("Queue is not Full");
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 7:
                        if (QueueObject.isEmpty())
                            Console.WriteLine("Queue is Empty");
                        else
                            Console.WriteLine("Queue is not Empty");
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("Exiting Queue Menu");
                        //Console.ReadLine();
                        //Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid Input. Please Try Again");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (UserChoice != 8);
        }

        public void LinkListMenu()
        {
            int UserChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("Link List Menu");
                Console.WriteLine("1-Append List");
                Console.WriteLine("2-Delete from Link List");
                Console.WriteLine("3-Display Elements of Link List");
                Console.WriteLine("4-Sort Elements of Link List");
                Console.WriteLine("5-Insert at Specific Position");
                Console.WriteLine("6-Delete from Speicific Position");
                Console.WriteLine("7-Go Back To Main Menu");
                Console.WriteLine("Enter Your Choice");
                UserChoice = int.Parse(Console.ReadLine());
                switch (UserChoice)
                {
                    case 1:
                        Console.WriteLine("Enter Element to be added");
                        int Value = int.Parse(Console.ReadLine());
                        LinkListObject.AddingValues(Value);
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 2:
                        int DeletedValue = LinkListObject.RemovingValues();
                        Console.WriteLine("Deleted Value=" + DeletedValue);
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 3:
                        LinkListObject.DisplayingValues();
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Elements before Sorting");
                        LinkListObject.DisplayingValues();
                        Console.WriteLine("Elements after Sorting");
                        LinkListObject.SortingValues();
                        LinkListObject.DisplayingValues();
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Value to be inserted");
                        int Val = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Position");
                        int Position = int.Parse(Console.ReadLine());
                        LinkListObject.InsertAtSpecificLocation(Val, Position);
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 6:
                        int DelValue;
                        Console.WriteLine("Enter the position for deletion");
                        int Pos = int.Parse(Console.ReadLine());
                        DelValue = LinkListObject.DeleteFromSpecificPosition(Pos);
                        Console.WriteLine("Deleted Value=" + DelValue);
                        //Console.ReadLine();
                        //Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Exiting Link List Menu");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid Input.Please Try Again");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }
            } while (UserChoice != 7);
        }

        public static void Main(String[] args)
        {
            DesignClass DesignObject = new DesignClass();
            int UserChoice;
            do
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1-Stack Operation");
                Console.WriteLine("2-Queue Operations");
                Console.WriteLine("3-Link List Operations");
                Console.WriteLine("4-Exit");
                Console.WriteLine("Enter the User Choice");
                UserChoice = int.Parse(Console.ReadLine());
                switch (UserChoice)
                {
                    case 1:
                       DesignObject.StackMenu();
                        break;
                    case 2:
                        DesignObject.QueueMenu();
                        break;
                    case 3:DesignObject.LinkListMenu();
                        break;
                    case 4:
                        Console.WriteLine("Thank You");
                        break;
                    default:
                        Console.WriteLine("Invalid Object");
                        break;
                }
            } while (UserChoice != 4);
        }
    }
}

