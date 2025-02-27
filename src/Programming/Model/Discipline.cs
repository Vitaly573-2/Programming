using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Discipline
    {
        private string name;
        private string purpose;
        private int day;

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
    }
}
