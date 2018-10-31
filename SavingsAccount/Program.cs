using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SavingsAccount.Library;

namespace SavingsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your saving account balance to calculate your interest rate:");
            string inputBalance = Console.ReadLine();

            string outputInterestRate = SavingsAccount.Library.SavingsAccount.CalculateRate(inputBalance);
            

            Console.WriteLine("Your interest Rate is: " + outputInterestRate);
            Console.WriteLine("Please, press any key to continue.");


            Console.ReadKey();
        }
    }
}
