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
        public static Days MeetingDate
        {
            get; set;
        } = (Days)1; // Defult meeting date is Tuesday
        static void Main()
        {
            Console.WriteLine(MeetingDate);
            MeetingDate = Days.Friday;



            Console.ReadLine();
        }
    }
}
