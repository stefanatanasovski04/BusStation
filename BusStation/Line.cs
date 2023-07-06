using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class Line
    {
        public Station TakeOffStation { get; set; }
        public Destination destination { get; set; }
        public DateTime dateTime { get; set; }
        public int availableSeats { get; set; }

        public Line(Station station,Destination destination, DateTime dateTime, int availableSeats)
        {
            this.TakeOffStation = station;
            this.destination = destination;
            this.dateTime = dateTime;
            this.availableSeats = availableSeats;
        }

       public override string ToString() {
            return String.Format("{0}  {1} - {2} ", dateTime, TakeOffStation.City, destination.station.City);
        }

        
    }
}
