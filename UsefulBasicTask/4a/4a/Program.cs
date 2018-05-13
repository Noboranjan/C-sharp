using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4a
{
    class Program
    {
        static void Main(string[] args)
        {
            person p=new person();
            p.Name="A";
            p.Id=1;
            p.Gender= 'm';
            p.PhoneNo = "017";
            p.Address = "uttara";

            p.showinfo();

            person p1 = new person("B", 2, 'm', "019", "Azam");
            p1.showinfo();

            student s = new student();
            s.Name = "C";
            s.Id = 2;
            s.Gender = 'm';
            s.PhoneNo = "014";
            s.Address = "dokhinkhan";
            s.Cgpa = 3.00;
            s.Department = "CSE";
            s.CreditCompleted = 106;

            s.showinfo();
            student s1 = new student(3.22,"CSSE",105,"D",6,'m',"014","Hbuilding");
            s1.showinfo();


        }
    }
}
