using System;

namespace firstProgram{
    class Chef{ // base class (parent)

        public void MakeChicken(){
            Console.WriteLine("The Chef makes chicken");
        }

        public virtual void MakeSpecialDish(){// virtual means that same name class can be diclayer on other class by override
            Console.WriteLine("it's ");
        }
    }
}
