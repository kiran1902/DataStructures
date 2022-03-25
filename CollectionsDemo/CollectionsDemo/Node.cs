using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Node<Gtype>
    {
        public Gtype val;
        public Node<Gtype> next;

        public Node(Gtype data)
        {
            this.val = data;
            this.next = null;
        }
    }
}
