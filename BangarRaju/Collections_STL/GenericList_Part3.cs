using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericList
    {
        static void Main(string[] args)
        {
            // List totaly work like Vector
            List<int> li = new List<int>();
            //pushing value to the back
            li.Add(10);
            li.Add(9);
            li.Add(2);
            li.Add(1);
            li.Add(5);
            li.Add(6);
            li.Add(7);
            //li.Add(8);
            Console.WriteLine(li.Count); //printing size
            for(int i = 0; i<li.Count; i++)
            {
                Console.Write(li[i] + " ");
            }
            Console.WriteLine();

            //Inserting element middle of a specific index
            li.Insert(3, 32); //32 will add on index 3

            // removing a element from a index
            li.RemoveAt(0); // 10 will remove

            // removing a specific element
            li.Remove(7); // 7 will remove

            li.Sort(); //sorting the list

            Console.WriteLine("new size of the list: " +  li.Count);
            foreach (var i in li)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
