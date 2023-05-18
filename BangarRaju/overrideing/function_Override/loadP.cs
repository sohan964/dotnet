using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Raju{
    public class loadP{
        public virtual void Test(){//override possible
            Console.WriteLine("Parent's Method");
        }
    }
    class loadC: loadP{
        public override void Test(){//override here
            Console.WriteLine("Child's Method");
        }
        static void Main(){
            loadC c1 = new loadC();
            c1.Test();
            loadP p1 = new loadP();
            p1.Test();

        }
    }
    
}
