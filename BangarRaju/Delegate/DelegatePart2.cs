using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{   //define a delegate
    public delegate void AddDelegate(int x, int y);
   // public delegate void SubDelegate(int x, int y);

    class DelegatePart2
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);

        }


        public void SubNums(int a, int b)
        {
            Console.WriteLine(a - b);

        }


        static void Main(string[] args)
        {
            DelegatePart2 p = new DelegatePart2();

            AddDelegate obj = p.AddNums; // it's means new AddDelegate(p.AddNums)
            obj += p.SubNums; // it also execute the SubNums method at the same time
            obj.Invoke(5, 2); // it will call both of two method 

            
            

            Console.ReadLine();

        }
    }
}
