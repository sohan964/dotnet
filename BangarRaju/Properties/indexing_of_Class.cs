using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
    public class Employee
    {
        int Eno;
        double Salary;
        String Ename, Job, Dname, Location;
        public Employee(int Eno, double Salary, string Ename, string Job, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Salary = Salary;
            this.Ename = Ename;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;

        }
        public object this[int index] //using this we can access a class like array
        { //we access all the element of the array by indexing
            get// we can get the value by this 
            {
                if (index == 0) return Eno;
                else if(index == 1) return Salary;
                else if(index == 2) return Ename;
                else if( index == 3) return Job;
                else if(index == 4) return Dname;
                else if( index==5) return Location;
                return null;
            }

            set // user also can set the value by this
            {
                if(index == 0) // 0 index value will change
                {
                    Eno = (int)value; // the value will change
                }
            }
        }
    }
            
    class TestEmployee
    {
        static void Main()
        {
            Employee Emp = new Employee(1001, 20000.20, "Scott", "Manager", "Sales", "Mumbai");
            Console.WriteLine("Eno: "+ Emp[0]);
            Console.WriteLine("Salary: " + Emp[1]);
            Console.WriteLine("Ename: " + Emp[2]);
            Console.WriteLine("Job: " + Emp[3]);
            Console.WriteLine("Dname: " + Emp[4]);
            Console.WriteLine("Location: " + Emp[5]);

            Emp[0] = 1020;
            Console.WriteLine("Eno: " + Emp[0]);
        }
    }
}
