using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class Ticket
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Line line { get; set; }
        public int NumberOfSeats { get; set; }
        public int PriceTicket { get; set; }

        public Ticket(string name, string lastName, Line line, int numberOfSeats)
        {
            Name = name;
            LastName = lastName;
            this.line = line;
            NumberOfSeats = numberOfSeats;
            this.PriceTicket = line.destination.Price;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} Last Name: {1} Number of Tickets: {2} Price: {3}MKD",Name, LastName,,NumberOfSeats, PriceTicket);
        }
    }
}
