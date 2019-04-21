using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace CityCreditUnion
{
    //Concreate Product A1
    public class CityLoanAccount : Common.ILoanAccount
    {
        public CityLoanAccount()
        {
            Console.WriteLine("Returned City Loan Account");
        }
    }
    //Concrete Product B1
    public class CitySavingsAccount : Common.ISavingsAccount
    {
        public CitySavingsAccount()
        {
            Console.WriteLine("Returned City Savings Account");
        }
    }
    //Concrete Factory 1
    public class CityCreditUnionFactory : Common.ICreditUnionFactory
    {
        public override Common.ILoanAccount CreateLoanAccount()
        {
            CityLoanAccount obj = new CityLoanAccount();
            return obj;
        }

        public override Common.ISavingsAccount CreateSavingsAccount()
        {
            CitySavingsAccount obj = new CitySavingsAccount();
            return obj;
        }
    }

}
