using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace firstProgram{
    class Program{
        static void Main(string[] args){
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-1");

            Console.WriteLine(avengers.Rating);// calling the get and set object
             
            Console.ReadLine();         
        }
    }
}
