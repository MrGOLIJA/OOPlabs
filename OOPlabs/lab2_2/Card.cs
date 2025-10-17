using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2
{
    public class Card
    {
        private CurrentCheck currCheck;
        private DebitCheck debitCheck;
        private CreditCheck creditCheck;
        private int totalBalance;

        public Card()
        {
            currCheck = new CurrentCheck(0);
            debitCheck = new DebitCheck(0);
            creditCheck = new CreditCheck(0);
            totalBalance = 0;
        }
        public Card(int balanceCurrent)
        {
            currCheck = new CurrentCheck(balanceCurrent);
            debitCheck = new DebitCheck(0);
            creditCheck = new CreditCheck(0);
            totalBalance = balanceCurrent;
        }

        public Card(int balanceCurrent, int balanceCredit)
        {
            currCheck = new CurrentCheck(balanceCurrent);
            creditCheck = new CreditCheck(balanceCredit);
            debitCheck = new DebitCheck(0);
            totalBalance = balanceCurrent + balanceCredit;
        }

        public Card(int balanceCurrent, int balanceCredit, int balanceDebit)
        {
            currCheck = new CurrentCheck(balanceCurrent);
            creditCheck = new CreditCheck(balanceCredit);
            debitCheck = new DebitCheck(balanceDebit);
            totalBalance = balanceCurrent + balanceCredit + balanceDebit;
        }
        public CurrentCheck Current { get { return currCheck; } }
        public CreditCheck CreditCheck { get { return creditCheck; } }
        public DebitCheck DebitCheck { get { return debitCheck; } }
        public int TotalBalance { set { totalBalance = value; } get { return totalBalance; } }

    }
}
