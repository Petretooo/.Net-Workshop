using System;
using System.Collections.Generic;
using System.Text;

namespace Loan
{
    class Bank
    {
        private double loan;
        public double Loan
        {
            get
            {
                return this.loan;
            }
            set
            {
                this.loan = value;
            }
        }
        private double annualInterest;
        public double AnnualInterest {
            get
            {
                return this.annualInterest;
            }
            set
            {
                this.annualInterest = annualInterest;
            }
        }
        private int months;
        public int Monthis
        {
            get
            {
                return this.months;
            }
            set
            {
                this.months = value;
            }
        }

        public Bank(double loan, double annualInterest, int months)
        {
            this.loan = loan;
            this.annualInterest = annualInterest;
            this.months = months;
        }


        public int Years()
        {
            int years = 0;
            for (int i = 1; i <= months; i++)
            {
                if (i % 12 == 0)
                {
                    years++;
                }
            }
            return years;
        }

        public void algorithmCompoundInterest()
        {
            int y = months / 12;

            annualInterest = annualInterest / 100;
            annualInterest = annualInterest / 12;

            double monthlyPayment = 0;
            monthlyPayment = loan * ((annualInterest * Math.Pow((1 + annualInterest), months)) / (Math.Pow((1 + annualInterest), months) - 1));
            Console.WriteLine();
            Console.WriteLine(String.Format("Monthly payment: {0:0.00}", monthlyPayment));
            Console.WriteLine(String.Format("Total payment: {0:0.00}", monthlyPayment*months));
            Console.WriteLine();
            double principal = 0;
            double interest = 0;
            double balance = 0;

            for (double i = 1; i <= months; i++)
            {
                interest = loan * annualInterest;
                principal = monthlyPayment - interest;
                balance = loan - principal;
                loan = balance;
                Console.WriteLine(String.Format("Month: {0:0} Interest: {1:0.00}, Principal: {2:0.00}, Balance: {3:0.00}",i,interest,principal,balance));
            }
        }


    }
}
