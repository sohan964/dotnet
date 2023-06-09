using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    //another way to implement Generic
    public class Generic1<T>
    {
        // <T> is called one type Generic
        // T is dataType which is depent on value
        public bool Compire(T a, T b)
        {
            //for Generic (==) operator will not work
            // the builtine operator (1st.Equals(2nd))
            if (a.Equals(b)) return true;
            return false;


        }
        public void add(T a, T b)
        {   // here dynamic will detect the dataTypes
            Console.WriteLine((dynamic)a + (dynamic)b);
        }
    }

    public class Generic2 {


        


        static void Main()
        {
            //but here is a problem the object Type will fixed initialy
            Generic1<int> obj1 = new Generic1<int>();
            bool b = obj1.Compire(2, 3); // for this T = int
            Console.WriteLine(b); //False


            // Calling add
            obj1.add(2, 3); // T = int

            Console.ReadLine();

        }
    }
} 

