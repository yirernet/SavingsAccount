using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccount.Library
{
    public class SavingsAccount
    {
        public static decimal CalculateRate(string inputString)
        {
            int.TryParse(inputString, out int input);
            double inputDbl = 0;
            decimal interestRate = 0;

            if (input <= 1000)
            {
                inputDbl = input * 0.01;
                interestRate = Math.Round((decimal)inputDbl, 2);
            }
            else if (input <= 5000)
            {
                inputDbl = input * 0.015;
                interestRate = Math.Round((decimal)inputDbl, 2);

            }
            else if (input <= 10000)
            {
                inputDbl = input * 0.02;
                interestRate = Math.Round((decimal)inputDbl, 2);
            }
            else if (input <= 50000)
            {
                inputDbl = input * 0.025;
                interestRate = Math.Round((decimal)inputDbl, 2);
            }
            else if (input > 50000)
            {
                inputDbl = input * 0.03;
                interestRate = Math.Round((decimal)inputDbl, 2);
            }
            return interestRate;
        }
    }
}
