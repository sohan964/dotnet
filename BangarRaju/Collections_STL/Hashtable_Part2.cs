using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashTableCollection
    {
        static void Main(string[] args)
        {
            // Hashtable work like pair
            Hashtable ht = new Hashtable();
            // storing value on Keys
            ht.Add("Name", "Sohan");
            ht.Add("ID", 21331);
            ht.Add("Job", "Student");
            ht.Add("Email", "sohanurr791@gmail.com");
            ht.Add("Phone", 01705894964);

            //it print the value which store inside name Key
            Console.WriteLine(ht["Name"] + "\n");

            //1st print Key then Value
            foreach (var u in ht.Keys)
            {
                Console.WriteLine(u + ": " + ht[u]+  " "+ u.GetHashCode() );
            }
            Console.ReadLine();
        }
       
    }
}
