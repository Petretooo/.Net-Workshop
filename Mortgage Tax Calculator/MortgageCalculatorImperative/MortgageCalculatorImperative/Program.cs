using System;

namespace MortgageCalculatorImperative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Loan: ");
            double loan = double.Parse(Console.ReadLine());
            Console.Write("Enter Annual Interest: ");
            double annualInterest = double.Parse(Console.ReadLine());
            Console.Write("Enter months: ");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Tha loan is ${loan}, with annual interest of {annualInterest}% for {months} months");
            annualInterest = (annualInterest / 100) / 12;
            double monthly = monthlyPayment(loan, annualInterest, months);
            totalPayment(monthly, months);
            mortgageSchedule(monthly, loan, annualInterest, months);


        }

        static double monthlyPayment(double loan, double annualInterest, int months)
        {
            double monthlyPayment = 0;
            monthlyPayment = loan * ((annualInterest * Math.Pow((1 + annualInterest), months)) / (Math.Pow((1 + annualInterest), months) - 1));
            Console.WriteLine();
            Console.WriteLine(String.Format("Monthly payment: ${0:0.00}", monthlyPayment));
            return monthlyPayment;
        }

        static void totalPayment(double monthlyPayment, int months)
        {
            double monthly = monthlyPayment;

            Console.WriteLine(String.Format("Total payment: ${0:0.00}", monthly * months));
            Console.WriteLine();
        }

        static void mortgageSchedule(double monthlyPayment, double loan, double annualInterest, int months)
        {
            double monthly = monthlyPayment;

            double principal = 0;
            double interest = 0;
            double balance = 0;

            for (double i = 1; i <= months; i++)
            {
                interest = loan * annualInterest;
                principal = monthly - interest;
                balance = loan - principal;
                loan = balance;
                Console.WriteLine(String.Format("Month: {0:0} Interest: ${1:0.00}, Principal: ${2:0.00}, Balance: ${3:0.00}", i, interest, principal, balance));
            }
        }
    }
}
