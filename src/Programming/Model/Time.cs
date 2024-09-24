    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public int Second
        {
            get { return second; }
            set { second = value; }
        }
    }
}
