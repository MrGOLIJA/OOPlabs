using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2
{
    sealed public class CurrentCheck : AbstractCheck
    {
        public CurrentCheck(int balance)
        {
            this.balance = balance;
            TotalBalance += balance;
        }
        override public void addMoney(int amount)
        {
            TotalBalance += amount;
            this.balance += amount;
        }
        override public void removeMoney(int amount) 
        { 
            if(this.balance>=amount && amount <= 30000)
            {
                TotalBalance -= amount;
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Невозможно выполнить операцию");
            }
        }

    }
}
