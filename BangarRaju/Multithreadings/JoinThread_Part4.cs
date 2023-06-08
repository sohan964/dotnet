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
            for (int i = 0; i < 10; i++)
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
                if (i == 4)
                {
                    Console.WriteLine("Test2 sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test2 Wakeup");

                }
                Console.WriteLine("Test2 " + i);
            }
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Start");
            ThreadStart obj1 = () => Test1();
            ThreadStart obj2 = () => Test2();
            Thread t1 = new Thread(obj1);
            Thread t2 = new Thread(obj2);
            t1.Start(); t2.Start();
            t1.Join(); t2.Join(); // it will pos the execution of Main Thread untile other Thread are execute
            Console.WriteLine("Main Thread EXiting");
            

            Console.ReadLine();


        }
    }
}
