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
                Console.WriteLine("Test1 " + i);
                if(i == 5)
                {
                    Console.WriteLine("Program poj");
                    Thread.Sleep(5000); // it will poz the program for 5 secound
                    Console.WriteLine("Program again statr");
                }
            }
        }
        static void Main(string[] args)
        {
            Test1();
            Console.ReadLine();

        }
    }
}
