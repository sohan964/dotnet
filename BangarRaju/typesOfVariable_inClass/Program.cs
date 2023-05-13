using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Raju{
    public class Program{
         int x=100; //it's non-static/instance
        static int y=200; //static
        const double pi = 3.1416f; //const
        readonly bool flag; //can't be modify after inatializ
        Program(int x, bool flag){
            this.x = x;
            this.flag = flag;
        }
        static void Main(string[] args){
            int z=1; //it also static because it diclear on static method
            Console.WriteLine(y+" "+z);
            Program obj1 = new Program(50, true);
            
            Console.WriteLine(obj1.x);
            Console.WriteLine(pi);

        }
    }
}
