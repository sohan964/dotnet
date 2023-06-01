using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION
{
    internal class Exception
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter two Number :");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int z = a / b;
                Console.WriteLine("The result is: " + z);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            /*catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }*/
            Console.WriteLine("End of the program");
            

            Console.ReadLine();

            
        }
    }
}
