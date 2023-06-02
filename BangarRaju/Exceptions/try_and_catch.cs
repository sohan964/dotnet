using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPart1and2
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
            catch(DivideByZeroException ex) { // it's use for num/0 error
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex) // num/char error
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) {// for any other exception
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("I am ok");
            Console.ReadLine();
        }
    }
}
