using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList:LinkListNode,ICommonFunctionality
    {
        LinkListNode Head;
        public void AddingValues(int Value)
        {
            LinkListNode CurrentNode = new LinkListNode();
            LinkListNode TempNode = new LinkListNode();
            TempNode.next = null;
            TempNode.prev = null;
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
                TempNode.prev = CurrentNode;
            }
        }
        public int RemovingValues()
        {
            LinkListNode CurrentNode = new LinkListNode();
            int DeletedValue=0;
            CurrentNode = Head;
            if (CurrentNode == null)
                Console.WriteLine("Link List is Empty");
            else if (CurrentNode.prev == null && CurrentNode.next == null)
            {
                DeletedValue = CurrentNode.DataValue;
                Head = null;
                return DeletedValue;
            }
            else
            {
                while (CurrentNode.next != null)
                {
                    CurrentNode= CurrentNode.next;
                }
                DeletedValue = CurrentNode.DataValue;
                CurrentNode = CurrentNode.prev;
                CurrentNode.next = null;
            }
                return DeletedValue;
        }
        public void DisplayingValues()
        {
            LinkListNode CurrentNode = new LinkListNode();
            CurrentNode = Head;
            while(CurrentNode.next!=null)
            {
                Console.Write(CurrentNode.DataValue+" ");
                CurrentNode = CurrentNode.next;
            }
            Console.WriteLine();
        }
        public void SortingValues()
        {
            //sorting code
        }
        private void InsertAtSpecificLocation(int Value, int Position)
        {
            int counter = 0;
            LinkListNode CurrentNode = new LinkListNode();
        }
    }
}
