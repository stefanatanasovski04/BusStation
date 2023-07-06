using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class Destination
    {
        public Station station { get; set; }
        public int Price { get; set; }
        public int Distance { get; set; }

        public Destination(Station station,string name, int price, int distance)
        {
            this.station = station;
            Price = price;
            Distance = distance;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}km {2}MKD",station,Price,Distance);
        }
    }
}
