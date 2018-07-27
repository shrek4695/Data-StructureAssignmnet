using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkList:ICommonFunctionality
    {
        LinkListNode Head;
        public void AddingValues(int Value)
        {
            LinkListNode CurrentNode = new LinkListNode();
            LinkListNode TempNode = new LinkListNode();
            CurrentNode = Head;
            TempNode.next = null;
            TempNode.DataValue = Value;
            if (Head==null)
            {
                Head = TempNode;
            }
            else
            {
                CurrentNode = Head;
                while(CurrentNode.next!=null)
                {
                    CurrentNode = CurrentNode.next;
                }
                CurrentNode.next = TempNode;
            }
        }
        public int RemovingValues()
        {
            LinkListNode CurrentNode = new LinkListNode();
            int DeletedValue = 0;
            CurrentNode = Head;
            if (CurrentNode == null)
            {
                Console.WriteLine("Link List is Empty");
                return -1;
            }
            else if (CurrentNode.next == null)
            {
                DeletedValue = CurrentNode.DataValue;
                Head = null;
                return DeletedValue;
            }
            else
            {
                while ((CurrentNode.next).next != null)
                {
                    CurrentNode = CurrentNode.next;
                }
                DeletedValue = CurrentNode.next.DataValue;
                CurrentNode.next = null;
                return DeletedValue;
            }
        }
        public void DisplayingValues()
        {
            LinkListNode CurrentNode = new LinkListNode();
            CurrentNode = Head;
            while(CurrentNode!=null)
            {
                Console.Write(CurrentNode.DataValue+" ");
                CurrentNode = CurrentNode.next;
            }
            Console.WriteLine();
        }
        public void SortingValues()
        {
            int counter = 0;
            LinkListNode Current = new LinkListNode();
            Current = Head;
            int[] ElementsArray = new int[100];
            while (Current != null)
            {
                ElementsArray[counter] = Current.DataValue;
                counter++;
                Current = Current.next;
            }
            
            int loop1, loop2, SwitchNum;
            for (loop1 = 0; loop1 < counter; loop1++)
            {
                for (loop2 = loop1; loop2 <=counter; loop2++)
                {
                    if (ElementsArray[loop1] < ElementsArray[loop2])
                    {
                        SwitchNum = ElementsArray[loop1];
                        ElementsArray[loop1] = ElementsArray[loop2];
                        ElementsArray[loop2] = SwitchNum;
                    }
                }
            }
            Current = Head;
            int co = 0;
            while(co<counter)
            {
                Current.DataValue = ElementsArray[co];
                co++;
                Current = Current.next;
            }
        }

        public void InsertAtSpecificLocation(int Value, int Position)
        {
            int counter = 1;
            LinkListNode CurrentNode = new LinkListNode();
            CurrentNode = Head;
            while(counter<Position)
            {
                CurrentNode = CurrentNode.next;
                counter++;
            }
            LinkListNode NewNode = new LinkListNode();
            NewNode.DataValue = Value;
            NewNode.next = CurrentNode.next;
            CurrentNode.next = NewNode;
        }
        public int DeleteFromSpecificPosition(int Position)
        {
            int counter = 1, DeletedValue = 0;
            LinkListNode CurrentNode = new LinkListNode();
            CurrentNode = Head;
            while(counter<(Position-1))
            {
                  CurrentNode = CurrentNode.next;
                if (CurrentNode == null)
                {
                    Console.WriteLine("Invalid Position");
                    return -1;
                }
                counter++;
            }
            DeletedValue = CurrentNode.next.DataValue;
            CurrentNode.next = CurrentNode.next.next;
            return DeletedValue;
        }

    }
}
