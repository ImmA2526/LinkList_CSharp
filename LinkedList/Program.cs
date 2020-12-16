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
            Console.Write("list Elements Are : ");
            linklist.Display(); 
            linklist.FindElemnt(30);
            linklist.Display();
        }
    }
}
