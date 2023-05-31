using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajuDelegate
{
   /* public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);*/

    internal class GenericDelegates
    {
        public static double AddNums1( int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine( x + y + z );
        }

        public static bool CheckLength(string str)
        {
            if (str.Length >= 5) return true;
            return false;
        }
        static void Main(string[] args)

            //buiting delegates are Func, Action, 
        {
            Func<int, float, double, double> obj1 = AddNums1; //Func is for return type
            double result = obj1.Invoke(100, 34.5f, 193.465); // the last double is the output type
            Console.WriteLine(result);

            Action<int,float, double> obj2 = AddNums2; //Action is for non return type
            obj2.Invoke(100, 34.5f, 193.465); // 
            

            Predicate< string > obj3 = CheckLength; // Predicate for bool and not need to tell them about output type
            bool status = obj3.Invoke("Sohan");
            Console.WriteLine(status);
            Console.ReadLine();


        }

    }
}
