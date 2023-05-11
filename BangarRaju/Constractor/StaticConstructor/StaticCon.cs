using System;

namespace Raju{
    class StaticCon{
        public int x;
        static StaticCon(){ //it emplesitly called
            //It's cannot be paramitarized
            // so It can't be overloded

            Console.WriteLine("Static Constructor is executed");

        }
        static void Main(){
            
        }
    }
}
