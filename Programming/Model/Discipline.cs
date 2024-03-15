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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
    }
}
