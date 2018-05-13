using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    abstract class BankAccount
    {
        private string name;
        private string accNo;
        private double balance;
        private string gender;
        private string phoneNo;
        private string address;


        public BankAccount() { }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        public double Balance
        {
        get{return balance;}
        set{balance=value;}
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string PhoneNo
        { get { return phoneNo; }
            set { phoneNo = value; }

        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public abstract void showinfo();
    }
}
