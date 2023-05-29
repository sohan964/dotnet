using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
    public delegate string GreetingsDelegate(string Name);
    
    internal class AnonymousMethods
    {
        static void Main(string[] args)
        { // AnonymouseMethod is a Method who have not any name
            GreetingsDelegate obj = delegate (string Name) // It's called AnonymousMethod 
            {
                return "Hello " + Name;
            };

            string str = obj.Invoke("Scott");
            Console.WriteLine(str);
            Console.ReadLine();

        }

    }
}
