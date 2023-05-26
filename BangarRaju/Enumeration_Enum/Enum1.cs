using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
    public enum Days// enum is all about colors
    {  // enum is also a user define data_type

        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
    }
    internal class EnumColor
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Days d1 = (Days)0;
            Console.WriteLine(d1);// it will print Monday.

            foreach(int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i+" = "+ (Days)i); // it will print the value of each days
            }

            foreach( var i in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(i); // Print the Name of all days
            }



            Console.ReadLine();
        }
    }
}
