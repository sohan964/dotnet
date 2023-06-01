using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    //Extension class and Method must be Static
    static class StatClass
    {
        // the way to add this method on the program class 
        public static void Test3(this Program P) // it's called extension method
        {
            Console.WriteLine("Test3");
        }
        
        // we know (int) is a structure 
        // adding the method with (int) structure
        public static long Fact(this Int32 n)
        {
            if (n == 0) return 1;
            return n * Fact(n - 1);
        }

        //extension Method for (string Class) string
        public static string addStr(this string oldStr)
        {
            return "Hello " + oldStr;
        }
        static void Main(string[] args)
        {
            // here it showing Method Test3 the member of Program class
            Program p = new Program();
            p.Test3();

            int i = 5;
            long n = i.Fact(); // calling the extension_method
            Console.WriteLine(n);

            string s = "Sohan";
            s= s.addStr();
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
