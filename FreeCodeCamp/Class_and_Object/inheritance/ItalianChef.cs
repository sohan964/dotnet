using System;

namespace firstProgram{
    class ItalianChef : Chef{ // it's inhariting also Child class

       public ItalianChef(){
        Console.WriteLine("The class is called");
        }

        public override void MakeSpecialDish(){//same method in both class
            Console.WriteLine("it's cooking");
        }
    }
}
