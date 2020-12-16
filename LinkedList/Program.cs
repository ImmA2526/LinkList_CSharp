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
            linklist.Display();
            linklist.DeleteNode(40);
            Console.WriteLine("After Deletion ");
            linklist.Display();
            Console.WriteLine("Linkelist Size " +linklist.Count());
        }
    }
}
