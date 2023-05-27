using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raju
{
    public class Customer
    {
        int _CustID;
        bool Status;
        String CustName;
        double Balance;
        public Customer(int CustID, bool Status, string CustName, double Balance)
        {
            _CustID = CustID;
            this.Status = Status;
            this.CustName = CustName;
            this.Balance = Balance;

        }
        public int CustID
        {
            get { return _CustID; } //I can print the value
            set {
                if(_CustID > value)
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
            Customer cust1 = new Customer(101, true, "MD. Mokbul", 500.001);
            cust1.CustID = 102;
            Console.WriteLine(cust1.CustID);

            Console.ReadLine();
        }
    }
}
