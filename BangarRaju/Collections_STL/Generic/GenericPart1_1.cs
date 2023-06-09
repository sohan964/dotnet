using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Generic1
    {
        // <T> is called one type Generic
        // T is dataType which is depent on value
        public bool Compire<T>(T a, T b)
        {
            //for Generic (==) operator will not work
            // the builtine operator (1st.Equals(2nd))
            if (a.Equals(b)) return true;
            return false;

        }

        public void add<T> (T a, T b)
        {   // here dynamic will detect the dataTypes
            Console.WriteLine((dynamic)a + (dynamic)b);
        }


        static void Main()
        {
            Generic1 obj1 = new Generic1();
            bool b = obj1.Compire<int>(2, 3); // for this T = int
            Console.WriteLine(b); //False

            bool f2 = obj1.Compire<float>(2.46f, 2.46f); // for this T = float
            Console.WriteLine(f2); //True

            // Calling add
            obj1.add<int>(2, 3); // T = int

            Console.ReadLine();
           
        }
    }
}
