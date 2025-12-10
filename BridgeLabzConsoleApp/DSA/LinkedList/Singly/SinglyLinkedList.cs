using System;

namespace BridgeLabzConsoleApp.DSA.LinkedList.Singly
{
    public class SinglyLinkedList
    {
        private Node? head;

        // Add at end
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        // Add at start
        public void AddFirst(int data)
        {
            Node newNode = new Node(data)
            {
                Next = head
            };
            head = newNode;
        }

        // Delete by value
        public void Delete(int value)
        {
            if (head == null)
                return;

            if (head.Data == value)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Data != value)
                temp = temp.Next;

            if (temp.Next != null)
                temp.Next = temp.Next.Next;
        }

        // Print list
        public void Print()
        {
            Node? temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }
}
