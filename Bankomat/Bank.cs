using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Bank
    {
        public Account OpenAccount(Client client, decimal initialBalance)
        {
            if (client.Account == null)
            {
                client.Account = new Account(client, initialBalance);
                return client.Account;
            }
            return null; // У клиента уже есть счет
        }

        public bool CheckPassword(Client client, string password)
        {
            return client.Password == password;
        }
    }
}
