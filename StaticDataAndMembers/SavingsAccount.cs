using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;
        public static double currInterestRate = 0.04;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
    }
}
