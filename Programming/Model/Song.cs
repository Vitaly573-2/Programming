using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private string name;
        private int number;
        private string author;

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
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }
}
