using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIcalculator
{
     class SavingCalculator
    {
        private double deposit = 0.0;
        private double years = 0.0;
        private double intrestRateYear = 0.10;
        private double amountPaid = 0.0;
        

        // 1 Read input from Monthly deposit and years and do tryparse
        
        // variables:
        // int Deposit
        // int years
        // double intrestrateyear = 0.10
        
        // void: calculate amount paid by deposit * years
        // void: Final balance = 
        public double GetDeposit()
        {
            return deposit;
        }

        public void SetDeposit(double deposit)
        {
            this.deposit = deposit;
        }

        public double GetYears()
        {
            return years;
        }

        public void SetYears(double years)
        {
            this.years = years;
        }

        public double CalculateAmountPaid()
        {
            
            amountPaid = deposit * years * 12;
            return amountPaid;
        }
        public double CalculateBalance() //https://www.investor.gov/financial-tools-calculators/calculators/compound-interest-calculator
        {
            double balance = 0.0;
            balance = balance + deposit;
            double yearstomonth = years * 12; 
            double monthlyIntrest = intrestRateYear/12;
            double intrestEarned = 0.0;

            for (int i = 1; i < yearstomonth; i++)
            {
                intrestEarned = monthlyIntrest * balance; 
                balance += intrestEarned + deposit;
            }

            
            return balance;
        }
        

    }
}
