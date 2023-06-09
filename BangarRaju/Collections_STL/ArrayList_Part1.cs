using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList is work like Vector
            ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.Add(6);
            arr.Add(4);
            arr.Add(2);
            arr.Add(9);
            Console.WriteLine(arr.Capacity); // print the size
            // in C# (auto) is called (var)
            foreach (object i in arr) 
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            arr[2] = 14;
            int a = Convert.ToInt32(arr[2]);

            //interting a new value on a specific pointer
            arr.Insert(3, 21);// Insert 21 is 3rd position

            foreach (object i in arr)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            arr.Sort();// it will sort the ArrayList
            foreach (object i in arr)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            // removing specific element
            arr.Remove(5);// 5 will remove
            
            // removing a element form a index
            arr.RemoveAt(1);

            foreach (object i in arr)
            {
                Console.Write(i + " ");

            }
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
