using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Raju{
    class Matrix{ // Object class declar by the compiler
        int a,b,c,d;
        public Matrix(int a, int b, int c, int d){
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        //the Operator overloading function
        public static Matrix operator +(Matrix m1, Matrix m2){
            Matrix m = new Matrix(m1.a + m2.a,m1.b+m2.b,m1.c+m2.c,m1.d+m2.d);
            return m;
        }
        public static Matrix operator -(Matrix m1, Matrix m2){
            Matrix m = new Matrix(m1.a - m2.a,m1.b-m2.b,m1.c-m2.c,m1.d-m2.d);
            return m;
        }
        // This ToString() method Declar in the Object class
        // as a child class override the function
        public override string ToString()
        {
            //the formate of the printing matrix
            return a + " " + b + "\n" + c + " "+ d;
        }
    }
    class TestMatrix{
        static void Main(){
            Matrix M1= new Matrix(2,3,4,5);
            Matrix M2 = new Matrix(9,8,7,6);
            Matrix M3 = M1+M2;
            Matrix M4 = M1-M2;
            //WriteLine Will call the ToString Method by Default 
            Console.WriteLine(M3);
            Console.WriteLine(M4);
            
            
            

        }
    }
    
}
