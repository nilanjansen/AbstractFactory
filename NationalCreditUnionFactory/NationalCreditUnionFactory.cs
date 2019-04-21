using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace NationalCreditUnion
{
    //ConcreteProduct A2
    public class NationalSavingsAccount:Common.ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned National Savings Account");
        }   
    }
    //Concreate Product B2
    public class NationalLoanAccount : Common.ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }
    //Concrete Factory 2
    public class NationalCreditUnionFactory : Common.ICreditUnionFactory
    {
        public override Common.ILoanAccount CreateLoanAccount()
        {
            NationalLoanAccount obj = new NationalLoanAccount();
            return obj;
        }

        public override Common.ISavingsAccount CreateSavingsAccount()
        {
            NationalSavingsAccount obj = new NationalSavingsAccount();
            return obj;
        }
    }
}
