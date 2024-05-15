using Module17.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Calculator
{
    public static class InterestCalculator
    {
        public static void CalculateInterest(Account account, IInterestCalculator calculator)
        {
            account.Interest = calculator.CalculateInterest(account);
        }
    }
}
