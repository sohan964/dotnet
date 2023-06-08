using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreadings
{
    internal class Program
    {
        public void Test1()
        {
            lock (this) // it's try execute the thread serealy
            {
                Console.Write("C# ");
                Thread.Sleep(5000);
                Console.WriteLine("Language");
            }
        }
        
       
        static void Main(string[] args)
        {
            Program obj = new Program();
            Thread t1 = new Thread(obj.Test1);
            Thread t2 = new Thread(obj.Test1);
            Thread t3 = new Thread(obj.Test1);
            t1.Start(); t2.Start(); t3.Start();
            Console.ReadLine();


        }
    }
}
