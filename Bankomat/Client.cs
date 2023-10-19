using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Client
    {
        public string Name { get;}
        public string Password { get; }
        public Account Account { get; set; }

        public Client(string name, string password)
        {
            Name = name;
            Password = password;
            Account = null;
        }
    }
}
