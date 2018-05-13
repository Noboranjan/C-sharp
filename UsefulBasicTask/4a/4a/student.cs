using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4a
{
    class student : person
    {
        private double cgpa;
        private string department;
        private int creditCompleted;

        public student()
        { }
        public student(double scgpa, string sd, int scc, string pN, int pid, char pg, string pNo, string add):base(pN,pid,pg,pNo,add)
        {
            cgpa = scgpa;
            department = sd;
            creditCompleted = scc;
        }

        public double Cgpa
        {
            get
            {
                return cgpa;
            }
            set
            {
                cgpa = value;
            }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int CreditCompleted
        {
            get { return creditCompleted; }
            set { creditCompleted = value; }
        }
        public void showinfo()
        {
            Console.WriteLine( "\n" + Name + "\n" + Id + "\n" + Gender + "\n" + PhoneNo + "\n" + Address+"\n"+cgpa + "\n" + department + "\n" + creditCompleted);
        }
    }
}
