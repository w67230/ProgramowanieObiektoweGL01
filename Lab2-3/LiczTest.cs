using System;
using BibliotekaKlas.Lab2;
using NUnit.Framework;

namespace Lab2_3
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

