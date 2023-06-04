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
        static void Test1()
        {
         for(int i = 0; i < 10; i++)
            {
               
                if (i == 5)
                {
                    Console.WriteLine("It's going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("It's back");
                }
                Console.WriteLine("Test1 " + i);
            }
        }
        static void Test2()
        {
            for(int i=0;i< 10; i++)
            {
                Console.WriteLine("Test2 " + i);
            }
        }
        static void Main(string[] args)
        {
            //here both method execude by time sharing
            Thread T1 = new Thread(Test1);// Thread is a builtin seheld class
            Thread T2 = new Thread(Test2);
            T1.Start();
            T2.Start();

            Console.ReadLine();

        }
    }
}
