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

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public string Departure
        {
            get { return departure; }
            set { departure = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public int Flighttime
        {
            get { return flighttime; }
            set { flighttime = value; }
        }
    }
}
