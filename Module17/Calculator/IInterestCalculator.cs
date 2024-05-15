﻿using Module17.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Calculator
{
    public interface IInterestCalculator
    {
        public double CalculateInterest(Account acc);
    }
}
