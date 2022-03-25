using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Dummy
    {
        List<int> list = new List<int>();

        public void Display()
        {
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Add(70);

            int ind = 0;

            while (ind < list.Count)
            {
                Console.WriteLine(list[ind]);
                ind++;
            }

        }
    }
}
