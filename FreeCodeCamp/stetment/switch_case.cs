// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstProgram{
    class Program{
        static void Main(string[] args){
            
            Console.WriteLine(GetDay(0));
            
            
           Console.ReadLine();

        }

        static string GetDay(int dayNum){

            string dayName;

            switch(dayNum)
            {
                case 0: 
                    dayName = "Sunday";
                    break;

                case 1: 
                    dayName = "Friday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;
                default:
                    dayName = "SORRY!!";
                    break;
                
            }
              
            return dayName;
        }

        
        
        
        
    }
}
