﻿using HerancaExer.Entities;
using System.Globalization;

namespace HerancaExer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new(1001, "Alex", 0.0);
            //BusinessAccount bcc = new(1002, "Maria", 0.0, 500.0);

            //// UPCASTING 

            //Account acc1 = bcc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ////Downcasting

            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(1000.0);

            //if (acc3 is BusinessAccount)
            //{
            //    BusinessAccount acc5 = (BusinessAccount)acc3;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}
            //if (acc4 is SavingsAccount)
            //{
            //    SavingsAccount acc5 = (SavingsAccount)acc3;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update");
            //} 


            //Account acc1 = new(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1000, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account account in list)
            {
                sum += account.Balance;
            }
            Console.WriteLine($"Total Balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine($"Updated balance for account " +
                    $"{acc.Number} : {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}