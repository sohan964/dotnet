using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreadings
{
    internal class ThreadStart_Part3
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
        static void Test3()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Test3 sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test3 Wakeup");

                }
                Console.WriteLine("Test2 " + i);
            }
        }
        // thread only support object as a parameter
        static void Test4(object mx)
        {
            // then simple it need to convert on any datatype 
            int num = Convert.ToInt32(mx);
            for (int i = 0; i < num; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Test3 sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test3 Wakeup");

                }
                Console.WriteLine("Test2 " + i);
            }

        }
        static void Main(string[] args)
        {

            //there is no diferance between ThreadStart and Thread
            // but for (CLR).Net frame work it's need to create ThreadStart
            // N.T ThreadStart delegate deos not take any parameter
            ThreadStart obj = new ThreadStart(Test1); // here ThreadStart is a delegate
            Thread t = new Thread(obj);
            t.Start();
            ///the another way that we can write
            ThreadStart obj2 = delegate () { Test2(); };
            Thread t2 = new Thread(obj2);
            t2.Start();

            // another way we can use lamda operator (=>)    
            ThreadStart obj3 = () => Test3(); // The anonimus Method
            Thread t3 = new Thread(obj3);
            t3.Start();

            // for Parameterize Method (test4)
            ParameterizedThreadStart obj4 = new ParameterizedThreadStart(Test4);
            Thread t4 = new Thread(obj4);
            t4.Start(15);

            Console.ReadLine();


        }
    }
}
