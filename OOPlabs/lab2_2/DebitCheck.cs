using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2
{
    sealed public class DebitCheck : AbstractCheck
    {
        public DebitCheck(int amount)
        {
            this.balance = amount;
        }

        public override void addMoney(int amount)
        {
            this.balance += amount;
        }
        override public void removeMoney(int amount)
        {
            if (this.balance > amount && amount < 30000)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Невозможно выполнить операцию");
            }
        }
    }
}
