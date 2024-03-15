using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    internal class Flight
    {
        private string departure;
        private string destination;
        private int flighttime;

        public string Departure
        {
            get { return departure; }
            set { departure = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int Flighttime
        {
            get { return flighttime; }
            set { flighttime = value; }
        }
    }
}
