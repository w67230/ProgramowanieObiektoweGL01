using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaKlas.Lab5
{
    public abstract class Transaction
    {
        public double Amount;
        public DateTime TransactionDate;

        public Transaction(double amount, DateTime transactionDate)
        {
            this.Amount = amount;
            this.TransactionDate = transactionDate;
        }

        public abstract void ProcessTransaction();
    }

    public class IncomeTransaction : Transaction
    {

        public IncomeTransaction(double amount, DateTime date)
            :base(amount, date)
        {
            
        }

        public override void ProcessTransaction()
        {
            Account.przychody += this.Amount;
        }
    }

    public class ExpenseTransaction : Transaction
    {

        public ExpenseTransaction(double amount, DateTime date)
            : base(amount, date)
        {

        }
        public override void ProcessTransaction()
        {
            Account.wydatki -= this.Amount;
        }
    }

    public class Account
    {
        public static double przychody = 0;
        public static double wydatki = 0;

        public List<Transaction> listaTransakcji = new List<Transaction>();

        public void addTransaction(Transaction transaction)
        {
            this.listaTransakcji.Add(transaction);
        }

        public Tuple<Double, Double> zwrocPrzychodyIWydatki()
        {
            przychody = 0;
            wydatki = 0;
            foreach(Transaction tr in this.listaTransakcji)
            {
                tr.ProcessTransaction();
            }
            return new Tuple<Double, Double>(przychody, wydatki);
        }

    }
}
