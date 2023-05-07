// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstProgram{
    class Program{
        static void Main(string[] arr){
            MyNewClass myclass = new MyNewClass(); //create object

            Console.WriteLine(myclass.Addition(2,3));//calling the class

            Console.WriteLine("inter two number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            MyNewClass Sum = new MyNewClass();
            int sum = Sum.Addition(a,b);
            Console.WriteLine(sum + " is come from the class MyNewClass");
            
            Console.ReadLine();
        }
    }
}
