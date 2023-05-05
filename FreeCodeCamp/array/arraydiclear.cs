// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstProgram{
    class Program{
        static void Main(string[] args){
            
            //array

            //integer array
            int[] nums = {1,2,3,4};

            //empty int array diclaer
            int[] arr = new int[7];
            arr[0] = 10;
            Console.WriteLine(arr[0]); 

            //string array
            string[] names = new string[5];
            names[0]= "sohan";
            Console.WriteLine(names[0]);

        

           Console.ReadLine();

        }
    }
}
