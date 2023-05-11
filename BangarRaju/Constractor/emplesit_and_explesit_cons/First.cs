using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Raju{
    class First{// implesitly
        public int x=100;  
    }
    class Second{
        public int x;
        public Second(int x){ // explesitly
            this.x = x;
        }
    }
    class TestClasses{
        static void Main(){
            First f1 = new First();
            First f2 = new First();
            Console.Write(f1.x + " ");
            Console.WriteLine(f2.x);

            Second s1 = new Second(100);
            Second s2 = new Second(200);
            Console.WriteLine(s1.x+" "+s2.x);
            /* in explesitly define constructor 
            it is possile to change values as paramitter
            */

        }
    }
}
