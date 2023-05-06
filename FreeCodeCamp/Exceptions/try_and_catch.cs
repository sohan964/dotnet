// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstProgram{
    class Program{
        static void Main(string[] arr){
            try{
                Console.Write("Enter a Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the 2nd Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1/num2);
            }
            catch(DivideByZeroException e){
                Console.WriteLine(e.Message);

            }
            catch(FormatException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
