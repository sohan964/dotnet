using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPart1and2
{
    // here inheriting the ApplicationException (it's a builtin class)
    public class DivideByoddNoException : ApplicationException
    {
        public override string Message 
        {
            get
            {
                return "The input a is 0";
            }
        }
    }
    public  class Program
    {
        
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if(a == 0)
            {
                throw new DivideByoddNoException(); // this way create own Application exception
            }
            
            Console.ReadLine();
        }
    }
}
