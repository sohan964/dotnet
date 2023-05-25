using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
    public interface ITestInterface
    {
        
        void Add(int a, int b);
    }
    interface ITestInterface2: ITestInterface
    {
        void Sub(int a, int b);
    }
    class ImplementationClass : ITestInterface2
    {
        public void Add(int a, int b) //first way to implement
        {
            Console.WriteLine(a + b);
        }
        void ITestInterface2.Sub(int a, int b) //2nd way to implement but It should be called by refferance
        {
            Console.WriteLine(Math.Abs(a - b));
        }
        static void Main(string[] args)
        {
            ImplementationClass obj1 = new ImplementationClass();
            obj1.Add(1, 2);
            
            ITestInterface2 i = obj1; // creating the reffarance 
            i.Sub(3, 2);// calling by the reffarance

        }
    }
}
