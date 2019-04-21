using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Common
    {
        //Abstract Factory
        public abstract class ICreditUnionFactory
        {
            public abstract ISavingsAccount CreateSavingsAccount();
            public abstract ILoanAccount CreateLoanAccount();
        }
        //Abstract Product A
        public interface ISavingsAccount
        {

        }
        //Abstract Product A
        public interface ILoanAccount
        {

        }
    }
}
