using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
   abstract class Class1
    {
        public abstract void show();
        public void Display()
        {
            Console.WriteLine("This is the Display Function");
        }
    }
    class Class2: Class1 // after inherite it is must neseceri to override the abstract method
    {//other wise it will give error
        public override void show()
        {
            Console.WriteLine("I am the Abstract Method");

        }
        static void Main(string[] args) 
        {
            // Class1 obj = new Class1(); //abstract class instance is not possible
            Class2 obj1 = new Class2();
            obj1.Display();
            obj1.show(); 


            Console.ReadLine();
        }

    }

}
