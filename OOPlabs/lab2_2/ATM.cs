using System;
using NUnit.Compatibility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2
{
    public class ATM
    {
        private Card card;

        public ATM(Card card)
        {
            this.card = card;
        }

        public void transfer(int amount, AbstractCheck check1, AbstractCheck chek2)
        {
            if (check1.Balance > amount)
            {
                check1.removeMoney(amount);
                chek2.addMoney(amount);
            }
            else
            {
                Console.WriteLine("Операция невозможна");
            }
        }

        public void withdrawCheck(int amount, CurrentCheck currCheck)
        {
            if (currCheck.Balance > amount && amount < 30000)
            {
                currCheck.removeMoney(amount);
                card.TotalBalance -= amount;
            }
            else
            {
                Console.WriteLine("Операция невозможна");
            }
        }
        public void withdrawCheck(int amount, DebitCheck debCheck)
        {
            if (card.CreditCheck.Balance > 20000)
            {
                if (card.Current.Balance > amount && amount < 30000)
                {
                    card.Current.removeMoney(amount);
                    card.TotalBalance -= amount;
                }
                else
                {
                    Console.WriteLine("Операция невозможна");
                }
            }
            else
            {
                Console.WriteLine("Погасите задолженность");
            }
        }
        public void withdrawCheck(int amount, CreditCheck credCheck)
        {
            if (amount < 30000)
            {
                credCheck.removeMoney(amount);
                card.TotalBalance -= amount;
            }
            else
            {
                Console.WriteLine("Операция невозможна");
            }
        }

        public void replenishCheck(int amount, AbstractCheck check)
        {
            if (amount >= 1000000 && check is CurrentCheck)
            {
                check.addMoney(amount);
                card.DebitCheck.addMoney(2000);
                card.TotalBalance += amount + 2000;
            }
            else if (check is DebitCheck && card.CreditCheck.Balance < -20000)
            {
                Console.WriteLine("Операция невозможна");
                return;
            }
            else
            {
                check.addMoney(amount);
                card.TotalBalance += amount;
            }
        }
    }
}
