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
        public void StackMenu()
        {
            int UserChoice;
            do
            {
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
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        int ValueRemoved = StackObject.RemovingValues();
                        Console.WriteLine("Value Removed is " + ValueRemoved);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        StackObject.DisplayingValues();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Stack Before Sorting");
                        StackObject.DisplayingValues();
                        StackObject.SortingValues();
                        Console.WriteLine("Stack After Sorting");
                        StackObject.DisplayingValues();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Top Value=" + StackObject.GettingTopValue());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Exiting Stack Menu");
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid Input. Please Try Again");
                        Console.Clear();
                        break;
                }
            } while (UserChoice != 6);

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
                Console.WriteLine("3-Linked List Operations");
                Console.WriteLine("4-Exit");
                Console.WriteLine("Enter the User Choice");
                UserChoice = int.Parse(Console.ReadLine());
                switch (UserChoice)
                {
                    case 1:
                        DesignObject.StackMenu();
                        break;
                    case 2:
                        
                        DesignObject.QueueObject.QueueMenu();
                        break;
                    case 3: break;
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

