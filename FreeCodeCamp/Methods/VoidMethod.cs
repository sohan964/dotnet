// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstProgram{
    class Program{
        static void Main(string[] args){
            
            //methods or function
            sayHi();// method calling
            QNA("How are you");// with paramiter
            
            
           Console.ReadLine();

        }
        
        //Method or function
        static void sayHi(){
            Console.WriteLine("Hello Sir.");
        }
        static void QNA(string name){
            Console.WriteLine(name+" Sir");
        }
        
    }
}
