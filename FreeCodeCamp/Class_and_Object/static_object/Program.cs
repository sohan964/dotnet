using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace firstProgram{
    class Program{
        static void Main(string[] args){
            Song shapeof = new Song("shape of you", "ulal", 200);
            Console.WriteLine(Song.songCount); //calling the static obj
            //we need to call static object by class_name.attribute
            
            Console.ReadLine();         
        }
    }
}
