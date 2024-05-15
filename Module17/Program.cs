using Module17.Accounts;
using Module17.Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account();
        acc.Type = AccoutType.Salary;
        acc.Balance = 765.0;
        InterestCalculator.CalculateInterest(acc, new CommonAccountCalculator());
        InterestCalculator.CalculateInterest(acc, new SalaryAccountCalculator());
    }
}
