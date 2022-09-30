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
        private double intrestRateYear = 0.0;
        private double amountPaid = 0.0;
        private double tax = 0.0;
        private double totalAmountEarned;
        private double taxInAmount;

       // Tax is paid from total balance not each year not each month.
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

        public void SetIntrestRate(double intrestRate)
         {
         this.intrestRateYear = intrestRate/100; // divided by 100 to get procentage
        }

        public void SetTax(double tax)
        {
            this.tax = tax/100; // divided by 100 to get procentage
        }


        public double CalculateBalance() //https://www.investor.gov/financial-tools-calculators/calculators/compound-interest-calculator
        {
            // this method calculates final balance
            // To save time and write method for calculating tax and Amount earned from intrest, calculations are send to- 
            // -instance variables this.totalAmountEarned and this.taxInAmount.

            double balance = 0.0;
            balance = balance + deposit;
            double yearstomonth = years * 12; 
            double monthlyIntrest = intrestRateYear/12;
            double intrestEarned = 0.0; 
            double TotalamountEarned = 0.0;
            double taxAmount = 0.0;
            

            for (int i = 1; i < yearstomonth; i++)
            {
                intrestEarned = monthlyIntrest * balance; 
                balance += (intrestEarned + deposit);
                TotalamountEarned += intrestEarned; // everytime loop goes it adds current intrest amount into variable TotalAmountEarned 
            }
            
            taxAmount = balance * tax; // saving tax into variable taxAmount
            this.taxInAmount = taxAmount; // saving taxtamount to instance variable.
            this.totalAmountEarned = TotalamountEarned - taxAmount; // adding intrest earned from calculations to the instance variable.
            balance -= taxAmount; // calculating final balance - tax
            return balance;
        }

        public double ReturnIntrestEarned()
        {
            return this.totalAmountEarned;
        }

        public double ReturnTaxAmount()
        {
            return this.taxInAmount;
        }


    }
}
