using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreadings
{
    internal class Program
    {
        
        public static void Incnt1()
        {
            long n = 0;
            for (long i = 0; i < 100000000; i++)
            {
                n++;
            }
        }
        public static void Incnt2()
        {
            long n = 0;
            for(long i = 0; i < 100000000; i++)
            {
                n++;
            }
        }


        static void Main(string[] args)
        {
            Stopwatch st1 = new Stopwatch();
            Stopwatch st2 = new Stopwatch();
            Thread t1 = new Thread(Incnt1);
            Thread t2 = new Thread(Incnt2);

            st1.Start();
            //single thread run time
            Incnt1();
            Incnt2();
            st1.Stop();

            st2.Start();
            //multi Thread run time
            t1.Start();
            t2.Start();
            st2.Stop();

            t1.Join();
            t2.Join();

            Console.WriteLine("Single Thread Time Calculation: " + st1.ElapsedMilliseconds);
            Console.WriteLine("Multi Thread Time Calculation: " + st2.ElapsedMilliseconds);

            Console.ReadLine();


        }
    }
}
