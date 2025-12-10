using System;

namespace BridgeLabzConsoleApp.DSA.LinkedList.Doubly
{
    public class DoublyLinkedList
    {
        private DNode? head;

        // Add at end
        public void AddLast(int data)
        {
            DNode newNode = new DNode(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            DNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        // Add at start
        public void AddFirst(int data)
        {
            DNode newNode = new DNode(data);

            newNode.Next = head;
            if (head != null)
                head.Prev = newNode;

            head = newNode;
        }

        // Print forward
        public void PrintForward()
        {
            DNode? temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " <-> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }

        // Print backward
        public void PrintBackward()
        {
            if (head == null) return;

            DNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            while (temp != null)
            {
                Console.Write(temp.Data + " <-> ");
                temp = temp.Prev;
            }
            Console.WriteLine("null");
        }
    }
}
