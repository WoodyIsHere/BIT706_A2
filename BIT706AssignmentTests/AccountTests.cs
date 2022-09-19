using Microsoft.VisualStudio.TestTools.UnitTesting;
using BIT706Assignment;

namespace BIT706AssignmentTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        [ExpectedException(typeof(AccountWithdrawFailException))]
        public void Account_Withdraw_FailedWithdrawTest()
        {
            Account a = new Everyday();
            a.Balance = 100;
            a.Withdraw(200);
        }

        [TestMethod]
        public void Account_EverydayConstructor()
        {
            Account a = new Everyday();
            int expectedBalance = 0;
            string expectedLastTrans = "No transactions.";

            Assert.AreEqual(expectedBalance, a.Balance);
            Assert.AreEqual(expectedLastTrans, a.LastTransaction);
        }

        [TestMethod]
        public void Account_InvestmentConstructor()
        {
            Account a = new Investment(5, 2);
            int expectedBalance = 0;
            string expectedLastTrans = "No transactions.";

            Assert.AreEqual(expectedBalance, a.Balance);
            Assert.AreEqual(expectedLastTrans, a.LastTransaction);
        }

        [TestMethod]
        public void Account_OmniConstructor()
        {
            Account a = new Omni(5, 2, -500);
            int expectedBalance = 0;
            string expectedLastTrans = "No transactions.";

            Assert.AreEqual(expectedBalance, a.Balance);
            Assert.AreEqual(expectedLastTrans, a.LastTransaction);
        }

        [TestMethod]
        public void Account_Details()
        {
            Account a = new Everyday();
            a.Balance = 500;
            string expectedDetails = a.AccountID + " Everyday, Balance: $500";

            Assert.AreEqual(expectedDetails, a.Details());
        }

        [TestMethod]
        public void Account_Withdraw()
        {
            Account a = new Everyday();
            a.Balance = 500;
            a.Withdraw(250);
            int expectedBalance = 250;

            Assert.AreEqual(expectedBalance, a.Balance);
        }

        [TestMethod]
        public void Account_Deposit()
        {
            Account a = new Everyday();
            a.Deposit(500);
            int expectedBalance = 500;

            Assert.AreEqual(expectedBalance, a.Balance);
        }

        [TestMethod]
        public void Account_CalculateInterestInvestment()
        {
            Account a = new Investment(5, 2);
            a.Balance = 100;
            a.Interest();

            int expectedBalance = 105;
            Assert.AreEqual(expectedBalance, a.Balance);
        }

        [TestMethod]
        public void Account_CalculateInterestOmni_LowBalance()
        {
            Account a = new Omni(5, 2, -500);
            a.Balance = 500;
            a.Interest();

            int expectedBalance = 500;
            Assert.AreEqual(expectedBalance, a.Balance);
        }
    }
}
