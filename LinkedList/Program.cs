using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Welcome To LinkelistProgram**************");
        	LinkedList linklist = new LinkedList();
            linklist.Add(56);
            linklist.Add(30);
            linklist.Add(70);
            linklist.Add(120);
            Console.Write("list Elements Are : ");
            linklist.Display(); 
            linklist.InsertPositon(4, 110);
            linklist.Display(); 
        }
    }
}
