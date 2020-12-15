using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedList
{
   public class LinkedList
   {
        internal Node head;

        /// <summary>
        /// U2-U3 Ability to Create Linkedlist.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted Element in list ",node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.Write("LinkedList is Emplty...");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.Write("\n");
        }
        
        /// <summary>
        /// Inserts the positon.
        /// </summary>U4-Insert Element at Particular Position...
        /// <param name="Position">The position.</param>
        /// <param name="data">The data.</param>
        internal void InsertPositon(int Position, int data)
        {
            if (Position < 1)
            {
                Console.WriteLine("...Inalid...");
            }
            if (Position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (Position-- != 0)
                {
                    if (Position == 1)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (Position != 1)
                    Console.WriteLine("Positon is not valid...");
            }
        }

        /// <summary>
        /// Remove the First Element.
        /// </summary>U5-Remove First Element ...
        /// <param name="Position">The position.</param>
        /// <param name="data">The data.</param>
        internal void RemoveFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linklist Empty");
            }
            head = head.next;
        }
    }
}
