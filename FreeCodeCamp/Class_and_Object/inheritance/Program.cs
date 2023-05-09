using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace firstProgram{
    class Program{
        static void Main(string[] args){
           Chef chef = new Chef();
           chef.MakeChicken();
           chef.MakeSpecialDish();

           ItalianChef italianChef = new ItalianChef();
           italianChef.MakeChicken();
           italianChef.MakeSpecialDish();
        }
    }
}
