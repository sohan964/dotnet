using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
    public enum Cities // it's a user define type like the class
    {
        Dhaka, Khulna, Rajshahi
    }
    public class Customer
    {
        int _CustID;
        bool _Status;
        String CustName;
        double Balance;
        Cities _City;

        public Customer(int CustID, bool Status, string CustName, double Balance, Cities City)
        {
            _CustID = CustID;
            _Status = Status;
            this.CustName = CustName;
            this.Balance = Balance;
            _City = City;

            


        }

        public Cities City
        {
            get { return _City; }
            set
            {
                if (_Status == true) _City = value;
            }
        }
        
        public int CustID // get set for give the parmition to change the values
        {
            get { return _CustID; } //I can print the value
            set
            {
                if (_CustID > value)
                {
                    _CustID = value;
                }

            } //I can modify the value
        }

        
    }

    class Shop
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer(101, true, "MD. Mokbul", 500.001, Cities.Dhaka);
            cust1.CustID = 102;
            Console.WriteLine(cust1.CustID);
            Console.WriteLine(cust1.City); // initialize city
            cust1.City = Cities.Rajshahi; // modifide city
            Console.WriteLine(cust1.City);

            Console.ReadLine();
        }
    }
}
