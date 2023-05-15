using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Raju{
    class Program{
        public Program(){
            Console.WriteLine("mui asung");
        }
        private Program(int a){

        }
        
       public void m1(){
            Console.WriteLine("m1");
        }
       public void m2(){
            Console.WriteLine("m2");
        }
       public void m3(){
            Console.WriteLine("m3");
        }
    }
    class class1:Program{
        class1(){
            m3();
           Console.WriteLine("i am the class1");
        }
        static void Main(){
            class1 obj1=new class1();
            
            obj1.m1();
            
        }

    }
}
