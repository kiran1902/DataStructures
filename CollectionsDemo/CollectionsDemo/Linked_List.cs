using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Linked_List<Gtype>
    {
        Node<Gtype> head = null;

        public void Add(Gtype data)
        {
            //Variables
            Node<Gtype> temp_node;

            //create a new node with data
            Node<Gtype> node = new Node<Gtype>(data);

            if (head == null)
            {
                head = node;
                return;
            }
            else
            {
                temp_node = head;
                while (temp_node.next != null)
                    temp_node = temp_node.next;
                temp_node.next = node;
            }

        }

        //adding a new node
        public void Add(Gtype data, int pos)
        {
            //variable
            Node<Gtype> temp_node = head;
            int size = Size();

            if (pos > size + 1 || pos < 1)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            //create node
            Node<Gtype> node = new Node<Gtype>(data);

            if (head == null)
            {
                Console.WriteLine("List is Empty");
                if (pos == 1)
                {
                    head = temp_node;
                }
                Console.WriteLine("Invalid Position");
            }
            else
            {

                if (pos == 1)
                {
                    node.next = temp_node;
                    head = node;

                }
                else
                {
                    int count = 1;
                    while (pos > count + 1)
                    {
                        temp_node = temp_node.next;
                        count++;
                    }
                    Node<Gtype> temp_node2 = temp_node.next;
                    temp_node.next = node;
                    node.next = temp_node2;

                }
            }
        }

        public int Size()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return 0;
            }
            else
            {
                int count = 1;
                Node<Gtype> temp_node = head;
                Console.WriteLine(temp_node.val);
                while (temp_node.next != null)
                {
                    count++;
                    temp_node = temp_node.next;
                }
                return count;
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                Node<Gtype> temp_node = head;
                Console.WriteLine(temp_node.val);
                while (temp_node.next != null)
                {
                    Console.WriteLine(temp_node.next.val);
                    temp_node = temp_node.next;
                }
            }
        }

        public void Remove(int pos)
        {
            //variable
            Node<Gtype> temp_node = head;
            int size = Size();

            if (pos > size + 1 || pos < 1)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            if (pos == 1)
            {
                head = temp_node.next;

            }
            else
            {
                int count = 1;
                while (pos > count + 1)
                {
                    temp_node = temp_node.next;
                    count++;
                }
                Node<Gtype> temp_node2 = temp_node.next.next;
                temp_node.next = temp_node2;

            }
        }

    }
}
