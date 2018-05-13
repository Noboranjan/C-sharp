using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_A1
{
    class Employee
    {
        private string id;
        private string name;
        private string designation;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
    }
}
