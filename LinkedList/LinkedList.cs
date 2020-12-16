using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedList
{
    public class LinkedLists
    {
        internal Node head;

        /// <summary>
        /// U2-U3 Ability to Create Linkedlist.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(int data)
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
            Console.WriteLine("{0} Inserted Element in list ", node.data);
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
        /// </summary>U8-Insert 40 between 30 70 result like 30-->40-->70...
        /// <param name="Position">The position.</param>
        /// <param name="data">The data.</param>
        public void InsertPositon(int Position, int data)
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

        /// <summary>
        /// Remove the Last Element.
        /// </summary>U6-Remove Last Element ...
        /// <param name="Position">The position.</param>
        /// <param name="data">The data.</param>
        internal void RemoveLastElement()
        {
            if (head.next == null)
            {
                Console.WriteLine("Empty");
            }
            Node SecondNode = head;
            while (SecondNode.next.next != null)
                SecondNode = SecondNode.next;
            SecondNode.next = null;
        }

        /// <summary>
        ///U7 Finds the elemnt.
        /// </summary>
        /// <param name="Pointer">The pointer.</param>
        /// <returns></returns>
        public Node FindElemnt(int Number)
        {
           /* bool flag = true;
            int count = 1;
            Node temp = head;
            while (flag)
            {
                if (temp.data == Number)
                {
                    flag = false;
                }
                else
                {
                    temp = temp.next;
                    count++;
                }
                return count;
            }*/
            while (this.head != null)
            {
                if (this.head.data == Number)
                {
                    return this.head;
                }
                this.head = this.head.next;
                Console.WriteLine("Element {0} Found in list...", this.head.data);
            }
            return null;
        }
    }
}