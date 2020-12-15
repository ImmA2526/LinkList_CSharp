using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedList
{
   public class LinkedList
   {
        internal Node head;

        /// <summary>
        /// U2 Ability to Create Linkedlist.
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
    }
}
