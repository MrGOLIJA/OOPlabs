using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2
{
    sealed public class CreditCheck : AbstractCheck 
    {
        public CreditCheck(int balance)
        {
            this.balance = balance;
        }
        override public void addMoney(int amount)
        {
            this.balance += amount;
        }
        override public void removeMoney(int amount)
        {
            if (amount < 30000)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Не возможно совершить операцию");
            }
        }
    }
}
