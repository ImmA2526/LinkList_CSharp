using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Welcome To LinkelistProgram**************");
        	LinkedLists linklist = new LinkedLists();
            linklist.Add(56);
            linklist.Add(30);
            linklist.Add(70);
            linklist.Add(40);
            Console.Write("list Elements Are : ");
            linklist.Display();
            linklist.FindElemnt(30);
            linklist.Display();
            linklist.InsertPositon(3, 40);
            Console.Write("After Insertion ");
            linklist.Display();
            linklist.DeleteNode(40);
            Console.Write("After Deletion ");
            linklist.Display();
            linklist.SortedList(56);
            linklist.SortedList(30);
            linklist.SortedList(70);
            linklist.SortedList(40);
            Console.Write("Sorted List is :");
            linklist.Display1();
            Console.WriteLine("Linkelist Size " +linklist.Count());
        }
    }
}
