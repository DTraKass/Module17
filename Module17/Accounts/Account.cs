using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Accounts
{
    public enum AccoutType
    {
        Common, Salary
    };

    public class Account
    {
        public AccoutType Type { get; set; }

        public double Balance { get; set; }

        public double Interest { get; set; }

        public Account() { }
    }
}
