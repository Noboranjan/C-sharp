using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate c1 = new Coordinate();

            c1.Longitude = 82.2;
            c1.Latitude = 33.2;

            Coordinate c2 = new Coordinate();
            c2.Longitude = 77.2;
            c2.Latitude = 41.32;

            Schedule departure = new Schedule();
            departure.Hour = 5;
            departure.Minute = 10;


            Schedule arrival = new Schedule();
            arrival.Hour = 8;
            arrival.Minute = 35;

            Employee pilot = new Employee();

            pilot.Id= "AVNGR001";
            pilot.Name = "Captain America";
            pilot.Designation = "Team Leader";

            Airport from = new Airport();
            from.Id = 505;
            from.Name = "LA Airport";
            from.Location = c1;


            Airport to = new Airport();
            to.Id = 808;
            to.Name = "Bangladesh Airport";
            to.Location = c2;

            Flight f1 = new Flight();
            f1.Id = 442;
            f1.Name = "Quinjet";
            f1.Capacity = 25;
            f1.Depurture = departure;
            f1.Arrival = arrival;
            f1.Pilot = pilot;
            f1.From = from;
            f1.To = to;

            Console.WriteLine("Flight ID   :{0}\nFlight Name :{1}\nFlight Capacity :{2}", f1.Id, f1.Name, f1.Capacity);
            Console.WriteLine("Pilot Name :{0}\nPilot ID :{1}\nPilot Designation :{2}", f1.Pilot.Name, f1.Pilot.Id, f1.Pilot.Designation);
            Console.WriteLine("Airport From Name :{0}\nAirport From ID :{1}\nAirport From Longitude :{2}\nAirport From Latitude :{3}", f1.From.Name, f1.From.Id, f1.From.Location.Longitude, f1.From.Location.Latitude);
            Console.WriteLine("Airport To Name :{0}\nAirport To ID :{1}\nAirport To Longitude :{2}\nAirport To Latitude :{3}", f1.To.Name, f1.To.Id, f1.To.Location.Longitude, f1.To.Location.Latitude);
            Console.WriteLine("Scheduled Departure at: {0}\nScheduled Arrival at: {1}",  f1.Depurture.Hour+":"+f1.Depurture.Minute ,f1.Arrival.Hour+":"+f1.Arrival.Minute );

        }
    }
}
