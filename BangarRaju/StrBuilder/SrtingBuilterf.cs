using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StrBuilder
{
    internal class StringBuilterf
    {
        static void Main()
        {
            // time calclucation for the string 
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            string s = "";
            for (int i = 1; i <= 100000; i++)
            {
                s += i;
            }
            sw1.Stop();
            Console.WriteLine(sw1.ElapsedMilliseconds);



            StringBuilder sb = new StringBuilder("sohan");
            sb.Append("Hello");
            Console.WriteLine(sb);

            // Time calclucation for StringBuilder
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            StringBuilder sb2 = new StringBuilder();
            for(int i = 1; i <= 100000; i++)
            {
                sb2.Append(i);
            }
            sw2.Stop();
            Console.WriteLine(sw2.ElapsedMilliseconds);
            Console.ReadLine();


            
        }
    }
}
