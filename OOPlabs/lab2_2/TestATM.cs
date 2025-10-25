using NUnit.Framework;

namespace OOPlabs.lab2
{
    [TestFixture]
    public class TestATM
    {
        [Test]
        public void addInDebitCheck()
        {
            DebitCheck debitCheck = new DebitCheck(50000);
            debitCheck.addMoney(20000);
            Assert.That(debitCheck.Balance, Is.EqualTo(70000));
        }
        [Test]
        public void addInCreditCheck()
        {
            CreditCheck creditCheck = new CreditCheck(50000);
            creditCheck.addMoney(20000);
            Assert.That(creditCheck.Balance, Is.EqualTo(70000));
        }
        [Test]
        public void addInCurrentCheck()
        {
            CurrentCheck currentCheck = new CurrentCheck(50000);
            currentCheck.addMoney(20000);
            Assert.That(currentCheck.Balance, Is.EqualTo(70000));
        }
        [Test]
        public void removeInDebitCheck()
        {
            DebitCheck debitCheck = new DebitCheck(50000);
            debitCheck.removeMoney(25000);
            Assert.That(debitCheck.Balance, Is.EqualTo(25000));
        }
        [Test]
        public void removeInCreditCheck()
        {
            CreditCheck creditCheck = new CreditCheck(50000);
            creditCheck.removeMoney(25000);
            Assert.That(creditCheck.Balance, Is.EqualTo(25000));
        }
        [Test]
        public void removeInCurrentCheck()
        {
            CurrentCheck currentCheck = new CurrentCheck(50000);
            currentCheck.removeMoney(25000);
            Assert.That(currentCheck.Balance, Is.EqualTo(25000));
        }
        [Test]
        public void remove30000()
        {
            CreditCheck creditCheck = new CreditCheck(50000);
            DebitCheck debitCheck = new DebitCheck(50000);
            CurrentCheck currentCheck = new CurrentCheck(50000);
            creditCheck.removeMoney(50000);
            debitCheck.removeMoney(50000);
            currentCheck.removeMoney(50000);
            Assert.That(creditCheck.Balance, Is.EqualTo(50000));
            Assert.That(currentCheck.Balance, Is.EqualTo(50000));
            Assert.That(debitCheck.Balance, Is.EqualTo(50000));
        }
        [Test]
        public void noDebitWhenCredit()
        {
            Card card = new Card(20000, -300000, 50000);
            ATM atm = new ATM(card);
            atm.replenishCheck(20000, card.DebitCheck);
            Assert.That(card.DebitCheck.Balance, Is.EqualTo(50000));
        }
        [Test]
        public void autoAddInDebit()
        {
            Card card = new Card(20000, 20000, 20000);
            ATM ATM = new ATM(card);
            ATM.replenishCheck(1000000, card.Current);
            Assert.That(card.DebitCheck.Balance, Is.EqualTo(22000));
        }
        [Test]
        public void checkTransfer()
        {
            Card card = new Card(20000, 20000, 20000);
            ATM atm = new ATM(card);
            atm.transfer(15000, card.DebitCheck, card.Current);
            Assert.That(card.DebitCheck.Balance, Is.EqualTo(5000));
            Assert.That(card.Current.Balance, Is.EqualTo(35000));
        }
    }
}
