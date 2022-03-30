using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class CheckDS
    {
        public void CheckLinkedList()
        {
            Linked_List<int> myList = new Linked_List<int>();
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);
            myList.Add(60);
            myList.Add(70);
            myList.Add(80);

            Console.WriteLine("Before Adding");
            myList.Display();
            myList.Add(100, 3);
            Console.WriteLine("After Adding");
            myList.Display();

            myList.Remove(4);
            Console.WriteLine("After Removing");
            myList.Display();

            Console.WriteLine("****************************************");

            Linked_List<string> myListStr = new Linked_List<string>();
            myListStr.Add("Kiran");
            myListStr.Add("Kumar");
            myListStr.Add("Karan");
            myListStr.Add("Kavan");
            myListStr.Add("Kavith");
            myListStr.Add("Keren");

            myListStr.Display();
            Console.WriteLine("****************************************");
        }

        public void CheckStack()
        {
            My_Stack<int> myStack = new My_Stack<int>();
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            myStack.Push(60);
            myStack.Push(70);
            myStack.Push(80);
        }

        public void CheckQueue()
        {
           MyQueue<int> myqueue = new MyQueue<int>();
            myqueue.Enqueue(20);
            myqueue.Enqueue(30);
            myqueue.Enqueue(40);
            myqueue.Enqueue(50);
            myqueue.Enqueue(60);
            myqueue.Enqueue(70);
            myqueue.Enqueue(80);
            myqueue.Enqueue(90);

            myqueue.Show();



        }
    } 
}
