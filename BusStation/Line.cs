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

        public Line(Station station,Destination destination, DateTime dateTime)
        {
            this.TakeOffStation = station;
            this.destination = destination;
            this.dateTime = dateTime;
            this.availableSeats = 50;
        }

       public override string ToString() {
            return String.Format("{0} {1}-{2} Слободни места: {3} ", dateTime, TakeOffStation.City, destination.station.City,availableSeats);
        }
        public string forPrint()
        {
            return String.Format("{0}.{1}  {2}:{3} {4}-{5}", dateTime.Day, dateTime.Month, dateTime.Hour, dateTime.Minute, slice(TakeOffStation.City), slice(destination.station.City));
        }
        public string slice(string name)
        {
            string tmp = "";
            for(int i = 0; i < 2; i++)
            {
                tmp += name[i];
            }
            return tmp.ToUpper();
        }

        
    }
}
