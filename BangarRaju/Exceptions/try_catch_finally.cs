using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two Number :");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int z = a / b;
                Console.WriteLine("The result is: " + z);

            }
            
            catch(Exception ex) {// for any other exception
                Console.WriteLine(ex.Message);
            }
            finally// always the finally block will be execute
            {
                Console.WriteLine("finally block is executed");
            }
            Console.WriteLine("I am ok");
            Console.ReadLine();
        }
    }
}
