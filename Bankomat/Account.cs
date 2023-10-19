using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Account
    {
        public Client Owner { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; set; }

        public Account(Client owner, decimal initialBalance)
        {
            Owner = owner;
            AccountNumber = owner.Name; // Используем имя клиента в качестве номера счета
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
