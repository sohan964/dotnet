using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
    interface Interface1
    {
        void Test();
    }
    interface Interface2
    {
        void Test();
        void Show();
    }
    class MultipleInheritanceTest: Interface1, Interface2
    {
        public void Test() //Multiple inheritance
        {
            Console.WriteLine("Interface Method Implemented in child class.");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Yes, The method is calling by referance");
        }
        static void Main()
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            Interface2 i2 = obj;
            i2.Show();
            
            Console.ReadLine();
        }

    }
}
