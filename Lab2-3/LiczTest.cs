using System;
using BibliotekaKlas.Lab2_3;
using NUnit.Framework;

namespace TestyJednostkowe
{

    public class LiczTest
    {

        private Licz licz;

        [SetUp]
        public void Setup()
        {
            licz = new Licz(12);
        }
	   

        [Test]
        public void TestDodaj()
        {
            Assert.AreEqual(licz.getWartosc(), 12);
        }
    }
}

