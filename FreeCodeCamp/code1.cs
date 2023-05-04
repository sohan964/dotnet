// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProgram{
    class Program{
        static void Main(string[] args){

            string s1="World!";
            int  theInt=1000000000;//10^9
            long thelong=1000000000000000000; //long long 10^18
            ulong theUlong= 10000000000000000000;//10^32

            Console.WriteLine("Hello_"+ s1 +" "+theInt);//printing 
            Console.WriteLine(thelong+" "+theUlong);



            Console.ReadLine(); //will pose the tarminal

        }
    }
}
