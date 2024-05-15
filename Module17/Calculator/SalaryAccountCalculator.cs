using Module17.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Calculator
{
    public class SalaryAccountCalculator : IInterestCalculator
    {
        public double CalculateInterest(Account acc)
        {
            if (acc.Type != AccoutType.Salary)
                throw new ArgumentException();

            double interest = acc.Balance * 0.5;

            return interest;
        }
    }
}
