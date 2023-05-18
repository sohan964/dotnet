using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Raju{
    public class loadP{
        public void Test(){
            Console.WriteLine("Parent's Method");
        }
    }
    class loadC: loadP{
        public new void Test(){ // Method hiding/shadowing
            Console.WriteLine("Child's Method");
        }
        public void Ptest(){
            //without creating the costractor of loadP class
            base.Test(); //it will called loadP Test Method
        }
        
        static void Main(){
            loadC c1 = new loadC();//c1 is instance of child class
            loadP P=c1;//P is a referance of parent class created by using child's
            //but using P we Cannot call any member define of the child class
            P.Test();
            

        }
    }
    
}
