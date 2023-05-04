// See https://aka.ms/new-console-template for more information


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace firstProgram{
    class Program{
        static void Main(string[] args){
            
            int num = Convert.ToInt32("40"); //convert string to number
            Console.WriteLine(num + 2);

            //if you want to input a number?? then
            //you need to input the number as a string
            //after convert it into number. so,
            
            int num2 = Convert.ToInt32(Console.ReadLine());// Input a number
            Console.WriteLine(num+num2);

            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);
            Console.ReadLine();

        }
    }
}
