using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_A1
{
    class Airport
    {
        private int id;
        private string name;
        Coordinate location;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {

            get { return name; }
            set { name = value; }
        }
        public Coordinate Location
        {
            get { return location; }
            set { location = value; }
        }

    }
}
