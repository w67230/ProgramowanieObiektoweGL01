using BibliotekaKlas.Lab5;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestyJednostkowe.Lab5
{
    class Zad2
    {

        Account account = new Account();
        

        [SetUp]
        public void Setup()
        {
            account.addTransaction(new IncomeTransaction(15, DateTime.Now));
            account.addTransaction(new IncomeTransaction(25, DateTime.Now));
            account.addTransaction(new IncomeTransaction(60, DateTime.Now));
            account.addTransaction(new ExpenseTransaction(20, DateTime.Now));
            account.addTransaction(new ExpenseTransaction(5, DateTime.Now));
        }

        [Test]
        public void Test1()
        {
            Tuple<Double, Double> tuple = account.zwrocPrzychodyIWydatki();
            double suma = tuple.Item1 + tuple.Item2;
            Assert.AreEqual(75d, suma);
            

        }
    }
}
