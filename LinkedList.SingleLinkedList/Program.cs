using System;

namespace LinkedList.SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList singleLinkedList = new();
            singleLinkedList.InsertFirst(1);
            singleLinkedList.InsertFirst(2);
            singleLinkedList.InsertFirst(3);
            singleLinkedList.InsertFirst(4);
            singleLinkedList.InsertFirst(5);
            singleLinkedList.InsertLast(100);
            singleLinkedList.DisplayList();
            singleLinkedList.DeleteFirst();
            singleLinkedList.DisplayList();
        }

        public class SingleLinkedList
        {
            private Node first;

            public bool IsEmpty()
            {
                return first == null;
            }

            public  void InsertFirst(int data)
            {
                Node newNode = new();
                newNode.data = data;
                newNode.next = first;
                first = newNode;
            }

            public Node DeleteFirst()
            {
                Node temp = first;
                first = first.next;
                return temp;
            }

            public void DisplayList()
            {
                Console.WriteLine("List (First -- Last) ");
                Node current = first;
                while (current != null)
                {
                    current.DisplayNode();
                    current = current.next;
                }

                Console.WriteLine();
            }

            public void InsertLast(int data)
            {
                Node current = first;
                while (current.next != null)
                {
                    current = current.next;
                }

                Node newNode = new();
                newNode.data = data;
                current.next = newNode;
            }
        }

        public class Node
        {
            public int data;
            public Node next;

            public void DisplayNode()
            {
                Console.WriteLine("<" + data + ">");
            }
        }
    }
}
