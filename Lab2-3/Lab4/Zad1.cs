using BibliotekaKlas.Lab4;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestyJednostkowe.Lab4
{
    class Zad1
    {

        List<Shape> list = new List<Shape>();

        [SetUp]
        public void Setup()
        {
            list.Add(new Rectangle());
            list.Add(new Triangle());
            list.Add(new Circle());
            list.Add(new Shape());
        }

        [Test]
        public void Test1()
        {
            
            Assert.AreEqual("Rectangle", list[0].Draw());
            Assert.AreEqual("Triangle", list[1].Draw());
            Assert.AreEqual("Circle", list[2].Draw());
            Assert.AreEqual("Shape", list[3].Draw());

        }
    }
}
