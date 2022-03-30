using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class My_Stack<Gtype>
    {
        //variables
        Node<Gtype>? top;

        ///<summary>
        ///Constructor to initilize  top variables
        ///</summary>
        public My_Stack()
        {
            this.top = null;
        }

        ///<summary>
        ///Methods to push elements in the stack
        ///</summary>
        public void Push(Gtype data)
        {
            //create a node 
            Node<Gtype> node = new Node<Gtype>(data);
            //if top is null means stack is empty
            if (top == null)
            {
                top = node;
            }
            else //mark top element to next node and add the new element
            {
                node.next = top;
                top = node;
            }
        }

        ///<summary>
        ///Methods to show elements in the stack
        ///</summary>
        public void Show()
        {
            //traverse and print the elements in data while loop traverse till condition is satisfied
            Node<Gtype> temp_top = top;

            while (temp_top.next != null)
            {
                Console.WriteLine(temp_top.val + " ");
                temp_top = temp_top.next;
            }
            Console.WriteLine(temp_top.val);
        }


        public bool IsEmpty()
        {
            if (top is null) return true;
            else return false;
        }

        ///<summary>
        ///Methods to pop the element form stack
        ///</summary>
        public Gtype pop()
        {
            //variable
            Gtype temp;

            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");

            }
            else if (top.next is null)
            {
                top = null;
            }
            else
            {
                top = top.next;
            }
            return default(Gtype);
        }

        ///<summary>
        ///Methods to show the top most data
        ///</summary>
        public Gtype peek()
        {
            return top.val;
        }


        ///<summary>
        ///Methods to remove element in the middle
        ///</summary>
        public void pop_pos(int pos)
        {
            //variable
            int length = Size();

            //for user understanding we need to go to that position so length - pos -1
            pos = length - (pos - 1);
            Node<Gtype> temp_node;
            Node<Gtype> temp;

            if (pos < 0 || pos >= length)
            {
                Console.WriteLine("Index out of Boundary");
                return;
            }
            temp_node = top;
            //if in stack we have one element so to remove it
            if (top.next is null)
            {
                top = null; 
                return;
            }
            //remove the top and and change top position 
            if (pos == 0) 
                top = temp_node.next;
            //traverse upto just before element and remove it
            for (int i = 1; i < pos; i++) 
                temp_node = temp_node.next;
                temp = temp_node.next;
                temp_node.next = temp.next;
        }

        ///<summary>
        ///Methods to check the size of the stack 
        ///</summary>
        public int Size()
        {
            //temp variable
            Node<Gtype> temp;
            int count = 0;
            //check that stack is empty or not
            if (IsEmpty())
                return 0;
            //traverse and count the element in the stack
            temp = top;
            count++;

            while (temp.next != null)
            {
                count++;
                temp = temp.next;

            }
            return count;

        }
    }
}
