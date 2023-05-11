using System;

namespace Raju{
    class CopyConDemo{
        int x;
        public CopyConDemo(int i){
            x=i;
        }
        public CopyConDemo(CopyConDemo obj){ // copy constractor
            x = 2*obj.x;
        }
        public void Display(){
            Console.WriteLine("The value is "+x);
        }
        static void Main(){
            CopyConDemo cd1 = new CopyConDemo(10);
            cd1.Display();

            CopyConDemo cd2 = new CopyConDemo(cd1);// calling the Copy constractor by object
            
            cd2.Display();

        }
    }
}
