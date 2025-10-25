using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2
{
    public class AbstractCheck
    {
        protected int balance;
        public static int TotalBalance { get; protected set; }
        public int Balance { set { balance = value; } get { return balance; } }

        public virtual void addMoney(int amount) { }
        public virtual void removeMoney(int amount) { }
        
    }
}
