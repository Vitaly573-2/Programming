using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact
    {
        private string _name;
        private int _number;
        private string _email;
    
        public string Name { get; set; }
        public int Number { get; set; }

        public string Email { get; set; }

        public Contact()
        {
            Name = string.Empty;
            Number = 0;
            Email = string.Empty;
        }

        public Contact(string name, int number, string email)
        {
            Name = name;
            Number = number;
            Email = email;
        }
    }
}
