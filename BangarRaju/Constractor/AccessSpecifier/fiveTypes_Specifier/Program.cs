using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Raju{
    public class Program{
        private void Test1(){ // access not possible from other class
            Console.WriteLine("Private Method");
        }
        internal void Test2(){ //access is possible
            Console.WriteLine("Internal Method");
        }

        protected void Test3(){//access possible but after inherite
            Console.WriteLine("Protected Method");
        }

        protected internal void Test4(){//access is possible
            Console.WriteLine("Protected Internal Method");

        }

        public void Test5(){
            Console.WriteLine("Public Method");
        }



    }
}
