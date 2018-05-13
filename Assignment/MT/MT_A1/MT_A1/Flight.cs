using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_A1
{
    class Flight
    {

        private int id;
        private string name;
        private int capacity;
        private Employee pilot;
        private Airport from;
        private Airport to;
        private Schedule departure;
        private Schedule arrival;

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

        public int Capacity
        {

            get { return capacity; }
            set { capacity = value; }

        }

        public Employee Pilot
        {

            get { return pilot; }
            set { pilot = value; }

        }

        public Airport From
        {

            get { return from; }
            set { from = value; }

        }

        public Airport To
        {

            get { return to; }
            set { to = value; }

        }

        public Schedule Depurture
        {

            get { return departure; }
            set { departure = value; }

        }

        public Schedule Arrival
        {

            get { return arrival; }
            set { arrival = value; }

        }
    }
}
