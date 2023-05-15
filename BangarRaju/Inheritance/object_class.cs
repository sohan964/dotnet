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
       
        
       public void m1(){
            Console.WriteLine("m1");
        }
       
    }
    class class1:Program{
        class1(){
           
           Console.WriteLine("i am the class1");
        }
        static void Main(){
            class1 obj1=new class1();

            Object obj2= new Object();//is called defult class
            //this Object class don't need to define
            Console.WriteLine(obj2.GetType());
            
            obj1.m1();
            
        }

    }
}
