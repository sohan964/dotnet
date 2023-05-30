using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajuDelegate
{ // the delegate dilear on the another class
    public delegate string GreetingsDelegate(string Name);
    class LambdaExpressions
    {    // we can call the delegate two way 
        /*public static string Greetings (string Name) // 1st way
        {
            return "Hello " + Name;
        }*/
        static void Main()
        {
            /*GreetingsDelegate obj = new GreetingsDelegate(Greetings);//1st way of calling*/

            // the 2nd way
            GreetingsDelegate obj = (Name) =>// it's called LambdaExpressions
            {
                return "Hello " + Name;
            };
            string str = obj.Invoke("Sohan");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
