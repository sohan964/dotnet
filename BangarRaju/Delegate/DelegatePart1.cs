using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{   //define a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
     class DelegatePart1
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);

        }
        public static string SayHello(string Name)
        {
            return "Hello " + Name;
        }

        static void Main(string[] args)
        {
            DelegatePart1 p = new DelegatePart1();

            //instancetiating the delegate
            AddDelegate ad = new AddDelegate(p.AddNums);
            //we can call two way 
            ad.Invoke(100, 500);// 1st one Invoke(it's auto generate)
            ad(7, 2);// direct
            SayDelegate sd = new SayDelegate(DelegatePart1.SayHello);
            string str = sd("Sohan");
            Console.WriteLine(str);

            Console.ReadLine();

        }
    }
}
