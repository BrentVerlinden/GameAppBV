using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppBV
{
    public class User
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public User() { }
        public User(string name) { this.Name = name; }
        public User(string name, string address) 
        {
            this.Name = name;
            this.Address = address;
        }

    }
}
