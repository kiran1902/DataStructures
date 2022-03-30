using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class MyQueue<Gtype>
    {
        Node<Gtype> front;
        Node<Gtype> rare;

        ///<summary>
        ///Queue class constructor to initilize variables front and rate
        ///</summary>
        public MyQueue()
        {
            this.front = null;
            this.rare = null;
        }

        ///<summary>
        ///Method to create node and add elements
        ///</summary>
        public void Enqueue(Gtype data)
        {
            //creating a node
            Node<Gtype> node = new Node<Gtype>(data);

            if (rare == null)
            {
                rare = node;
                front = node;
            }
            else
            {
                rare.next = node;
                rare = node;
            }
        }

        ///<summary>
        ///Method to display
        ///</summary>
        public void Show()
        {
            //variables
            Node<Gtype> temp = front;
            //traverse from last to first and print elements 
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.val + " ");
                    temp = temp.next;

                }
                Console.WriteLine(temp.val);
            }
        }

        ///<summary>
        ///Method to delete element from the queue
        ///</summary>
        public Gtype Dequeue()
        {
            //variable
            Node<Gtype> temp;

            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return default(Gtype);
            }
            else
            {
                temp = front;

                if (front.next == null)
                {
                    front = null;
                }
                else
                {
                    temp = front.next;
                }
                return temp.val;
            }

        }

        ///<summary>
        ///Method to check the queue
        ///</summary>
        public bool IsEmpty()
        {
            if (front is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
