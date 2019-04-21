using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Provider;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Abstract Factory overview

            The gang of four describes the abstract factory pattern as providing an interface for creating families
            of related or dependent objects without specifying their concrete classes. So we already talked about what 
            factory methods are and how they are factories responsible for creating objects, well you can think of the 
            abstract factory pattern as a factory for creating factories, it's like the factory method pattern,
            but everything is encapsulated, it's a higher level of abstraction using interfaces and abstract classes. 
            Let's take a look at this class diagram. Let's start on the left hand side with the abstract factory. 
            That simply declares an interface for operations that create abstract product objects, and right below 
            it is a concrete factory, which implements the operations to create concrete product objects. 
            - Now on the right hand side we have our products, abstract product A and abstract product B, 
            those declare an interface for a type of product object, and below those are their concrete products,
            which defines a product object to be created by the corresponding concrete factory. On the upper right 
            hand side we have our client, and what's important to point out there is that they point to the abstractions, 
            the abstract factory and the abstract product A and B. To put this more in real terms let's continue with our 
            banking theme. Say we had two credit unions, they can both be considered our factories, each have a savings 
            account and a loans account, those can be the products, on the upper left hand side here we see that Icredit 
            union factory takes place as the abstract factory. And below it the concrete factories are Citi credit union 
            factory and National credit union factory, and below those are the implementations, on the right hand side our
            products are Iloan account and Isavings account, and below them are their concrete implementations of the
            products,
            */
            List<string> accntNumbers = new List<string>
            {
                "CITI-456",
                "NATIONAL-123",
                "PEGASUS-4231"
            };
            for (int i = 0; i < accntNumbers.Count; i++)
            {
                Common.ICreditUnionFactory abstractFac = FactoryProvider.GetCreditUnionFactory(accntNumbers[i]);
                if(abstractFac == null)
                {
                    Console.WriteLine("Sorry this credit union w/ account Number"
                                    + "'{0}' is invalid", accntNumbers[i]);
                }
                else
                {
                    Common.ILoanAccount loanAccount = abstractFac.CreateLoanAccount();
                    Common.ISavingsAccount savingsAccount = abstractFac.CreateSavingsAccount();
                }
            }
            Console.ReadLine();
        }
    }
}
