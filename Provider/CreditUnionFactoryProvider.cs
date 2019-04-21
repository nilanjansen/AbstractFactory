using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using CityCreditUnion;
using NationalCreditUnion;

namespace Provider
{
    public class FactoryProvider
    {
        public static Common.ICreditUnionFactory GetCreditUnionFactory(string accNo)
        {
            if (accNo.Contains("CITI")) { return new CityCreditUnionFactory(); }
            else if (accNo.Contains("NATIONAL")) { return new NationalCreditUnionFactory(); }
            else
                return null;
        }
    }
}
