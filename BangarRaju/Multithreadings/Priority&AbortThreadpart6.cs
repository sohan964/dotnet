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
        static long Cnt1, Cnt2;
        public static void Incnt1()
        {
            while (true)
            {
                Cnt1 += 1;
            }
        }
        public static void Incnt2()
        {
            while (true)
            {
                Cnt2 += 1;
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Incnt1);
            Thread t2 = new Thread(Incnt2);
            t1.Priority = ThreadPriority.Lowest;// it's consuming less CPU rsourses
            t2.Priority = ThreadPriority.Highest;//it's conguming more CPU resourses 

            t1.Start();
            t2.Start();
            Console.WriteLine("Main Thread Sleep");
            Thread.Sleep(5000);
            Console.WriteLine("Main Thread wake up");
            t1.Abort(); // it's going to abort the execution
            t2.Abort(); // also it
            t1.Join();
            t2.Join();

            Console.WriteLine("Cnt1: " + Cnt1);
            Console.WriteLine("Cnt2: " + Cnt2);
            Console.ReadLine();

        }
    }
}
