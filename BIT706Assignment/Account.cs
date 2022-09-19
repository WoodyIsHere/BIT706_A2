using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706Assignment
{
    public class Account
    {
        static int nextAccountID = 1;
        protected int accountID;
        protected string typeName;
        protected decimal balance;
        protected string lastTransaction;

        public Account()
        {
            accountID = nextAccountID;
            nextAccountID++;
            balance = 0;
            lastTransaction = "No transactions.";
        }

        public override string ToString()
        {
            return (accountID + " " + typeName + ", Balance: $" + balance);
        }

        public virtual string Details()
        {
            return (accountID + " " + typeName + ", Balance: $" + balance);
        }

        public int AccountID
        {
            get { return accountID; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string LastTransaction
        {
            get { return lastTransaction; }
        }

        public void Deposit(decimal depositAmount)
        {
            balance = (balance + depositAmount);
            lastTransaction = (typeName + " " + accountID.ToString() + ", Deposited: $" + depositAmount + ", Balance: $" + balance);
        }

        public virtual void Withdraw(decimal withdrawAmount)
        {
            if ((balance - withdrawAmount) >= 0)
            {
                balance = (balance - withdrawAmount);
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawn: $" + withdrawAmount + ", Balance: $" + balance);
            }
            else
            {
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawal failure - Not enough balance ");
                throw new AccountWithdrawFailException(typeName + " accounts can't withdraw more than the remaining balance.");
            }
        }

        public virtual void Interest()
        {
            lastTransaction = (typeName + " " + accountID.ToString() + ", Account type does not provide interest.");
        }
    }

    public class Everyday : Account
    {
        public Everyday()
        {
            typeName = "Everyday";
        }
    }

    public class Investment : Account
    {
        protected decimal interestRate;
        protected decimal failedTransFee;

        public Investment(decimal newInterestRate, decimal newFailedTransFee)
        {
            typeName = "Investment";
            interestRate = newInterestRate;
            failedTransFee = newFailedTransFee;
        }

        public override string Details()
        {
            return (typeName + " " + accountID.ToString() + ", Balance: $" + balance + ", Interest Rate: " + interestRate + "%" + ", Failed Transaction Fee: $" + failedTransFee);
        }

        private void Fee()
        {
            if ((balance - failedTransFee) >= 0)
            {
                balance = (balance - failedTransFee);
            }
            else
            {
                balance = 0;
            }
        }

        public override void Withdraw(decimal withdrawAmount)
        {
            if ((balance - withdrawAmount) >= 0)
            {
                balance = (balance - withdrawAmount);
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawn: $" + withdrawAmount + ", Balance: $" + balance);
            }
            else
            {
                Fee();
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawal failure - Not enough balance" + ", $" + failedTransFee + " fee incurred");
                throw new AccountWithdrawFailException(typeName + " accounts can't withdraw more than the remaining balance. $" + failedTransFee + " fee incurred");
            }
        }

        public override void Interest()
        {
            decimal interestTotal = Math.Round(((balance / 100) * interestRate), 2);
            balance += interestTotal;
            lastTransaction = (typeName + " " + accountID.ToString() + ", Interest added: $" + interestTotal + ", Balance: $" + balance);
        }
    }

    public class Omni : Account
    {
        protected decimal interestRate;
        protected decimal failedTransFee;
        protected decimal overdraftLimit;

        public Omni(decimal newInterestRate, decimal newFailedTransFee, decimal newOverdraftLimit)
        {
            typeName = "Omni";
            interestRate = newInterestRate;
            failedTransFee = newFailedTransFee;
            overdraftLimit = newOverdraftLimit;
        }

        public override string Details()
        {
            return (typeName + " " + accountID.ToString() + ", Balance: $" + balance + ", Interest Rate: " + interestRate + "% on balances over $1000" + ", Failed Transaction Fee: $" + failedTransFee);
        }

        private void Fee()
        {
            if ((balance - failedTransFee) >= overdraftLimit)
            {
                balance = (balance - failedTransFee);
            }
            else
            {
                balance = overdraftLimit;
            }
        }

        public override void Withdraw(decimal withdrawAmount)
        {
            if ((balance - withdrawAmount) >= overdraftLimit)
            {
                balance = (balance - withdrawAmount);
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawn: $" + withdrawAmount + ", Balance: $" + balance);
            }
            else
            {
                Fee();
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawal failure - Not enough balance" + ", $" + failedTransFee + " fee incurred");
                throw new AccountWithdrawFailException(typeName + " accounts can't withdraw past the overdraft limit of $" + overdraftLimit + ". $" + failedTransFee + " fee incurred");
            }
        }

        public override void Interest()
        {
            if (balance >= 1000)
            {
                decimal interestTotal = Math.Round(((balance / 100) * interestRate), 2);
                balance += interestTotal;
                lastTransaction = (typeName + " " + accountID.ToString() + ", Interest added: $" + interestTotal + ", Balance: $" + balance);
            }
            else
            {
                lastTransaction = (typeName + " " + accountID.ToString() + ", Balance of $1000 required for interest payment, Balance: $" + balance);
            }
        }
    }
}
