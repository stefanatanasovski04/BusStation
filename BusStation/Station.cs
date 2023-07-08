using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class Station
    {
        public string City { get; set; }
        public string Country { get; set; }
        public List<Destination> destinations { get; set;}

        public Station() { }

        public Station(string city, string country)
        {
            City = city;
            Country = country;
            destinations = new List<Destination>();
        }

        public override string ToString()
        {
            return String.Format("{0} ( {1} )",City,Country);
        }


    }
}
