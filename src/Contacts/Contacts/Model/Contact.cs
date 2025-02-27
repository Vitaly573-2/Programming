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
        private int _phoneNumber;
        private string _email;
    
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public Contact()
        {
            Name = string.Empty;
            PhoneNumber = 0;
            Email = string.Empty;
        }

        public Contact(string name, int phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
