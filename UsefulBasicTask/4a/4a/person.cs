using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4a
{
    class person
    {

     private string name;
     private int id;
     private char gender;
     private string phoneNo;
     private string address;

     public person()
     {
     }
     public person(string pN,int pid,char pg,string pNo,string add)
     {
         name = pN;
         id = pid;

         gender = pg;
         phoneNo = pNo;

         address = add;
     }
     public string Name
     {
         get {
             return name;
         }
         set
         {
             name = value;
         }
     }
     public int Id
     {
         get
         {
             return id;
         }
         set
         {
             id = value;
         }
     }
     public char Gender
     {
         get
         {
             return gender;
         }
         set
         {
             gender = value;
         }
     }
     public string PhoneNo
     {
         get
         {
             return phoneNo;
         }
         set
         {
             phoneNo = value;
         }
     }
     public string Address
     {
         get
         {
             return address;
         }
         set
         {
             address = value;
         }
     }
     public void showinfo()
     {
         Console.WriteLine(name + "\n" + id + "\n" + gender + "\n" + phoneNo + "\n" + address);
     }


    }
}
