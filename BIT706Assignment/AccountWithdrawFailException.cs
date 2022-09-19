using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706Assignment
{
    public class AccountWithdrawFailException : Exception
    {
        public AccountWithdrawFailException()
        {

        }

        public AccountWithdrawFailException(string message) : base(message)
        {

        }
    }
}
