using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericDictionary
    {
        static void Main(string[] args)
        {

            Dictionary<string, object> dt1 = new Dictionary<string, object>();
            // 1st Keys   then Values
            dt1.Add("Name", "Sohan");
            dt1.Add("ID", 21331);
            dt1.Add("Job", "Student");
            dt1.Add("Email", "sohanurr791@gmail.com");
            dt1.Add("Phone", 01705894964);
            // i
            foreach(var u in dt1.Keys)
            {
                Console.WriteLine(u + " " + dt1[u]);
            }
            Console.ReadLine();

        }
    }
}
