// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProgram{
    class Program{
        static void Main(string[] args){

            string s="Sohanur" + " Rahman";//string concatination
            Console.WriteLine(s);
            Console.WriteLine("The length of the string " + s.Length);
            Console.WriteLine(s.ToUpper()); //uppercase Letter
            Console.WriteLine(s.ToLower());// Lowercase Letter

            Console.WriteLine(s.Contains("Soh")); //finding the substring (true or false)

            Console.WriteLine(s.IndexOf("Rahman"));// index of substring

            Console.WriteLine(s.Substring(8,6));//print substring index 8 to 6 char
            
            char[] schararry = s.ToCharArray();

            Array.Sort(schararry);
            Console.WriteLine(schararry);
            


            Console.ReadLine();
        }
    }
}
