using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class linkedlist
    {
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedList<T>
        {
            private Node<T> head;

            public LinkedList()
            {
                head = null;
            }

            // Add a new node at the end
            public void Insert(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node<T> current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }


            // Remove a node by value
            public void Remove(T data)
            {
                if (head == null)
                {
                    Console.WriteLine("List is empty.");
                    return;
                }

                if (head.Data.Equals(data))
                {
                    head = head.Next;
                    return;
                }

                Node<T> current = head;
                Node<T> previous = null;

                while (current != null && !current.Data.Equals(data))
                {
                    previous = current;
                    current = current.Next;
                }

                if (current == null)
                {
                    Console.WriteLine("Item not found.");
                }
                else
                {
                    previous.Next = current.Next;
                }
            }


            // Display the list
            public void Display()
            {
                if (head == null)
                {
                    Console.WriteLine("List is empty.");
                    return;
                }

                Node<T> current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
        }

    }
}
