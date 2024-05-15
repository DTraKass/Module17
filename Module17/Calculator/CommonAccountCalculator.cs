using Module17.Accounts;

namespace Module17.Calculator
{
    public class CommonAccountCalculator : IInterestCalculator
    {
        public double CalculateInterest(Account acc)
        {
            if(acc.Type != AccoutType.Common)
            throw new ArgumentException();

            double interest = acc.Balance * 0.4;

            if (acc.Balance < 1000)
                interest -= acc.Balance * 0.2;

            if (acc.Balance >= 1000)
                interest -= acc.Balance * 0.1;

            return interest;
        }
    }
}
