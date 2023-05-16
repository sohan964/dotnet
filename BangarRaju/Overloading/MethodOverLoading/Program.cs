using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Raju{
    public class Program{
        
        public string Test(string s){
            return s;
        }
        public void Test(){
            Console.WriteLine("the first one");
        }
        public void Test(int i){
            Console.WriteLine("the first 2nd");
        }
        public void Test(int i, string s){
            Console.WriteLine("the first 3rd");
        }
        public void Test(string s, int i){
            Console.WriteLine("the first 4th");
        }
        // public void Test(string s){
        //     Console.WriteLine("the first 5th");
        // }

        static void Main(){
            Program p = new Program();
            string g = p.Test("sohan");
            Console.WriteLine(g);
             g=p.Test("The boy");
            Console.WriteLine(g);
            
        }
    }
    
}
