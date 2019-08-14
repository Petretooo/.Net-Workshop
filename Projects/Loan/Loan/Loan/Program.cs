﻿using System;

namespace Loan
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

            Bank person = new Bank(loan, annualInterest, months);

            Console.WriteLine($"Tha loan is {loan}, with annual interest of {annualInterest} percent for {months} months");
            person.algorithmCompoundInterest();
        }
    }
}
