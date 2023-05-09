using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace firstProgram{
    class Program{
        static void Main(){
            MyNewClass book1 = new MyNewClass("Mind your own business","Sohanur Rahman",200);//calling constractor by value
             book1.Display();
             
            
            
            Console.ReadLine();         
        }
    }
}
