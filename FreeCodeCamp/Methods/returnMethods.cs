// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstProgram{
    class Program{
        static void Main(string[] args){
            
            //method return types
            Console.WriteLine(sqar(5));//method called
            
            
           Console.ReadLine();

        }

        static int sqar(int num){
                double result = Math.Pow(num,2);
                return (int)result;//returning the values
                //note: here the returning value is typcast
                // because Math.Pow() function not working 
                // with int values on methods/function in C#

        }
        
        
        
    }
}
